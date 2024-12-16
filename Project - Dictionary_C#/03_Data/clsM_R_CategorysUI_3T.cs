using nsBusinessObject;
using nsDbObject;
using nsGlobalObject;
using System;
using System.Windows.Forms;

namespace nsPresentation
{
    public class clsM_R_CategorysUI_3T : aclsBusinessObject
    {
        #region Important_Comments
        //'* CodeFactory             Version  : Manual
        //'* Class Template          Version  : 11
        //'* Solution Architecture   Version  : 11
        //'* Created on                       : [18 July 2020 at 11:41 AM]
        // Note : Items Marked with "//Default Design" should appear first in the Region.

        //'************** Code Grouping Convention***********
        //'*   Inherits                                     *
        //'*   Implements                                   *
        //'*   Important Comments                           *
        //'*   Declares                                     *
        //'*   Delegate                                     *
        //'*   Constants                                    *
        //'*   Enumerics                                    *
        //'*   Variables                                    *
        //'*   Class Constructor                            *
        //'*   Class Destructor                             *
        //'*   Properties                                   *
        //'*   Functions                                    *
        //'*   Procedures                                   *
        //'*   Class Destructor                             *
        //'*   Events                                       *
        //'*   Events_Functions                             *
        //'*   BR_Functions                                 *
        //'*   SourceCode_ToRemove                          *
        //'*   SourceCode_ToTest                            *
        //'**************************************************


        //'************** Declaration Priority **************
        //' Acsess Modifier Priority
        //'      Public  
        //'      Internal  
        //'      Protected  
        //'      Private  

        //' Declaration Priority
        //'      Object Constants / Variables  
        //'      Other  Constants / Variables  

        //' AccessRights Priority
        //'      Readonly  
        //'      Writeonly  
        //'      ReadAndWrite  
        //'************** Declaration Priority **************
        #endregion

        #region COMGUIDs
        //' These  GUIDs provide the COM identity for this class 
        //' and its COM interfaces. If you change them, existing 
        //' clients will no longer be able to access the class.
        #endregion

        #region Declares
        //Declares - Public
        //Declares - Internal
        //Declares - Protected
        //Declares - Private
        #endregion

        #region Delegate
        //Delegate - Subs
        //Delegate - Functions
        //delegate*<bool> mobjFunction_RecordsetReposition_GUI;
        public delegate bool RecordsetReposition_GUI();
        public delegate bool EnableUserInterface_GUI(in clsGlobalEnum.enumFormEvents InEvent);
        public delegate bool CaptureData_Post_GUI(ref clsM_R_Category inObjM_R_Category);
        #endregion

        #region Constants
        //Constants - Public - (There should not be any public constants, create properties instead)
        //Constants - Internal
        //Constants - Protected
        //Constants - Private
        private const string CgstrSaveMessage = "Do you really want To save this record ?";
        private const string CgstrMsgboxCaption = " Confirmation ";
        private const string CgstrDeleteMessage = " Are you sure you want To delete this record ?";
        private const String CmstrTableName = "M_R_Category";

        #endregion

        #region Enumerics
        //Enumeric - Public 
        //Enumeric - Internal
        //Enumeric - Protected
        //Enumeric - Private
        #endregion

        #region Variables

        #region Variables - Property
        //Variables - Property - Public - Object   
        //Variables - Property - Internal - Object
        //Variables - Property - Protected - Object
        //Variables - Property - Private - Object
        private clsClassAttribute mobjClassAttribute;  //Default Design for NameSpace nsPresentation only
                                                       //private clsApplication mobjApp; //Default Design for NameSpace nsPresentation only
        private clsApplication mobjApp; //Default Design for NameSpace nsPresentation only
        private frmM_R_Category_3T mobjGUI;
       // private clsM_R_Categorys mobjM_R_Categorys;

        private clsFormAttribute mobjFormAttribute;
        private TextBox mobjtxtCategoryId;
        private TextBox mobjtxtCategoryName;
        private TextBox mobjtxtDescription;

        private Button mobjcmdAddNew;
        private Button mobjcmdEdit;
        private Button mobjcmdSave;
        private Button mobjcmdDelete;
        private Button mobjcmdCancel;

        private Label mobjlblRecordStatus;
        private CheckBox mobjchkGrid;
        private TextBox mobjtxtGoToId;
        private Button mobjcmdGoToId;

        private RecordsetReposition_GUI mobjFunction_RecordsetReposition_GUI;
        private EnableUserInterface_GUI mobjFunction_EnableUserInterface_GUI;
        private CaptureData_Post_GUI mobjFunction_CaptureData_Post_GUI;

        //Variables - Property - Public - (There should not be any public variable, create properties instead)
        //Variables - Property - Internal
        //Variables - Property - Protected
        //Variables - Property - Private
        private bool mbolAutoValidate;

        #endregion

        #region Variables - General
        //Variables - General - Public - Object 
        //Variables - General - Internal - Object
        //Variables - General - Protected - Object 
        //Variables - General - Private - Object
        private clsSolutionBO mobjSolutionBO; //Default Design for NameSpace nsBusinessObject / nsDatabaseObject 
                                              // private frmM_R_Category mobjGUI;

        private aclsRecordset mobjRS_GridView;
        private clsM_R_Category mobjM_R_Category;
        // private clsM_R_CategorysBO mobjM_R_CategorysBO;
        private clsCollection_MultiUser mobjCollection_MU;

        //private frmTraverseGrid mobjfrmGrid;

        //Variables - General - Public - (There should not be any public variable, create properties instead)
        //Variables - General - Internal
        //Variables - General - Protected
        //Variables - General - Private
        #endregion

        #endregion

        #region Class_Constructor
        //    ' A creatable COM class must have a Public Sub New() 
        //    ' with no parameters, otherwise, the class will not be 
        //    ' registered in the COM registry and cannot be created 
        //    ' via CreateObject.
        public clsM_R_CategorysUI_3T(in clsApplication InobjApp) //Default Design
        {
            Initialize(InobjApp);
        }
        #endregion

        #region Class Destructor
        ~clsM_R_CategorysUI_3T() //Default Design
        {
            Terminate();
        }
        #endregion

        #region Properties
        //property - Public - Readonly
        public clsClassAttribute ClassAttribute //Default Design
        {
            get { return mobjClassAttribute; }
        }
        //public clsM_R_CategorysBO M_R_CategorysBO
        //{
        //    get { return mobjM_R_CategorysBO; }

        //}
        //public clsM_R_Categorys M_R_Categorys
        //{
        //    get { return mobjM_R_Categorys; }

