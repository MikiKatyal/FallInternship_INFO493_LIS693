using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CF_CHash_Dictionary;

namespace CF_CHash_Dictionary._01_Library
{
    public class clsDictionary
    {

        #region Variables
        private string strInputFilename;
        private string strInputFilepath;
        private string[] arrstrWords;

        private Dictionary<int, string> objExistingDictionary;
        private Dictionary<int, string> objWordExistingDictionary;
        private Dictionary<int, string> objNewWordsDictionary;
        private Dictionary<int, string> objNewConstantDictionary;

        private ListView lstExistingDictionary;
        private ListView lstSourceCodeWordExisting;
        private ListView lstSourceCodeWordNew;
        private ListView lstNewConstant;

        #endregion

        #region Properties
        private static string ThisClassName //Default Design
        {
            //Note : This property should by private if delcared in a bas module
            get { return System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name; }
            //set { strName = value; }
        }
        private string InputFileName
        {
            get { return strInputFilename; }
            set { strInputFilename = value; }
        }
        private string InputFilepath
        {
            get { return strInputFilepath; }
            set { strInputFilepath = value; }
        }
        public Dictionary<int, string> ExistingDictionary
        {
            get { return objExistingDictionary; }
            set
            {
                if (value == null) throw new ArgumentNullException("Dictionary connot be null");
                objExistingDictionary = value;
            }
        }
        public Dictionary<int, string> WordExistingDictionary
        {
            get { return objWordExistingDictionary; }
            set
            {
                if (value == null) throw new ArgumentNullException("Dictionary connot be null");
                objWordExistingDictionary = value;
            }
        }
        public Dictionary<int, string> NewWordsDictionary
        {
            get { return objNewWordsDictionary; }
            set
            {
                if (value == null) throw new ArgumentNullException("Dictionary connot be null");
                objNewWordsDictionary = value;
            }
        }
        public Dictionary<int, string> NewConstantDictionary
        {
            get { return objNewConstantDictionary; }
            set
            {
                if (value == null) throw new ArgumentNullException("Dictionary connot be null");
                objNewConstantDictionary = value;
            }
        }

        public ListView ListView_ExistingDictionary
        {
            get { return lstExistingDictionary; }
            set { lstExistingDictionary = value; }
        }
        public ListView ListView_DictionaryConst_InSourceCode
        {
            get { return lstSourceCodeWordExisting; }
            set { lstSourceCodeWordExisting = value; }
        }
        public ListView ListView_NewWord_InSourceCode
        {
            get { return lstSourceCodeWordNew; }
            set { lstSourceCodeWordNew = value; }
        }
        public ListView ListView_DictionaryNewWords
        {
            get { return lstNewConstant; }
            set { lstNewConstant = value; }
        }
        #endregion


        // Read existing dictionary file

        #region Functions
        public bool Initialize()
        {
            objExistingDictionary = new Dictionary<int, string>();
            objWordExistingDictionary = new Dictionary<int, string>();
            objNewWordsDictionary = new Dictionary<int, string>();
            objNewConstantDictionary = new Dictionary<int, string>();
            return true;
        }

        // Dictionary Fuctions
        public bool ListView_DictionaryNewWords_Clear ()
        {
            objNewConstantDictionary.Clear();
            return true;
        }


        private DataTable DataTable_Constants_Create()
        {
            // Creating a new DataTable to hold constant names and values
            DataTable dt = new DataTable();
            dt.Columns.Add("ConstantName", typeof(string));
            dt.Columns.Add("ConstantValue", typeof(string));
            dt.Columns.Add("FormattedValue", typeof(string));


            return dt;
        }
        private DataTable DataTable_SourceCode_Create()
        {
            // Creating a new DataTable to hold lines of SourceCode
            DataTable dt = new DataTable();
            dt.Columns.Add("RowId", typeof(int));
            dt.Columns.Add("BlockTag", typeof(string));
            dt.Columns.Add("LineTag", typeof(string));
            dt.Columns.Add("WordArray", typeof(object));

            return dt;
        }

