using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenejadorTransacciones
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm form1 = new LoginForm();
            
            Application.Run(form1);

            try
            {
                FormTransacciones form2 = new FormTransacciones(form1.IDUser, form1.AccountConnected.Username);
                Application.Run(form2);
            }
            catch (NullReferenceException)
            {
            }
            finally
            {
                form1.Dispose();
                form1 = null;
            }
        }
    }
}