        //}
        public override aclsBusinessElement Element
        {
            get { return mobjM_R_Category; }
        }
        public override string UpdateSQL
        {
            get
            {
                string strReturnValue;
                Get_UpdateSQL(out strReturnValue);

                return strReturnValue;
            }
        }
        public override string InsertSQL
        {
            get
            {
                string strReturnValue;
                if (Get_InsertSQL(out strReturnValue) == false) { }

                return strReturnValue;
            }
        }
        public override String ErrMessage
        {
            get { return mobjCollection_MU.Collection_ErrMessage; }
        }
        public override aclsRecordset RS
        {
            get { return mobjCollection_MU; }
        }
        public override string TableName
        {
            get { return CmstrTableName; }
        }
        public override bool AutoValidate
        {
            get { return mbolAutoValidate; }
            set { mbolAutoValidate = value; }
        }
        //property - Public - Writeonly
        public override long ClientHandle
        {
            set { mobjCollection_MU.Collection_ClientHandle = value; }
        }
        public override string ClientIPAddress
        {
            set { mobjCollection_MU.Collection_ClientIpAddress = value.Trim(); }
        }
        public override Object LockServer
        {
            set { mobjCollection_MU.Collection_LockServer = value; }
        }
        //property - Public - Read & Write
        public clsFormAttribute FormAttribute
        {
            get { return mobjFormAttribute; }

            set { mobjFormAttribute = value; }

        }
       
        //property - Internal - Readonly
        //property - Internal - Writeonly
        //property - Internal - Read & Write
        internal EnableUserInterface_GUI Function_EnableUserInterface_GUI
        {
            get { return mobjFunction_EnableUserInterface_GUI; }
            set { mobjFunction_EnableUserInterface_GUI = value; }
        }
        internal RecordsetReposition_GUI Function_RecordsetReposition_GUI
        {
            get { return mobjFunction_RecordsetReposition_GUI; }
            set { mobjFunction_RecordsetReposition_GUI = value; }
        }
        internal CaptureData_Post_GUI Function_CaptureData_Post_GUI
        {
            get { return mobjFunction_CaptureData_Post_GUI; }
            set { mobjFunction_CaptureData_Post_GUI = value; }
        }
        internal TextBox TextBox_CategoryId
        {
            get { return mobjtxtCategoryId; }
            set { mobjtxtCategoryId = value; }
        }
        internal TextBox TextBox_CategoryName
        {
            get { return mobjtxtCategoryName; }
            set { mobjtxtCategoryName = value; }
        }
        internal TextBox TextBox_Description
        {
            get { return mobjtxtDescription; }
            set { mobjtxtDescription = value; }
        }
        internal Button Button_AddNew
        {
            get { return mobjcmdAddNew; }
            set { mobjcmdAddNew = value; }
        }
        internal Button Button_Edit
        {
            get { return mobjcmdEdit; }
            set { mobjcmdEdit = value; }
        }
        internal Button Button_Save
        {
            get { return mobjcmdSave; }
            set { mobjcmdSave = value; }
        }
        internal Button Button_Delete
        {
            get { return mobjcmdDelete; }
            set { mobjcmdDelete = value; }
        }
        internal Button Button_Cancel
        {
            get { return mobjcmdCancel; }
            set { mobjcmdCancel = value; }
        }
        internal Label Label_RecordStatus
        {
            get { return mobjlblRecordStatus; }
            set { mobjlblRecordStatus = value; }
        }
        internal CheckBox CheckBox_Grid
        {
            get { return mobjchkGrid; }
            set { mobjchkGrid = value; }
        }
        internal TextBox TextBox_GoToId
        {
            get { return mobjtxtGoToId; }
            set { mobjtxtGoToId = value; }
        }
        internal Button Button_GoToId
        {
            get { return mobjcmdGoToId; }
            set { mobjcmdGoToId = value; }
        }
        //property - Protected - Readonly
        //property - Protected - Writeonly
        //property - Protected - Read & Write

        //property - Private - Readonly
        private static string ThisClassName //Default Design
        {
            //Note : This property should by private if delcared in a bas module
            get { return System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name; }
            //set { strName = value; }
        }
        private string DeleteSQL
        {
            get
            {
                string strReturnValue;
                if (Get_DeleteSQL(out strReturnValue) == false) { }
                return strReturnValue;
            }
        }
      
        private string SelectSQL
        {
            get
            {
                string strReturnValue;
                if (Get_SelectSQL(out strReturnValue) == false) { }
                return strReturnValue;
            }
        }
        private string DeleteRecordsetSQL
        {
            get { return "Delete From " + CmstrTableName; }
        }

        //property - Private - Writeonly
        //property - Private - Read & Write
        #endregion

        #region Functions
        //Function - Public
        public bool Initialize_UI(ref clsClassAttribute InobjClassAttribute, in frmM_R_Category_3T InoutobjGUI)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            string strFormCaption;
            string strFieldName;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            strFormCaption = clsGlobalEnum.CgstrBlank;
            strFieldName = clsGlobalEnum.CgstrBlank;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                //mobjClassAttribute = InobjClassAttribute;
               
                if (InobjClassAttribute != null) { mobjClassAttribute = InobjClassAttribute; }
                //if (mobjM_R_Categorys.Initialize_CO(mobjClassAttribute) == false) { goto ExitFunction; }
                //if (mobjM_R_Categorys.RS.RS_Refresh() == false) { goto ExitFunction; }


                // mobjM_R_Category = mobjM_R_CategorysBO.M_R_Categorys.M_R_Category;
                //mobjM_R_Category = mobjM_R_Category;

                mobjGUI = InoutobjGUI;
                mobjFormAttribute = mobjGUI.FormAttribute;

                // if (mobjSolutionBO.AppBO.GetFormCaption(mobjGUI.Name, strFormCaption) == false) { goto ExitFunction; }
                mobjFormAttribute.Caption = strFormCaption;

                //mobjM_R_CategorysBO.M_R_Categorys.RS.RS_SelectWhere = mobjFormAttribute.WhereClause_A;
                //if (mobjM_R_CategorysBO.Initialize_BO(mobjClassAttribute) == false) { goto ExitFunction; }

                this.RS.RS_SelectWhere = mobjFormAttribute.WhereClause_A;

                if (mobjCollection_MU.Initialize_Object() == false) { goto ExitFunction; }
                if (mobjCollection_MU.RS_Initialize() == false) { goto ExitFunction; }
                mobjCollection_MU.RS_Connection = mobjSolutionBO.AppBO.StorageBO.DBRDBMS_DBName.ADOConnection;

                mobjCollection_MU.RS_BusinessObject = this;
                mobjCollection_MU.Rs_BusinessObject_MultiUser = this;
                mobjCollection_MU.RS_SelectPhrase = SelectSQL;