        public DataTable Read_Dictionary(string filePath)
        {

            DataTable dtConstants = DataTable_Constants_Create();

            try
            {
                // Open the file for reading line by line
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Trim any leading or trailing spaces from the line
                        line = line.Trim();

                        // Skip comment lines (lines starting with "//")
                        if (line.StartsWith("//"))
                        {
                            continue;
                        }
                          string pattern = @"public\s+const\s+string\s+(\w+)\s*=\s*""([^""]+)""\s*;";
                       
;

                        // Try matching the line with the regex pattern
                        Match match = Regex.Match(line, pattern);



                        if (match.Success)
                        {
                            // Extract the constant name and value
                            string constantName = match.Groups[1].Value;
                            string constantValue = match.Groups[2].Value;

                            // Format the string to show both name and value with brackets
                            string formattedString = $"{constantName}  [{constantValue}]";


                            // Add the formatted constant to the ListBox
                            dtConstants.Rows.Add(constantName, constantValue, formattedString);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtConstants;


        }

        // Read a file with given file name and path
        private StreamReader Read_File(string filePath)
        {
            // Implementation of reading file logic
            StreamReader reader;
            reader = new StreamReader(filePath);

            return reader;
        }


        // Read input source code
        public DataTable Read_SourceCode(string filePath)
        {
            string strSelectedWord;
            DataTable dtConstants = DataTable_Constants_Create();

            try
            {
                // Open the file for reading line by line
                using (StreamReader reader = Read_File(filePath))
                //using (StreamReader reader = new StreamReader(filePath))

                {
                    ListView_DictionaryConst_InSourceCode.Columns.Clear();
                    ListView_DictionaryConst_InSourceCode.Items.Clear();
                    ListView_DictionaryConst_InSourceCode.View = View.Details;
                    ListView_DictionaryConst_InSourceCode.Columns.Add("Id", (int)(ListView_DictionaryConst_InSourceCode.Width *.5));
                    ListView_DictionaryConst_InSourceCode.Columns.Add("Value", (int)(ListView_DictionaryConst_InSourceCode.Width * .5));
                    WordExistingDictionary.Clear();

                    ListView_NewWord_InSourceCode.Columns.Clear();
                    ListView_NewWord_InSourceCode.Items.Clear();
                    ListView_NewWord_InSourceCode.View = View.Details;
                    ListView_NewWord_InSourceCode.Columns.Add("Id", (int)(ListView_NewWord_InSourceCode.Width * .25));
                    ListView_NewWord_InSourceCode.Columns.Add("Value", (int)(ListView_NewWord_InSourceCode.Width * .75));
                    NewWordsDictionary.Clear();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Trim any leading or trailing spaces from the line
                        line = line.Trim();
                        if (line.Length == 0 || string.IsNullOrEmpty(line) || line.TrimStart().StartsWith("//"))
                            continue;

                        arrstrWords = line.Split(' ');
                        arrstrWords = BreakLineIntoWords(line);


                        foreach (string word in arrstrWords)
                        {
                            strSelectedWord = word.Trim('\"', '\"', ';');
                            //MessageBox.Show("Select Word : " + strSelectedWord );


                            if (ExistingDictionary.ContainsValue(strSelectedWord))
                            {
                                foreach (var row in ExistingDictionary)
                                {
                                    if (row.Value.ToString() == strSelectedWord)
                                    {
                                        //if (WordExistingDictionary.Count == 0)
                                        //{
                                        //    // Add to Dictionary 
                                        //    WordExistingDictionary.Add(1, strSelectedWord);

                                        //    // Add to Listview 
                                        //    var lstviewitem = new ListViewItem(row.Key.ToString());
                                        //    lstviewitem.SubItems.Add(strSelectedWord);

                                        //    ListView_DictionaryConst_InSourceCode.Items.Add(lstviewitem);
                                        //    //ListView_DictionaryConst_InSourceCode.Refresh();

                                        //}
                                        if (WordExistingDictionary.ContainsValue(strSelectedWord) == false)
                                        {
                                            // Add to Dictionary 
                                            WordExistingDictionary.Add(WordExistingDictionary.Count, strSelectedWord);

                                            // Add to Listview 
                                            var lstviewitem = new ListViewItem(row.Key.ToString());
                                            lstviewitem.SubItems.Add(strSelectedWord);

                                            ListView_DictionaryConst_InSourceCode.Items.Add(lstviewitem);
                                            //ListView_DictionaryConst_InSourceCode.Refresh();

                                        }

                                        break;
                                    }
                                }
                            }
                            else
                            {
                                //TBD
                                // Check and use function classificationOfExpression()
                                // If not in any categories 
                                string newConst = "";
                                bool bolClassified = false;
                                if (objNewConstantDictionary.ContainsValue(strSelectedWord) == false)
                                {
                                    if (ClassificationOfExpression(strSelectedWord, out newConst))

                                    {
                                        if (!String.IsNullOrEmpty(strSelectedWord.Trim())) 
                                        { 
                                        // Add to Dictionary
                                        NewConstantDictionary.Add(NewConstantDictionary.Count, strSelectedWord);

                                        // Add to ListViewItem
                                        ListViewItem lstviewitem = new ListViewItem((lstNewConstant.Items.Count).ToString());
                                        lstviewitem.SubItems.Add(newConst);
                                        lstviewitem.SubItems.Add(strSelectedWord);

                                        // Add the item to the ListView
                                        lstNewConstant.Items.Add(lstviewitem);
                                        bolClassified |= true;
                                        }
                                    }
                                }


                                if (bolClassified == false)
                                {
                                    //if (NewWordsDictionary.Count == 0)
                                    //{
                                    //    NewWordsDictionary.Add(1, strSelectedWord);

                                    //    var lstviewitem = new ListViewItem("1");
                                    //    lstviewitem.SubItems.Add(strSelectedWord);

                                    //    ListView_NewWord_InSourceCode.Items.Add(lstviewitem);


                                    //}

                                    if (!NewWordsDictionary.ContainsValue(strSelectedWord))
                                    {
                                        NewWordsDictionary.Add(NewWordsDictionary.Count, strSelectedWord);

                                        var lstviewitem = new ListViewItem((ListView_NewWord_InSourceCode.Items.Count).ToString());
                                        lstviewitem.SubItems.Add(strSelectedWord);

                                        ListView_NewWord_InSourceCode.Items.Add(lstviewitem);

                                        //NewWordsDictionary.Add(NewWordsDictionary.Count+1, strSelectedWord);
                                        //ListView_NewWord_InSourceCode.Items.Add((NewWordsDictionary.Count + 1).ToString(),strSelectedWord);
                                        //ListView_NewWord_InSourceCode.Refresh();
                                    }
                                }
                            }

                        }
                        //string[] words = line.Split(' ');
                        //int wordscounter = words.Length;
                        //MessageBox.Show("LineText : \n" + line +  "\n\n Word Count " +  wordscounter.ToString());


                        //string pattern = @"public\s+const\s+string\s+(\w+)\s*=\s*""([^""]+)""\s*;";

                        //// Try matching the line with the regex pattern
                        //Match match = Regex.Match(line, pattern);



                        //if (match.Success)
                        //{
                        //    // Extract the constant name and value
                        //    string constantName = match.Groups[1].Value;
                        //    string constantValue = match.Groups[2].Value;

                        //    // Format the string to show both name and value with brackets
                        //    string formattedString = $"{constantName}  [{constantValue}]";


                        //    // Add the formatted constant to the ListBox
                        //    dtConstants.Rows.Add(constantName, constantValue, formattedString);
                        //}
                        //continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtConstants;
        }

        // Private method to read flat file (Dictionary or Source code)

        // Private method to break function into lines
        private void BreakFileToLines(StreamReader filePointer)
        {
            // Implementation to read file line by line and split into words
        }

        // Private method to break line into words
        private string[] BreakLineIntoWords(string line)
        {
            string WordSelected;
            string[] arrstrReturnWords = new string[1];

            // Implementation of splitting line into words
            string[] arrstrWords = line.Split(' ');
            int Wordscounter = arrstrWords.Length;
            //MessageBox.Show("LineText : \n" + line + "\n\n Word Count " + Wordscounter.ToString());

            foreach (string word in arrstrWords)
            {
                WordSelected = word.Trim();

                // Skip comment lines (lines starting with "//")
                if (line.StartsWith("//"))
                {
                    // Comments - Add the full Line to return array
                    arrstrReturnWords[0] = line;
                }
                else if (WordSelected == string.Empty)
                {
                    // Blank line - Add The word as it is or add a line feed to return array
                    Array.Resize(ref arrstrReturnWords, arrstrReturnWords.Length + 1);
                    arrstrReturnWords[0] = word;

                }
                else if (WordSelected.Contains("("))
                {

                }
            }


            return arrstrWords;
        }

        // Private method to classify word expressions

        private bool ClassificationOfExpression(string word, out string newConst)
        {
            //private void ClassificationOfExpression(string line, string word)
            //TBD
            // Change to only one paramiter word 
            // word and class fype will be the return string 
            string classType = "";
            string identity = "";
            bool isClassified = false;
            // Example of rule-based classification

            newConst = "";



            if (IsKeyword(word, out newConst))
            {
                classType = "Keyword";
                identity = "Syntax";
                isClassified = true;
            }
            else if (IsConstant(word))
            {
                classType = "Constant";
                identity = "Value";
                isClassified = false;
            }
            else if (IsUserDefinedIdentifier(word))
            {
                classType = "UserDefined";
                identity = "Variable";
                isClassified = false;
            }
            else if (IsClassName(word))
            {
                classType = "UserDefined";
                identity = "Class";
                isClassified = false;
            }

            return isClassified;

            //TBD
            // Change if no any class then return classType = "UserDefined"
            // Here we could store this classification information or return it.
            // Console.WriteLine($"Word: {word}, ClassType: {classType}, Identity: {identity}");
        }
        private bool IsKeyword(string word, out string newConst)
        {
            // List of keywords in C#
            string[] keywords = { "int", "public", "class", "void", "string", "if", "else", "for", "while" };
            newConst = "";
            bool iskey = false;
            if (Array.Exists(keywords, k => k == word))
            {

                newConst = "Ccodekey" + word;
                iskey = true;
            }
            return iskey;
        }
        private bool IsConstant(string word)
        {
            // Simple check if word is a number

            return int.TryParse(word, out _);
        }
        private bool IsUserDefinedIdentifier(string word)
        {
            // Basic check: could check if it is not a keyword and matches typical variable naming rules
            //return !IsKeyword(word) && !int.TryParse(word, out _);
            return true;
        }
        private bool IsClassName(string word)
        {
            // Example check if word might represent a class (could also check against known class names)
            return Char.IsUpper(word[0]);
        }
        #endregion
        // Write dictionary to file
        //public void WriteDictionary(string filePath, System.Windows.Forms.ListView lstNewConstant)
        //{
        //    if (string.IsNullOrEmpty(filePath))
        //    {
        //        MessageBox.Show("Please specify the output file path.");
        //        return;
        //    }

        //    // Check if there are items in lstNewConstant
        //    if (lstNewConstant.Items.Count > 0)
        //    {
        //        try
        //        {
        //            // Open the file for appending

        //            using (StreamWriter writer = new StreamWriter(filePath, append: true))
        //            {
        //                // Iterate through each item in lstNewConstant
        //                StringBuilder sbConstants = new StringBuilder();
        //                foreach (System.Windows.Forms.ListViewItem item in lstNewConstant.Items)
        //                {
        //                    string selectedconstant = item.SubItems[1].Text;
        //                    string selectedconstantValue= item.SubItems[2].Text;
        //                    sbConstants.Append( " public const string " + selectedconstant + " = \"" + selectedconstantValue + "\";"+Environment.NewLine);
                           
        //                }
        //                writer.WriteLine(sbConstants.ToString());
        //            }

        //            // Clear lstNewConstant after writing the dictionary
        //            //lstNewConstant.Items.Clear();
        //            MessageBox.Show("Dictionary written successfully.");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error writing to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("There are no items in the list to write to the dictionary.");
        //    }
        //}

        public void WriteDictionary(string filePath, System.Windows.Forms.ListView lstNewConstant, bool append)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please specify the output file path.");
                return;
            }

            // Check if there are items in lstNewConstant
            if (lstNewConstant.Items.Count > 0)
            {
                try
                {
                    // Open the file for appending or writing based on the 'append' flag
                    using (StreamWriter writer = new StreamWriter(filePath, append))
                    {
                        // Iterate through each item in lstNewConstant
                        StringBuilder sbConstants = new StringBuilder();
                        foreach (System.Windows.Forms.ListViewItem item in lstNewConstant.Items)
                        {
                            string selectedconstant = item.SubItems[1].Text;
                            string selectedconstantValue = item.SubItems[2].Text;
                            sbConstants.Append(" public const string " + selectedconstant + " = \"" + selectedconstantValue + "\";" + Environment.NewLine);
                        }
                        writer.WriteLine(sbConstants.ToString());
                    }

                    MessageBox.Show("Dictionary written successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There are no items in the list to write to the dictionary.");
            }
        }


    }


    //Commented Sourcecode

    //public bool IsKeyword(in string word, out bool IsKeyword)
    //{
    //    //----/* Declaration - Private Object variables */----
    //    //----/* Declaration - Private variables */----
    //    bool ExecutionComplete;
    //    bool ReturnValue;
    //    string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

    //    string strWord;
    //    string[] keywords;


    //    //----/* Initialize - Variables */----
    //    //--Local Variables
    //    ExecutionComplete = false;
    //    ReturnValue = false;

    //    strWord = word;
    //    keywords = new[] { "int", "public", "class", "void", "string", "if", "else", "for", "while" };

    //    //--Parameters
    //    IsKeyword = false;

    //    try
    //    {
    //        //----/* Functionality  - Start */----

    //        IsKeyword = Array.Exists(keywords, k => k == strWord);

    //    ExecutionComplete:
    //        ExecutionComplete = true;
    //    //----/* Functionality  - End */----

    //    ExitFunction:;
    //    }

    //    catch (Exception objException)
    //    {
    //        clsGlobalErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
    //    }
    //    finally
    //    {
    //        //----/* Close - Variables */----
    //        if (ExecutionComplete == true) ReturnValue = true;
    //    }

    //    //----/* Return Execution Status */----
    //    return ReturnValue;
    //}


    //private bool ClassificationOfExpression_New(string line, string word)
    //{
    //    //----/* Declaration - Private Object variables */----
    //    //----/* Declaration - Private variables */----
    //    bool ExecutionComplete;
    //    bool ReturnValue;
    //    string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

    //    string classType ;
    //    string identity ;
    //    bool KeywordFound ;

    //    //----/* Initialize - Variables */----
    //    //--Local Variables
    //    ExecutionComplete = false;
    //    ReturnValue = false;

    //    classType = string.Empty;
    //    identity = string.Empty;
    //    KeywordFound = false;

    //    //--Parameters

    //    try
    //    {
    //        //----/* Functionality  - Start */----
    //        if (!IsKeyword(word,out KeywordFound)) throw new Exception("Function execution not completed");
    //        if (KeywordFound)
    //        {
    //            classType = "Keyword";
    //            identity = "Syntax";
    //            goto ExecutionComplete;
    //        }
    //        else if(!IsConstant(word, out ConstantFound)) throw new Exception("Function execution not completed");
    //        if(ConstantFound)
    //        {
    //            classType = "Constant";
    //            identity = "Value";
    //        }

    //    ExecutionComplete:
    //        ExecutionComplete = true;
    //    //----/* Functionality  - End */----

    //    ExitFunction:;
    //    }

    //    catch (Exception objException)
    //    {
    //        clsGlobalErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
    //    }
    //    finally
    //    {
    //        //----/* Close - Variables */----
    //        if (ExecutionComplete == true) ReturnValue = true;

    //    }

    //    //----/* Return Execution Status */----
    //    return ReturnValue;
    //}


}
