using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CF_CHash_Dictionary._01_Library;
using System.Security.Cryptography;



namespace CF_CHash_Dictionary
{
    public partial class Form1 : Form
    {
        private string selectedFolderPath;
        private string outputFilePath;
        private string outputFileName;
        private string inputFilePath;
        private string inputFilName;
        private DataTable dtConstants;
        private DataTable dtSourceCode;
        //private Dictionary<int, string> DictionaryConst;


        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        private clsDictionary objDictionary;
        //private Dictionary<int,string> objExistingDictionary;

        #endregion

        #region Properties
        //public Dictionary<int,string> ExistingDictionary
        //{
        //    get { return objExistingDictionary; }
        //    set 
        //        {
        //        if (value == null) throw new ArgumentNullException("Dictionary connot be null");
        //        objExistingDictionary = value;
        //        }
        //}

        #endregion

        #region Function
        public void Form_Initialize()
        {
            objDictionary = new clsDictionary();
            objDictionary.Initialize();
            objDictionary.ListView_ExistingDictionary = lstDictionaryConst;
            objDictionary.ListView_DictionaryConst_InSourceCode = lstDictionaryConst_inSourceCode;
            objDictionary.ListView_NewWord_InSourceCode = lstnewwords_inSourceCode;
            objDictionary.ListView_DictionaryNewWords = lstDicsNewWords;
            Display_ini();
            //ExistingDictionary = new Dictionary<int, string>();
        }

        private void Display_ini()
        {
            // Set the form size to 1920x1080
            this.Width = 1920;
            this.Height = 1080;
            panel1.Left = 30;
            tableLayoutPanel1.Left = 30;
            panel1.Top = 30;
            tableLayoutPanel1.Top = panel1.Top + panel1.Height + 15;
            cmdWriteDictionary.Top = tableLayoutPanel1.Top + tableLayoutPanel1.Height + 15;
            cmdWriteDictionary.Left = tableLayoutPanel1.Width - 130;
            // Keep the window borders and title bar (so the close button appears)
            this.FormBorderStyle = FormBorderStyle.FixedDialog;  // Or Sizable

            // Set the form to full screen (maximize it)
            //this.WindowState = FormWindowState.Maximized;

            // Optionally, make it stay on top
            this.TopMost = true;
            
            lstDicsNewWords.View = View.Details;
            lstDicsNewWords.Columns.Add("Id", (int)(lstDicsNewWords.Width * 0.2));
            lstDicsNewWords.Columns.Add("Constant", (int)(lstDicsNewWords.Width * .4));
            lstDicsNewWords.Columns.Add("Value", (int)(lstDicsNewWords.Width * .4));
        }

        private void LoadLabels()
        {
            // Define the static labels
            var labels = new List<string>
                {
                    "Key words",
                    "Constants",
                    "Variables",
                    "Expression"
                };
            // Clear existing items in the ListBox (optional)
            lstlabel.Items.Clear();
            lstlabel.View = View.Details;
            lstlabel.Columns.Add("Id", (int)(lstlabel.Width * .2));
            lstlabel.Columns.Add("Constant", (int)(lstlabel.Width * .4));
            lstlabel.Columns.Add("Value", (int)(lstlabel.Width * .4));



            // Bind the list of labels to the ListBox
            int id = 1;
            foreach (var label in labels)
            {
                string shortLabel = label.Length >= 3 ? label.Substring(0, 3) : label;
                
                var lstviewitem = new ListViewItem(id.ToString());
               
                lstviewitem.SubItems.Add(label);
                lstviewitem.SubItems.Add(shortLabel);
                lstlabel.Items.Add(lstviewitem);
                id++;
            }

        }
        //private void LoadNewWords()
        //{
        //    // Define the static labels
        //    var labels = new List<string>
        //        {
        //            "for",
        //            "while",
        //            "equel to",
        //            "do while"
        //        };
        //    // Clear existing items in the ListBox (optional)
        //    lstnewwords_inSourceCode.Items.Clear();
        //    lstnewwords_inSourceCode.View = View.List;
        //    lstnewwords_inSourceCode.Columns.Add("Item", lstlabel.Width - 5);
        //    // Bind the list of labels to the ListBox
        //    foreach (var label in labels)
        //    {

        //        lstnewwords_inSourceCode.Items.Add(label);
        //    }

        //}
        #endregion