                if (mobjM_R_Category.FieldName(out strFieldName, (int)clsM_R_Category.enumFieldsM_R_Category.eCategoryId) == false) { goto ExitFunction; }
                mobjCollection_MU.RS_BookmarkField = strFieldName;

                if (this.RS.RS_Refresh() == false) { goto ExitFunction; }

                if ((mobjFunction_RecordsetReposition_GUI()) == false)
                {
                    if (mobjFunction_RecordsetReposition_GUI() == false) { goto ExitFunction; }
                }


            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        public bool Rs_GridDataFill(ref System.Windows.Forms.DataGridView InobjGrid)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
            // mobjCollection_MU.Rs_GridDataFill(InobjGrid, CmstrTableName);

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        //Function - Internal
        internal bool CaptureData()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                mobjM_R_Category.CategoryId = mobjtxtCategoryId.Text;
                mobjM_R_Category.CategoryName = mobjtxtCategoryName.Text;
                mobjM_R_Category.Description = mobjtxtDescription.Text;

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool DisplayData()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                mobjtxtCategoryId.Text = mobjM_R_Category.CategoryId;
                mobjtxtCategoryName.Text = mobjM_R_Category.CategoryName;
                mobjtxtDescription.Text = mobjM_R_Category.Description;

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool EnableButtons(in clsGlobalEnum.enumFormEvents InEvent)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                mobjcmdAddNew.Enabled = false;
                mobjcmdEdit.Enabled = false;
                mobjcmdSave.Enabled = false;
                mobjcmdDelete.Enabled = false;
                mobjcmdCancel.Enabled = false;
                mobjchkGrid.Enabled = false;

                switch (InEvent)
                {
                    case clsGlobalEnum.enumFormEvents.eFormCancel:
                    case clsGlobalEnum.enumFormEvents.eFormSave:
                    case clsGlobalEnum.enumFormEvents.eFormDefault:

                        //if (mobjFormAttribute.UserPermission.Append == true)
                        //{
                        mobjcmdAddNew.Enabled = true;
                        //}

                        //if (mobjFormAttribute.UserPermission.Delete == true)
                        //{
                        mobjcmdDelete.Enabled = true;
                        //}

                        //if (mobjFormAttribute.UserPermission.Edit == true)
                        //{
                        mobjcmdEdit.Enabled = true;
                        //}

                        break;
                    case clsGlobalEnum.enumFormEvents.eFormNoRecords:
                        //if (mobjFormAttribute.UserPermission.Append == true)
                        //{
                        mobjcmdAddNew.Enabled = true;
                        //}
                        break;
                    case clsGlobalEnum.enumFormEvents.eFormAdd:
                    case clsGlobalEnum.enumFormEvents.eFormEdit:
                        mobjcmdSave.Enabled = true;
                        mobjcmdCancel.Enabled = true;
                        break;
                }

                //mobjApp.AppUI.AppUI_Functions.AFUI_Color_FormButton(mobjGUI); // Write the Function and Uncomment it

                if (mobjFunction_EnableUserInterface_GUI != null)
                {
                    if (mobjFunction_EnableUserInterface_GUI(InEvent) == false) { goto ExitFunction; }
                }

            // VB code commented to review - Assigned to Miki
            // If IsNothing(mobjFunction_EnableUserInterface_GUI) = False Then If mobjFunction_EnableUserInterface_GUI(InEvent) = False Then GoTo ExitFunction


            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool EnableUserInterface(in clsGlobalEnum.enumFormEvents InEvent)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                //'/* Disable user interface controls
                mobjtxtCategoryId.Enabled = false;
                mobjtxtCategoryName.Enabled = false;
                mobjtxtDescription.Enabled = false;
                //'/* Disable user interface controls


                // '/* Enable user interface controls
                switch (InEvent)
                {
                    case clsGlobalEnum.enumFormEvents.eFormSave:
                    case clsGlobalEnum.enumFormEvents.eFormCancel:
                    case clsGlobalEnum.enumFormEvents.eFormDefault:
                    case clsGlobalEnum.enumFormEvents.eFormRecordFound:
                        mobjtxtGoToId.Enabled = true;
                        break;

                    case clsGlobalEnum.enumFormEvents.eFormAdd:
                    case clsGlobalEnum.enumFormEvents.eFormEdit:
                        mobjtxtGoToId.Enabled = false;
                        mobjtxtCategoryName.Enabled = true;
                        mobjtxtDescription.Enabled = true;
                        break;
                }

