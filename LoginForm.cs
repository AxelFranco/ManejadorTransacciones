using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace MenejadorTransacciones
{
    public partial class LoginForm : Form
    {
        private static Random randomNumbers = new Random();
        private MessageBoxIcon IconType { get; set; }
        private MessageBoxButtons ButtonType { get; set; }

        private AccountApp accountConnected;

        public AccountApp AccountConnected
        {
            get
            {
                return accountConnected;
            }
            private set
            {
                accountConnected = value;
            }
        }

        public int IDUser { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void HandleVisibleLogIn(bool visibleF)
        {
            buttonLogIn.Visible = visibleF;
        }
        private async void buttonLogIn_Click(object sender, EventArgs e)
        {
            int cantSeconds = 30;
            try
            {
                AccountApp myAccount = new AccountApp(textBoxUser.Text, textBoxPass.Text, false);
                this.AccountConnected = myAccount;
                this.IDUser = this.AccountConnected.GetID();

            }
            catch (ArgumentException ex)
            {
                ButtonType = MessageBoxButtons.OK;
                IconType = MessageBoxIcon.Error;
                MessageBox.Show(ex.Message, ex.ParamName, this.ButtonType, this.IconType);
                textBoxUser.Text = string.Empty;
                textBoxPass.Text = string.Empty;
                return;
            }
            finally
            {
                HandleVisibleLogIn(false);
                Task<int> sleepTask = Task.Run(() => Suspend(cantSeconds));
                Task<int> progressTask = Task.Run(() => UpdateBar(cantSeconds));
                await Task.WhenAll(sleepTask, progressTask);

                if (sleepTask.Result == 1 & progressTask.Result == 1)
                {
                    HandleVisibleLogIn(true);
                }
                ActualizarProgressBar(0);
            }

            this.Close();
        }

        private int Suspend(int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 1000);
            return 1;
        }

        private int UpdateBar(double seconds)
        {
            double secondsActual;
            double porcentaje;
            DateTime dateCalc = DateTime.Now;
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            DateTime datePost = dateCalc + timeSpan;
            double secondsTotal = timeSpan.TotalSeconds;

            while (DateTime.Now <= datePost)
            {
                if (datePost > DateTime.Now)
                {
                    secondsActual = (datePost - DateTime.Now).TotalSeconds;
                    porcentaje = (secondsActual / secondsTotal) * 100;
                    porcentaje = 100 - porcentaje;
                    ActualizarProgressBar((int)porcentaje);
                }
                else
                {
                    ActualizarProgressBar(0);
                }
            }
            return 1;
        }

        private void ActualizarProgressBar(int porcentaje)  // Function necesaria porque se esta trabajando con subprocesos
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => ActualizarProgressBar(porcentaje)));
            }
            else
            {
                progressBarLogin.Value = porcentaje;
            }
        }

        private void linkLabelNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                AccountApp myAccount = new AccountApp(textBoxUser.Text, textBoxPass.Text, true);
                this.AccountConnected = myAccount;
                this.IDUser = myAccount.GetID();

            }
            catch (ArgumentException ex)
            {
                if (ex.Message.Contains("existe"))
                {
                    ButtonType = MessageBoxButtons.OK;
                    IconType = MessageBoxIcon.Error;
                    MessageBox.Show(ex.Message, ex.ParamName, this.ButtonType, this.IconType);
                    textBoxUser.Text = string.Empty;
                    textBoxPass.Text = string.Empty;
                    return;
                }
            }

            textBoxUser.Text = string.Empty;
            textBoxPass.Text = string.Empty;

            ButtonType = MessageBoxButtons.OK;
            IconType = MessageBoxIcon.Information;
            MessageBox.Show($"El usuario {this.AccountConnected.Username} fue creado exitosamente", "New Account", this.ButtonType, this.IconType);
        }
    }
}
