using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CF_CHash_Dictionary._01_Library
{
    public class clsGlobalErrorHandler
    {
        public static void GenericErrorHandler(Exception objException, string strSourceClassName, string strFunctionName)
        {
            string strErrorMessage;
            strErrorMessage = string.Empty;

            strErrorMessage = "Description : " + objException.Message +
                                "\r\n" + "Class Name : " + strSourceClassName +
                                "\r\n" + "Function Name : " + strFunctionName;

            //OutstrErrorMessage = strErrorMessage;
            //OutstrErrorMessage = strErrorMessage;

            MessageBox.Show(strErrorMessage);
        }

    }
}