            //'/* Enable user interface controls

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool GoToRecord(out bool OutbolRecordFound, out string OutstrReturnMessage, in string InstrSearchValue)
        {
            //----/* Declaration - Private Object variables */----
            clsGlobalFunctions objGlobalFunctions;

            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            string strFieldName;
            bool bolIsNumeric;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            objGlobalFunctions = new clsGlobalFunctions();
            bolIsNumeric = false;

            //--Parameters
            OutbolRecordFound = false;
            OutstrReturnMessage = clsGlobalEnum.CgstrBlank;

            //----/* Functionality  - Start */----
            try
            {
                if ((InstrSearchValue).Trim() == clsGlobalEnum.CgstrBlank)
                {
                    OutstrReturnMessage = "GoTo Id cannot be Blank";
                }
                else if (objGlobalFunctions.IsNumeric(out bolIsNumeric, InstrSearchValue.Trim()) == false) { goto ExitFunction; }
                else if (bolIsNumeric == false) { OutstrReturnMessage = "GoTo Id cannot be Non-numeric"; }
                else
                {
                    if (mobjM_R_Category.FieldName(out strFieldName, (int)clsM_R_Category.enumFieldsM_R_Category.eCategoryId) == false) { goto ExitFunction; }
                    // strFieldName = mobjM_R_Category.FieldName(clsM_R_Category.enumFieldsM_R_Category.eCategoryId);

                    if (this.RS.RS_Find(strFieldName, InstrSearchValue.Trim()))
                    // if (mobjM_R_CategorysBO.M_R_Categorys.RS.RS_Find(strFieldName, InstrSearchValue.Trim()))

                    {
                        if ((mobjFunction_RecordsetReposition_GUI()) == false)

                        {
                            if (mobjFunction_RecordsetReposition_GUI() == false) { goto ExitFunction; }
                        }
                        OutbolRecordFound = true;
                    }

                    OutstrReturnMessage = "No Record Found";
                }


            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }
            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool RecordsetFind(ref string InstrFieldName, ref string InstrSearchValue)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (this.RS.RS_Find(InstrFieldName, InstrSearchValue) == false) { goto ExitFunction; }
            // if (mobjM_R_CategorysBO.M_R_Categorys.RS.RS_Find(InstrFieldName, InstrSearchValue) == false) { goto ExitFunction; }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool RecordsetRefresh()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (this.RS.RS_Refresh() == false) { goto ExitFunction; }
                // if (mobjM_R_CategorysBO.M_R_Categorys.RS.RS_Refresh() == false) { goto ExitFunction; }

                if (mobjFunction_RecordsetReposition_GUI() == false)
                {
                    if (mobjFunction_RecordsetReposition_GUI() == false) { goto ExitFunction; }

                }
            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool RecordsetReposition()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            string strRecordPosition;
            string strRecordCount;
            string strRecordStatus;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            strRecordStatus = clsGlobalEnum.CgstrBlank;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                //if (mobjSolutionBO.AppBO.GF_Desktop.DisplayRecordPosition(0, 0, mobjlblRecordStatus.Text) == false) { goto ExitFunction; }
                if ((this.RS.RS_Bof && this.RS.RS_Eof) == true)
                //if ((mobjM_R_CategorysBO.M_R_Categorys.RS.RS_Bof && mobjM_R_CategorysBO.M_R_Categorys.RS.RS_Eof) == true)

                {
                    if (EnableButtons(clsGlobalEnum.enumFormEvents.eFormNoRecords) == false) { goto ExitFunction; }
                    mobjchkGrid.Enabled = false;
                }
                else
                {
                    if (EnableButtons(clsGlobalEnum.enumFormEvents.eFormDefault) == false) { goto ExitFunction; }
                    mobjchkGrid.Enabled = true;
                }

                strRecordPosition = this.RS.RS_AbsolutePosition.ToString();
                strRecordCount = this.RS.RS_RecordCount.ToString();

                //strRecordPosition = mobjM_R_CategorysBO.M_R_Categorys.RS.RS_AbsolutePosition.ToString();
                //strRecordCount = mobjM_R_CategorysBO.M_R_Categorys.RS.RS_RecordCount.ToString();

                if (mobjSolutionBO.AppBO.GF_Desktop.DisplayRecordPosition(out strRecordStatus, strRecordPosition, strRecordCount) == false) { goto ExitFunction; }
                //if (mobjSolutionBO.AppBO.GF_Desktop.DisplayRecordPosition(mobjM_R_CategorysBO.M_R_Categorys.RS.RS_AbsolutePosition, mobjM_R_CategorysBO.M_R_Categorys.RS.RS_RecordCount, out mobjlblRecordStatus.Text) == false) { goto ExitFunction; }

                mobjlblRecordStatus.Text = strRecordStatus;

                if (DisplayData() == false) { goto ExitFunction; }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }

        //Function - Protected
        //Function - Private
        private bool Initialize(in clsApplication InobjApp) //Default Design
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                mobjApp = InobjApp;
                mobjSolutionBO = mobjApp.SolutionBO;
                mobjClassAttribute = new clsClassAttribute();
                mobjCollection_MU = new clsCollection_MultiUser(in mobjSolutionBO);
                mobjM_R_Category = new clsM_R_Category(in mobjSolutionBO);