        #region Events
        private void cmdOpenOutputFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {

                    string fullpath;
                    fullpath = fileDialog.FileName;
                    outputFilePath = Path.GetDirectoryName(fullpath);
                    outputFileName = Path.GetFileName(fullpath);

                    txtoutputfile.Text = fullpath;
                    dtConstants = objDictionary.Read_Dictionary(fullpath);
                    lstDictionaryConst.Columns.Clear();
                    lstDictionaryConst.Items.Clear();
                    lstDictionaryConst.View = View.Details;
                    lstDictionaryConst.Columns.Add("Id", (int)(lstDictionaryConst.Width * .2));
                    lstDictionaryConst.Columns.Add("Constant", (int)(lstDictionaryConst.Width * .4));
                    lstDictionaryConst.Columns.Add("Value", (int)(lstDictionaryConst.Width * .4));

                    foreach (DataRow row in dtConstants.Rows)
                    {
                        string constantname = row["ConstantName"].ToString();
                        string constantvalue = row["ConstantValue"].ToString();
                        string formattedString = row["FormattedValue"].ToString();

                        formattedString = formattedString.Replace("\r", "").Replace("\n", "").Trim();
                        //MessageBox.Show(formattedString);

                        var lstviewitem = new ListViewItem(dtConstants.Rows.IndexOf(row).ToString());
                        lstviewitem.SubItems.Add(constantname);
                        lstviewitem.SubItems.Add(constantvalue);

                        lstDictionaryConst.Items.Add(lstviewitem);
                        //lstDictionaryConst.Items.Add(formattedString);

                        objDictionary.ExistingDictionary.Add(objDictionary.ExistingDictionary.Count + 1, row["ConstantValue"].ToString());
                        //objDictionary.ExistingDictionary.Add(dtConstants.Rows.IndexOf(row), row["ConstantValue"].ToString());

                    }
                }
            }
        }

        private void cmdOpenSourceCode_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {

                    // Clear lstDicsNewWords after restoring all items
                    lstDicsNewWords.Items.Clear();
                    objDictionary.ListView_DictionaryNewWords_Clear();

                    string fullpath;
                    fullpath = fileDialog.FileName;
                    inputFilePath = Path.GetDirectoryName(fullpath);
                    inputFilName = Path.GetFileName(fullpath);

                    txtSourceCodefile.Text = fullpath;
                    dtSourceCode = objDictionary.Read_SourceCode(fullpath);

                    //lstDictionaryConst_inSourceCode.Items.Clear();
                    //lstDictionaryConst_inSourceCode.View = View.List;
                    //lstDictionaryConst_inSourceCode.Columns.Add("Item", lstDictionaryConst_inSourceCode.Width - 5);
                    //foreach (DataRow row in dtSourceCode.Rows)
                    //{
                    //    string formattedString = row["FormattedValue"].ToString();
                    //    formattedString = formattedString.Replace("\r", "").Replace("\n", "").Trim();
                    //    lstDictionaryConst_inSourceCode.Items.Add(formattedString);
                    //}
                }
            }
        }

        private void cmdWriteDictionary_Click(object sender, EventArgs e)
        {
            // Use OpenFileDialog to allow the user to select an existing file or create a new one
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                // Set the default file name and filter for the dialog
                fileDialog.FileName = outputFileName; // You can set default file name here
                fileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                // Show the dialog and check if the user selected a file
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = fileDialog.FileName;

                    // Check if the file exists (it will always exist in OpenFileDialog)
                    // In OpenFileDialog, we do not prompt for overwriting, we simply append.
                    objDictionary.WriteDictionary(selectedFile, lstDicsNewWords, append: true);
                    lstDicsNewWords.Items.Clear();
                }
                else
                {
                    MessageBox.Show("No file selected. Operation canceled.");
                }
            }
        }


        private void cmdlabel_Click(object sender, EventArgs e)
        {
            if (lstnewwords_inSourceCode.SelectedItems.Count > 0 && lstlabel.SelectedItems.Count > 0)
            {
                // Get the selected items
                var selectedItem = (System.Windows.Forms.ListViewItem)lstlabel.SelectedItems[0];
                var selectedItemSource = (System.Windows.Forms.ListViewItem)lstnewwords_inSourceCode.SelectedItems[0];

                // Access the individual column values
                string id = selectedItemSource.SubItems[0].Text;
                string key = selectedItem.SubItems[2].Text;
                string column2 = selectedItem.SubItems[1].Text;

                // Create Key and value
                string Key = "Ccode" + key + selectedItemSource.SubItems[1].Text;
                string value = selectedItemSource.SubItems[1].Text;

                // Check if the data is empty or invalid before adding
                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(Key) || string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Invalid data found, skipping item.");
                    return;
                }

                // Clear the ListView to prevent residual or blank items
                if(lstDicsNewWords.Items.Count==0)
                    lstDicsNewWords.Items.Clear();

                // Begin updating the ListView control (prevents redundant redraws)
                lstDicsNewWords.BeginUpdate();

                // Create the new ListViewItem
                ListViewItem lstviewitem = new ListViewItem(id);
                lstviewitem.SubItems.Add(Key);
                lstviewitem.SubItems.Add(value);

                // Add the item to the ListView
                lstDicsNewWords.Items.Add(lstviewitem);

                // Explicitly update the layout of the ListView
                lstDicsNewWords.EndUpdate();

                // Optionally, refresh the ListView to ensure proper drawing
                lstDicsNewWords.Refresh();

                // Optionally, ensure that the new item is visible
                lstDicsNewWords.Items[lstDicsNewWords.Items.Count - 1].EnsureVisible();

                // Remove the selected items from the source ListBoxes
                lstnewwords_inSourceCode.Items.Remove(lstnewwords_inSourceCode.SelectedItems[0]);
                // lstlabel.Items.Remove(lstlabel.SelectedItems[0]); // Uncomment if you need this as well
            }
            else
            {
                MessageBox.Show("Please select one item from both lists.");
            }
        }


        private void cmdUnlabel_Click(object sender, EventArgs e)
        {
            if (lstDicsNewWords.SelectedItems.Count > 0)
            {
                // Get the selected item in lstDicsNewWords
                System.Windows.Forms.ListViewItem selectedItemSource = (System.Windows.Forms.ListViewItem)lstDicsNewWords.SelectedItems[0];
                string id = selectedItemSource.SubItems[0].Text;
                string value = selectedItemSource.SubItems[2].Text;

                lstnewwords_inSourceCode.View = View.Details;
                ListViewItem lstviewitem = new ListViewItem(id);
                lstviewitem.SubItems.Add(value);               

                lstnewwords_inSourceCode.Items.Add(lstviewitem);

                    //lstlabel.Items.Add(label);

                    // Remove the item from lstDicsNewWords

                    lstDicsNewWords.Items.Remove(lstDicsNewWords.SelectedItems[0]);
                
            }
            else
            {
                MessageBox.Show("Please select an item to unlabel.");
            }
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {


            if (lstDicsNewWords.Items.Count > 0)
            {
                // Loop through each item in lstDicsNewWords
                foreach (System.Windows.Forms.ListViewItem item in lstDicsNewWords.Items)
                {
                    // Get the string representation of the item
                    string selectedItem = item.Text;

                    // Split the item to extract newWord and label
                    int startIndex = selectedItem.IndexOf(" [");
                    int endIndex = selectedItem.IndexOf("]");

                    if (startIndex != -1 && endIndex != -1)
                    {
                        // Extract newWord and label
                        string newWord = selectedItem.Substring(0, startIndex);
                        string label = selectedItem.Substring(startIndex + 2, endIndex - startIndex - 2); // remove " [" and "]"

                        // Add the items back to the original lists
                        lstnewwords_inSourceCode.Items.Add(newWord);
                        //lstlabel.Items.Add(label);
                    }
                }

                // Clear lstDicsNewWords after restoring all items
                lstDicsNewWords.Items.Clear();
                objDictionary.ListView_DictionaryNewWords_Clear();
            }
            else
            {
                MessageBox.Show("There are no items to clear.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLabels();
            //LoadNewWords();
            //lstDicsNewWords.View = View.List;
            //lstDicsNewWords.Columns.Add("Item", lstDictionaryConst_inSourceCode.Width - 5);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lstDicsNewWords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    #region Code_Commented
    //public class Dictionary
    //{
    //    string _inputfilename;
    //    string _inputfilepath;
    //    // Read existing dictionary file
    //    public void Read_Dictionary(string filePath)
    //    {

    //        MessageBox.Show("Read Dictionnary " + filePath);
    //    }

    //    // Read input source code
    //    public DataTable Read_SourceCode(string filePath)
    //    {

    //        DataTable dtConstants = CreateConstantsDataTable();

    //        try
    //        {
    //            // Open the file for reading line by line
    //            using (StreamReader reader = new StreamReader(filePath))
    //            {
    //                string line;
    //                while ((line = reader.ReadLine()) != null)
    //                {
    //                    // Trim any leading or trailing spaces from the line
    //                    line = line.Trim();

    //                    // Skip comment lines (lines starting with "//")
    //                    if (line.StartsWith("//"))
    //                    {
    //                        continue;
    //                    }
    //                    string pattern = @"public\s+const\s+string\s+(\w+)\s*=\s*""([^""]+)""\s*;";

    //                    // Try matching the line with the regex pattern
    //                    Match match = Regex.Match(line, pattern);



    //                    if (match.Success)
    //                    {
    //                        // Extract the constant name and value
    //                        string constantName = match.Groups[1].Value;
    //                        string constantValue = match.Groups[2].Value;

    //                        // Format the string to show both name and value with brackets
    //                        string formattedString = $"{constantName}  [{constantValue}]";


    //                        // Add the formatted constant to the ListBox
    //                        dtConstants.Rows.Add(constantName, constantValue, formattedString);
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }
    //        return dtConstants;
    //    }

    //    // Write dictionary to file
    //    public void WriteDictionary(string filePath, System.Windows.Forms.ListView lstDicsNewWords)
    //    {
    //        if (string.IsNullOrEmpty(filePath))
    //        {
    //            MessageBox.Show("Please specify the output file path.");
    //            return;
    //        }

    //        // Check if there are items in lstDicsNewWords
    //        if (lstDicsNewWords.Items.Count > 0)
    //        {
    //            try
    //            {
    //                // Open the file for appending

    //                using (StreamWriter writer = new StreamWriter(filePath, append: true))
    //                {
    //                    // Iterate through each item in lstDicsNewWords
    //                    foreach (System.Windows.Forms.ListViewItem item in lstDicsNewWords.Items)
    //                    {
    //                        string selectedItem = item.Text;
    //                        int startIndex = selectedItem.IndexOf(" [");
    //                        int endIndex = selectedItem.IndexOf("]");

    //                        if (startIndex != -1 && endIndex != -1)
    //                        {
    //                            // Extract newWord and label
    //                            string newWord = selectedItem.Substring(0, startIndex);
    //                            string label = selectedItem.Substring(startIndex + 2, endIndex - startIndex - 2); // remove " [" and "]"

    //                            // Format the string as: public const string newWord = "label";
    //                            string formattedLine = $"public const string {newWord} = \"{label}\";";

    //                            // Write the formatted line to the file
    //                            writer.WriteLine(formattedLine);
    //                        }
    //                    }
    //                }

    //                // Clear lstDicsNewWords after writing the dictionary
    //                //lstDicsNewWords.Items.Clear();
    //                MessageBox.Show("Dictionary written successfully.");
    //            }
    //            catch (Exception ex)
    //            {
    //                MessageBox.Show($"Error writing to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            }
    //        }
    //        else
    //        {
    //            MessageBox.Show("There are no items in the list to write to the dictionary.");
    //        }
    //    }

    //    // Private method to read flat file (Dictionary or Source code)
    //    private void Read_File(string filePath)
    //    {
    //        // Implementation of reading file logic
    //    }

    //    // Private method to break function into lines
    //    private void BreakFunctionToLines(StreamReader filePointer)
    //    {
    //        // Implementation to read file line by line and split into words
    //    }

    //    // Private method to break line into words
    //    private void BreakLineIntoWords(string line)
    //    {
    //        // Implementation of splitting line into words
    //    }

    //    // Private method to classify word expressions
    //    private void ClassificationOfExpression(string line, string word)
    //    {
    //        string classType = "";
    //        string identity = "";

    //        // Example of rule-based classification
    //        if (IsKeyword(word))
    //        {
    //            classType = "Keyword";
    //            identity = "Syntax";
    //        }
    //        else if (IsConstant(word))
    //        {
    //            classType = "Constant";
    //            identity = "Value";
    //        }
    //        else if (IsUserDefinedIdentifier(word))
    //        {
    //            classType = "UserDefined";
    //            identity = "Variable";
    //        }
    //        else if (IsClassName(word))
    //        {
    //            classType = "UserDefined";
    //            identity = "Class";
    //        }

    //        // Here we could store this classification information or return it.
    //        Console.WriteLine($"Word: {word}, ClassType: {classType}, Identity: {identity}");
    //    }

    //    private bool IsKeyword(string word)
    //    {
    //        // List of keywords in C#
    //        string[] keywords = { "int", "public", "class", "void", "string", "if", "else", "for", "while" };
    //        return Array.Exists(keywords, k => k == word);
    //    }

    //    private bool IsConstant(string word)
    //    {
    //        // Simple check if word is a number
    //        return int.TryParse(word, out _);
    //    }

    //    private bool IsUserDefinedIdentifier(string word)
    //    {
    //        // Basic check: could check if it is not a keyword and matches typical variable naming rules
    //        return !IsKeyword(word) && !int.TryParse(word, out _);
    //    }

    //    private bool IsClassName(string word)
    //    {
    //        // Example check if word might represent a class (could also check against known class names)
    //        return Char.IsUpper(word[0]);
    //    }
    //    private DataTable CreateConstantsDataTable()
    //    {
    //        // Creating a new DataTable to hold constant names and values
    //        DataTable dt = new DataTable();
    //        dt.Columns.Add("ConstantName", typeof(string));
    //        dt.Columns.Add("ConstantValue", typeof(string));
    //        dt.Columns.Add("FormattedValue", typeof(string));


    //        return dt;
    //    }

    //}
    #endregion

}