                mobjFormAttribute = new clsFormAttribute();
                // mobjM_R_CategorysBO = new clsM_R_CategorysBO(mobjSolutionBO);
                //mobjM_R_Categorys = new clsM_R_Categorys(in mobjSolutionBO);

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        private bool Terminate() //Default Design
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                mobjCollection_MU = null;
                mobjM_R_Category = null;

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        public override bool RefreshElement(in clsGlobalEnum.enumRefreshElement InlngVal)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            int intCntr;
            //string strFieldValue;
            string strFieldName;
            object objFieldValue;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //strFieldValue = clsGlobalEnum.CgstrBlank;
            //strFieldName = clsGlobalEnum.CgstrBlank;
            objFieldValue = null;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                switch (InlngVal)
                {
                    case clsGlobalEnum.enumRefreshElement.eBlank:

                        for (intCntr = 0; intCntr <= mobjM_R_Category.FieldCount - 1; intCntr++)
                        {
                            mobjM_R_Category.FieldValue_Set(intCntr, clsGlobalEnum.CgstrBlank);
                        }
                        break;
                    case clsGlobalEnum.enumRefreshElement.eRecordValue:

                        if (mobjCollection_MU.RS_Bof | mobjCollection_MU.RS_Eof == true)
                        {

                            mobjCollection_MU.RS_Bookmark = clsGlobalEnum.CgintNotDefined;

                            RefreshElement(clsGlobalEnum.enumRefreshElement.eBlank);
                        }
                        else
                        {
                            mobjCollection_MU.RS_FieldValue(out objFieldValue, mobjM_R_Category.PrimaryKeyName);
                            mobjCollection_MU.RS_Bookmark = objFieldValue;

                            for (intCntr = 0; intCntr <= mobjM_R_Category.FieldCount - 1; intCntr++)
                            {
                                if (mobjM_R_Category.FieldName(out strFieldName, intCntr) == false) { goto ExitFunction; }
                                if (mobjCollection_MU.RS_FieldValue(out objFieldValue, strFieldName) == false) { goto ExitFunction; }

                                mobjM_R_Category.FieldValue_Set(intCntr, objFieldValue);

                                //mobjCollection_MU.RS_FieldValue(mobjM_R_Category.PrimaryKeyName, out objFieldValue);


                                //strFieldValue = objFieldValue.ToString();

                            }
                        }
                        break;
                }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;

        }
        private bool ValidateInputData(in clsGlobalEnum.enumValidationScope InlngValidationScope, ref string inoutErrMsg, int Inintfield = clsGlobalEnum.CgintNoValue, object InvarCurrentVal = null, object InoutIntKeyAscii = null)
        {
            //----/* Declaration - Private Object variables */----
            clsGlobalFunctions objGlobalFunctions;

            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            clsM_R_Category.enumFieldsM_R_Category intErrField;
            bool bolIsNumeric;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            objGlobalFunctions = new clsGlobalFunctions();
            bolIsNumeric = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (InlngValidationScope == clsGlobalEnum.enumValidationScope.eSingleField)
                {
                    if (Inintfield == clsGlobalEnum.CgintNoValue)
                    {
                        inoutErrMsg = "Error: Field missing";
                        goto ExitFunction;
                    }

                    else if ((int)Inintfield == clsGlobalEnum.CgintNotDefined)
                    {
                        inoutErrMsg = "Error: Wrong field index";
                        goto ExitFunction;

                    }

                    else if (InlngValidationScope == clsGlobalEnum.enumValidationScope.eSingleFieldKeyPress)
                    {
                        if (Inintfield == clsGlobalEnum.CgintNoValue)
                        {
                            inoutErrMsg = "Error: Field missing";
                            goto ExitFunction;
                        }
                    }
                    else if (InvarCurrentVal == null)
                    {
                        inoutErrMsg = "Error: current value missing";
                        goto ExitFunction;
                    }

                    intErrField = clsGlobalEnum.CgintNotDeclared;
                }

                if ((InlngValidationScope == clsGlobalEnum.enumValidationScope.eAllFields) | (Inintfield == (int)clsM_R_Category.enumFieldsM_R_Category.eCategoryId))
                {
                    if (mobjM_R_Category.CategoryId == clsGlobalEnum.CgstrBlank)
                    {
                        inoutErrMsg = "Error :  CategoryId cannot be blank";
                        intErrField = clsM_R_Category.enumFieldsM_R_Category.eCategoryId;
                        goto ExitFunction;
                    }

                    if (mobjM_R_Category.CategoryId.Trim() == clsGlobalEnum.CgstrBlank)
                    {
                        inoutErrMsg = "Error :  CategoryId Cannot be left blank, Please input 0 (Zero) as default input";
                        intErrField = clsM_R_Category.enumFieldsM_R_Category.eCategoryId;
                        goto ExitFunction;
                    }

                    else if (mobjM_R_Category.CategoryId.Trim() != clsGlobalEnum.CgstrBlank)
                    {
                        if (objGlobalFunctions.IsNumeric(out bolIsNumeric, mobjM_R_Category.CategoryId) == false) { goto ExitFunction; }

                        //if (IsNumeric(mobjM_R_Category.CategoryId) == false)
                        if (bolIsNumeric == false)
                        {
                            inoutErrMsg = "Error :  CategoryId should be numeric only";
                            intErrField = clsM_R_Category.enumFieldsM_R_Category.eCategoryId;
                            goto ExitFunction;
                        }
                    }
                }


                if ((InlngValidationScope == clsGlobalEnum.enumValidationScope.eAllFields) | (Inintfield == (int)clsM_R_Category.enumFieldsM_R_Category.eCategoryName))
                {
                    if (mobjM_R_Category.CategoryName == clsGlobalEnum.CgstrBlank)
                    {
                        inoutErrMsg = "Error :  CategoryName cannot be blank";
                        intErrField = clsM_R_Category.enumFieldsM_R_Category.eCategoryName;
                        goto ExitFunction;

                    }

                }

                if ((InlngValidationScope == clsGlobalEnum.enumValidationScope.eAllFields) | (Inintfield == (int)clsM_R_Category.enumFieldsM_R_Category.eDescription))
                {
                    if (mobjM_R_Category.Description == clsGlobalEnum.CgstrBlank)
                    {
                        inoutErrMsg = "Error :  Description cannot be blank";
                        intErrField = clsM_R_Category.enumFieldsM_R_Category.eDescription;
                        goto ExitFunction;
                    }
                }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        private bool Get_DeleteSQL(out string OutstrDeleteSQLStmt)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            string strReturnValue;
            object objFieldValue;
            int intCntr;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            objFieldValue = clsGlobalEnum.CgstrBlank;
            strReturnValue = clsGlobalEnum.CgstrBlank;
            intCntr = clsGlobalEnum.CgintNotDefined;

            //--Parameters
            OutstrDeleteSQLStmt = clsGlobalEnum.CgstrBlank;

            //----/* Functionality  - Start */----
            try
            {
                if (mobjM_R_Category.FieldValue_Get(out objFieldValue, intCntr) == false) { goto ExitFunction; }

                strReturnValue = "Delete From " + CmstrTableName + " Where " + mobjM_R_Category.PrimaryKeyName + " = " + objFieldValue;

                OutstrDeleteSQLStmt = strReturnValue;

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----

            return ReturnValue;
        }
        private bool Get_InsertSQL(out string OutstrInsertSQLStmt)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            string strReturnValue;
            string strReturnValue_Formatted;
            string strFieldName;
            clsGlobalEnum.enumDataTypes strFieldType;
            int intCntr;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            strReturnValue = clsGlobalEnum.CgstrBlank;
            strReturnValue_Formatted = clsGlobalEnum.CgstrBlank;
            strFieldName = clsGlobalEnum.CgstrBlank;
            strReturnValue = "Insert Into " + TableName + " (";
            strFieldType = clsGlobalEnum.CgintNotDefined;

            //--Parameters
            OutstrInsertSQLStmt = clsGlobalEnum.CgstrBlank;

            //----/* Functionality  - Start */----
            try
            {
                for (intCntr = 0; intCntr <= mobjM_R_Category.FieldCount - 1; intCntr++)
                {
                    if (mobjM_R_Category.FieldName(out strFieldName, intCntr) == false) { goto ExitFunction; }

                    strReturnValue = strReturnValue + strFieldName;

                    if (intCntr <= mobjM_R_Category.FieldCount - 2)
                    {
                        strReturnValue = strReturnValue + ",";
                    }
                    else if (intCntr <= mobjM_R_Category.FieldCount - 1)
                    {
                        strReturnValue = strReturnValue + ")";
                    }

                }

                strReturnValue = strReturnValue + " Values (";

                for (intCntr = 0; intCntr <= mobjM_R_Category.FieldCount - 1; intCntr++)
                {
                    mobjM_R_Category.FieldType(out strFieldType, intCntr);

                    if (mobjSolutionBO.AppBO_Friend.AppBO_Functions.AF_SQLStmt_FormatData(out strReturnValue_Formatted,
                                                                                            mobjCollection_MU.RS_Connection.ConnectionString.DatabaseType,
                                                                                            strFieldType,
                                                                                            intCntr,
                                                                                            mobjM_R_Category
                                                                                            ) == false)
                    { goto ExitFunction; }

                    strReturnValue = strReturnValue + strReturnValue_Formatted;

                    if (intCntr <= mobjM_R_Category.FieldCount - 2)
                    {
                        strReturnValue = strReturnValue + ",";
                    }

                    else if (intCntr <= mobjM_R_Category.FieldCount - 1)
                    {
                        strReturnValue = strReturnValue + ")";
                    }

                }

                OutstrInsertSQLStmt = strReturnValue;

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----

            return ReturnValue;
        }
        private bool Get_SelectSQL(out string OutstrSelectSQLStmt)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            string strReturnValue;
            string strFieldName;
            int intCntr;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            strFieldName = clsGlobalEnum.CgstrBlank;
            strReturnValue = clsGlobalEnum.CgstrBlank;
            intCntr = clsGlobalEnum.CgintNotDefined;

            //--Parameters
            OutstrSelectSQLStmt = clsGlobalEnum.CgstrBlank;

            //----/* Functionality  - Start */----
            try
            {
                strReturnValue = "Select ";

                for (intCntr = 0; intCntr < mobjM_R_Category.FieldCount; intCntr++)
                {
                    if (mobjM_R_Category.FieldName(out strFieldName, intCntr) == false) { goto ExitFunction; }

                    strReturnValue = strReturnValue + strFieldName;

                    if (intCntr < mobjM_R_Category.FieldCount - 1)
                    {
                        strReturnValue = strReturnValue + ",";
                    }
                }

                strReturnValue = strReturnValue + " From " + CmstrTableName;
                OutstrSelectSQLStmt = strReturnValue;

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----

            return ReturnValue;
        }
        public override bool SetNewPrimaryKey()
        {

            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (GetNewPrimaryKeyVal() == true)
                {
                    mobjM_R_Category.CategoryId = mobjCollection_MU.RS_NewPrimaryKey.ToString();
                }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        private bool GetNewPrimaryKeyVal()
        {
            //----/* Declaration - Private Object variables */----
            clsRecordset objRs;

            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            string strSqlstmt;
            string strMaxFieldName;
            object objFieldValue;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            objRs = new clsRecordset();
            strSqlstmt = clsGlobalEnum.CgstrBlank;
            strMaxFieldName = "Max" + mobjM_R_Category.PrimaryKeyName;
            objFieldValue = null;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                objRs.RS_Initialize();
                objRs.RS_Connection = mobjCollection_MU.RS_Connection;


                strSqlstmt = "Select Max(" + mobjM_R_Category.PrimaryKeyName + ") As " + strMaxFieldName + " From " + CmstrTableName;

                objRs.RS_RecordSource = strSqlstmt;

                if (objRs.RS_Refresh() == false) { goto ExitFunction; }

                if ((objRs.RS_Bof && objRs.RS_Eof) == false)
                {
                    objRs.RS_FieldValue(out objFieldValue, strMaxFieldName);

                    if (objFieldValue == null)
                    {
                        mobjCollection_MU.RS_NewPrimaryKey = 1;
                    }

                    else
                    {
                        objRs.RS_FieldValue(out objFieldValue, strMaxFieldName);
                        mobjCollection_MU.RS_NewPrimaryKey = (int)objFieldValue + 1;
                    }
                }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                objRs = null;

                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;

        }
        public override bool DeleteRecordset()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (mobjCollection_MU.CDeleteRecordset(DeleteRecordsetSQL) == false) { goto ExitFunction; }
                if (RefreshElement(clsGlobalEnum.enumRefreshElement.eRecordValue) == false) { goto ExitFunction; }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        private bool Get_UpdateSQL(out string OutstrUpdateSQLStmt)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            string strReturnValue;
            string strFieldName;
            clsGlobalEnum.enumDataTypes strFieldType;
            object objFieldValue;
            int intCntr;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            strFieldName = clsGlobalEnum.CgstrBlank;
            strReturnValue = "Insert Into " + CmstrTableName + " (";
            intCntr = clsGlobalEnum.CgintNotDefined;

            //--Parameters
            OutstrUpdateSQLStmt = clsGlobalEnum.CgstrBlank;

            //----/* Functionality  - Start */----
            try
            {
                strReturnValue = clsGlobalEnum.CgstrBlank;
                OutstrUpdateSQLStmt = clsGlobalEnum.CgstrBlank;
                strReturnValue = "Update " + CmstrTableName + " Set ";

                for (intCntr = 1; intCntr <= mobjM_R_Category.FieldCount - 1; intCntr++)
                {
                    mobjM_R_Category.FieldType(out strFieldType, intCntr);
                    if (mobjSolutionBO.AppBO_Friend.AppBO_Functions.AF_SQLStmt_FormatData(out OutstrUpdateSQLStmt,
                                                                                          mobjCollection_MU.RS_Connection.ConnectionString.DatabaseType,
                                                                                          strFieldType,
                                                                                          intCntr,
                                                                                          mobjM_R_Category) == false)
                    { goto ExitFunction; }

                    if (mobjM_R_Category.FieldName(out strFieldName, intCntr) == false) { goto ExitFunction; }

                    strReturnValue = strReturnValue + " " + strFieldName + " = " + OutstrUpdateSQLStmt;
                    //strReturnValue = strReturnValue + " " + mobjM_R_Category.FieldName(intCntr) + " = " + OutstrReturnValue;

                    if (intCntr <= mobjM_R_Category.FieldCount - 2)
                    {
                        strReturnValue = strReturnValue + ",";
                    }
                    else if (intCntr <= mobjM_R_Category.FieldCount - 1)
                    {
                        mobjM_R_Category.FieldValue_Get(out objFieldValue, mobjM_R_Category.PrimaryKeyIndex);
                        strReturnValue = strReturnValue + " Where " + " " + mobjM_R_Category.PrimaryKeyName + " = " + objFieldValue;

                    }
                }

                OutstrUpdateSQLStmt = strReturnValue;

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----

            return ReturnValue;
        }
        public override bool Add()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (mobjCollection_MU.CAdd() == false) { goto ExitFunction; }
                RefreshElement(clsGlobalEnum.enumRefreshElement.eBlank);
                mobjM_R_Category.CategoryId = clsGlobalEnum.CgintNotDefined.ToString();
                mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eAdd;

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        public override bool Cancel()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (mobjCollection_MU.CCancel(this) == false) { goto ExitFunction; }
                mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eNavigation;

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        public override bool Delete()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (mobjCollection_MU.CDelete(DeleteSQL) == false) { goto ExitFunction; }
                if (RefreshElement(clsGlobalEnum.enumRefreshElement.eRecordValue) == false) { goto ExitFunction; }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        public override bool Edit()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (mobjCollection_MU.CEdit() == false) { goto ExitFunction; }
                mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eEdit;

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        public override bool Save()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            string strErrMessage;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            strErrMessage = clsGlobalEnum.CgstrBlank;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (AutoValidate == true)
                {
                    if (ValidateInputData(clsGlobalEnum.enumValidationScope.eAllFields, ref strErrMessage) == false)
                    {
                        MessageBox.Show(strErrMessage);
                        goto ExitFunction;
                    }
                }

                if (mobjCollection_MU.RS_EditMode == clsGlobalEnum.enumEditModes.eAdd)
                {
                    if (mobjCollection_MU.CSave(CmstrTableName) == false) { goto ExitFunction; }
                    RefreshElement(clsGlobalEnum.enumRefreshElement.eRecordValue);
                    mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eNavigation;

                }
                else if (mobjCollection_MU.RS_EditMode == clsGlobalEnum.enumEditModes.eEdit)
                {
                    if (mobjCollection_MU.CSave(CmstrTableName) == false) { goto ExitFunction; }
                    mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eNavigation;
                }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        #endregion

        #region Procedures
        //Procedure - Public */
        //Procedure - Internal */
        //Procedure - Protected */
        //Procedure - Private */
        #endregion

        #region Events
        //Events

        #endregion

        #region Events_Functions
        //Function - Public
        //Function - Internal
        //Function - Protected
        //Function - Private
        internal bool cmdAddNew_Click()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (EnableButtons(clsGlobalEnum.enumFormEvents.eFormAdd) == false) { goto ExitFunction; }
                //if (mobjCollection_MU.CAdd() == false) { goto ExitFunction; }
                //RefreshElement(clsGlobalEnum.enumRefreshElement.eBlank);
                //mobjM_R_Category.CategoryId = clsGlobalEnum.CgintNotDefined.ToString();
                //mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eAdd;

                //if (mobjM_R_Categorys.Add() == false) { goto ExitFunction; }
                if (Add() == false) { goto ExitFunction; }

                if (DisplayData() == false) { goto ExitFunction; }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool cmdCancel_Click()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                //if (mobjCollection_MU.CCancel(this) == false) { goto ExitFunction; }
                //mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eNavigation;

                if (Cancel() == false) { goto ExitFunction; }
                if ((mobjFunction_RecordsetReposition_GUI()) == false)  // VB code commented to review - Assigned to Miki
                                                                        // if (IsNothing(mobjFunction_RecordsetReposition_GUI) == false)
                {
                    if (mobjFunction_RecordsetReposition_GUI() == false) { goto ExitFunction; }

                }
            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool cmdDelete_Click(in bool InbolAskConfirmation = true)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            DialogResult intMsgResult;
            // Microsoft.VisualBasic.MsgBoxResult intMsgResult;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (InbolAskConfirmation == true)
                {
                    intMsgResult = MessageBox.Show(CgstrDeleteMessage, CgstrMsgboxCaption, MessageBoxButtons.YesNo);
                    // intMsgResult = MessageBox.Show(CgstrDeleteMessage, vbYesNo, CgstrMsgboxCaption);

                }

                else { intMsgResult = DialogResult.Yes; }

                if (intMsgResult == DialogResult.Yes)
                {
                    //if (mobjCollection_MU.CDelete(DeleteSQL) == false) { goto ExitFunction; }
                    //if (RefreshElement(clsGlobalEnum.enumRefreshElement.eRecordValue) == false) { goto ExitFunction; }


                    if (Delete() == false) { goto ExitFunction; }
                    if (mobjFunction_RecordsetReposition_GUI != null)
                    {

                        if (mobjFunction_RecordsetReposition_GUI() == false) { goto ExitFunction; }
                    }
                }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool cmdEdit_Click()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                //if (mobjCollection_MU.CEdit() == false) { goto ExitFunction; }
                //mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eEdit;

                if (Edit() == false) { goto ExitFunction; }
                if (EnableButtons(clsGlobalEnum.enumFormEvents.eFormEdit) == false) { goto ExitFunction; }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool cmdSave_Click(in bool InbolAskConfirmation = true)
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;
            string strErrMessage;

            DialogResult intMsgResult;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;
            strErrMessage = clsGlobalEnum.CgstrBlank;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (InbolAskConfirmation == true)
                {
                    intMsgResult = MessageBox.Show(CgstrSaveMessage, CgstrMsgboxCaption, MessageBoxButtons.YesNo);
                }
                else { intMsgResult = DialogResult.Yes; }

                if (intMsgResult == DialogResult.Yes)
                {
                    if (CaptureData() == false) { goto ExitFunction; }
                    if (mobjFunction_CaptureData_Post_GUI != null)
                    {
                        if (Function_CaptureData_Post_GUI(ref mobjM_R_Category) == false) { goto ExitFunction; }
                    }

                    //if (AutoValidate == true)
                    //{
                    //    if (ValidateInputData(clsGlobalEnum.enumValidationScope.eAllFields, ref strErrMessage) == false)
                    //    {
                    //        MessageBox.Show(strErrMessage);
                    //        goto ExitFunction;
                    //    }
                    //}

                    //if (mobjCollection_MU.RS_EditMode == clsGlobalEnum.enumEditModes.eAdd)
                    //{
                    //    if (mobjCollection_MU.CSave(CmstrTableName) == false) { goto ExitFunction; }
                    //    RefreshElement(clsGlobalEnum.enumRefreshElement.eRecordValue);
                    //    mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eNavigation;

                    //}
                    //else if (mobjCollection_MU.RS_EditMode == clsGlobalEnum.enumEditModes.eEdit)
                    //{
                    //    if (mobjCollection_MU.CSave(CmstrTableName) == false) { goto ExitFunction; }
                    //    mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eNavigation;
                    //}

                    if (Save() == false) { goto ExitFunction; }
                    if (mobjFunction_RecordsetReposition_GUI != null)
                    {
                        if (mobjFunction_RecordsetReposition_GUI() == false) { goto ExitFunction; }
                    }
                }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        //internal bool cmdGoToId_Click()
        //{
        //    //----/* Declaration - Private Object variables */----
        //    //----/* Declaration - Private variables */----
        //    bool ExecutionComplete;
        //    bool ReturnValue;
        //    string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

        //    //----/* Initialize - Variables */----
        //    //--Local Variables
        //    ExecutionComplete = false;
        //    ReturnValue = false;

        //    //--Parameters

        //    //----/* Functionality  - Start */----
        //    try
        //    {
        //        mobjtxtGoToId.Text = clsGlobalEnum.CgstrBlank;
        //        if (mobjApp.AppUI.AppUI_Functions.AFUI_cmdGoToId_Click(mobjM_R_CategorysBO.M_R_Categorys.RS.RS_RecordSource, clsM_R_Category.enumFieldsM_R_Category.eCategoryId, mobjGUI, mobjtxtGoToId) == false) { goto ExitFunction; }
        //        if ((mobjtxtGoToId.Text).Trim() != clsGlobalEnum.CgstrBlank)
        //        {
        //            if (txtGoToId_KeyPress(mobjtxtGoToId, ref new KeyPressEventArgs(Convert.ToChar(Keys.Enter))) == false) { goto ExitFunction; }
        //        }


        //    ExecutionComplete:
        //        ExecutionComplete = true;

        //    ExitFunction:;
        //    }
        //    catch (Exception objException)
        //    {
        //        clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
        //    }
        //    //----/* Functionality  - End */----

        //    //----/* Close - Variables */----
        //    finally
        //    {
        //        //ExitFunction:
        //        if (ExecutionComplete == true) ReturnValue = true;

        //    }

        //    //----/* Return Execution Status */----
        //    return ReturnValue;
        //}
        internal bool cmdRefresh_Click()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                if (RecordsetRefresh() == false) { goto ExitFunction; }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool cmdMoveFirst_Click()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                this.RS.RS_MoveFirst();
                // mobjM_R_CategorysBO.M_R_Categorys.RS.RS_MoveFirst();

                if (mobjFunction_RecordsetReposition_GUI != null)
                {
                    if (mobjFunction_RecordsetReposition_GUI() == false) { goto ExitFunction; }
                }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool cmdMoveLast_Click()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                this.RS.RS_MoveLast();
                if (mobjFunction_RecordsetReposition_GUI != null)
                {
                    if (mobjFunction_RecordsetReposition_GUI() == false) { goto ExitFunction; }
                }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool cmdMoveNext_Click()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                this.RS.RS_MoveNext();
                if (mobjFunction_RecordsetReposition_GUI != null)
                {
                    if (mobjFunction_RecordsetReposition_GUI() == false) { goto ExitFunction; }
                }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        internal bool cmdMovePrevious_Click()
        {
            //----/* Declaration - Private Object variables */----
            //----/* Declaration - Private variables */----
            bool ExecutionComplete;
            bool ReturnValue;
            string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

            //----/* Initialize - Variables */----
            //--Local Variables
            ExecutionComplete = false;
            ReturnValue = false;

            //--Parameters

            //----/* Functionality  - Start */----
            try
            {
                this.RS.RS_MovePrevious();
                if (mobjFunction_RecordsetReposition_GUI != null)
                {
                    if (mobjFunction_RecordsetReposition_GUI() == false) { goto ExitFunction; }
                }

            ExecutionComplete:
                ExecutionComplete = true;

            ExitFunction:;
            }

            catch (Exception objException)
            {
                clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
            }
            //----/* Functionality  - End */----

            //----/* Close - Variables */----
            finally
            {
                //ExitFunction:
                if (ExecutionComplete == true) ReturnValue = true;

            }

            //----/* Return Execution Status */----
            return ReturnValue;
        }
        //internal bool chkGrid_CheckedChanged()
        //{
        //    //----/* Declaration - Private Object variables */----
        //    //----/* Declaration - Private variables */----
        //    bool ExecutionComplete;
        //    bool ReturnValue;
        //    string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

        //    //----/* Initialize - Variables */----
        //    //--Local Variables
        //    ExecutionComplete = false;
        //    ReturnValue = false;

        //    //--Parameters

        //    //----/* Functionality  - Start */----
        //    try
        //    {
        //        if (mobjApp.AppUI.AppUI_Functions.AFUI_chkGrid_CheckStateChanged(mobjM_R_CategorysBO.M_R_Categorys.RS.RS_RecordSource, clsM_R_Category.enumFieldsM_R_Category.eCategoryId, mobjGUI, mobjchkGrid, mobjM_R_CategorysBO.M_R_Categorys) == false)
        //        { goto ExitFunction; }


        //    ExecutionComplete:
        //        ExecutionComplete = true;

        //    ExitFunction:;
        //    }

        //    catch (Exception objException)
        //    {
        //        clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
        //    }
        //    //----/* Functionality  - End */----

        //    //----/* Close - Variables */----
        //    finally
        //    {
        //        //ExitFunction:
        //        if (ExecutionComplete == true) ReturnValue = true;

        //    }

        //    //----/* Return Execution Status */----
        //    return ReturnValue;
        //}
        //internal bool txtGoToId_KeyPress(in TextBox InouttxtTextBox, ref System.Windows.Forms.KeyPressEventArgs e)
        //{
        //    //----/* Declaration - Private Object variables */----
        //    //----/* Declaration - Private variables */----
        //    bool ExecutionComplete;
        //    bool ReturnValue;
        //    string ThisFunctionName = System.Reflection.MethodInfo.GetCurrentMethod().Name;

        //    bool bolRecordFound;
        //    string strReturnMessage;
        //    int intKeyAscii;

        //    //----/* Initialize - Variables */----
        //    //--Local Variables
        //    ExecutionComplete = false;
        //    ReturnValue = false;

        //    bolRecordFound = false;
        //    strReturnMessage = clsGlobalEnum.CgstrBlank;
        //    intKeyAscii = Asc(e.KeyChar);

        //    //--Parameters

        //    //----/* Functionality  - Start */----
        //    try
        //    {
        //        if (intKeyAscii == 13)
        //        {
        //            if (mobjtxtGoToId.Text.Trim() == clsGlobalEnum.CgstrBlank)
        //            {
        //                MessageBox.Show("GoToId Cannot be blank ","GoTo Id", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                if (cmdMoveFirst_Click() == false) { goto ExitFunction; }
        //                goto ExitFunction;
        //            }

        //            if (GoToRecord(mobjtxtGoToId.Text, ref bolRecordFound, ref strReturnMessage) == false) { goto ExitFunction; }
        //            if (bolRecordFound == false) { MessageBox.Show(strReturnMessage, "GoTo Id", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        //        }
        //        else
        //        {
        //            if (mobjtxtGoToId.Text.Length > 0)
        //            {
        //                if (mobjSolutionBO.AppBO.GF_Desktop.GetNumeric(intKeyAscii, mobjtxtGoToId.Text, clsGlobalEnum.enumFieldLength.eLength8, clsGlobalEnum.CgintNotDefined, false) == false) { goto ExitFunction; }
        //            }
        //        }

        //        e.KeyChar = Convert.ToChar(intKeyAscii);
        //        if (intKeyAscii == 0)
        //        {
        //            e.Handled = true;
        //        }


        //    ExecutionComplete:
        //        ExecutionComplete = true;

        //    ExitFunction:;
        //    }

        //    catch (Exception objException)
        //    {
        //        clsLibErrorHandler.GenericErrorHandler(objException, ThisClassName, ThisFunctionName);
        //    }
        //    //----/* Functionality  - End */----

        //    //----/* Close - Variables */----
        //    finally
        //    {
        //        //ExitFunction:
        //        if (ExecutionComplete == true) ReturnValue = true;

        //    }

        //    //----/* Return Execution Status */----
        //    return ReturnValue;
        //}

        #endregion

        #region BR_Functions
        //Function - Public
        //Function - Internal
        //Function - Protected
        //Function - Private
        #endregion

        #region SourceCode - ToRemove
        #endregion

        #region SourceCode - ToTest

        #endregion

    }
}
