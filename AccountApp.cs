using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MenejadorTransacciones
{
    public class AccountApp : BusinessEntity
    {
        private bool newAccount;
        private string username;
        private Properties.USUARIOS userOfDB;

        private static Random randomNumbers = new Random();
        public string Username
        {
            get
            {
                return username;
            }
            private set
            {
                if (value.Length > 0 && value.Length < 15)
                {
                    MenejadorTransacciones.Properties.MovPorUsuariosEntities dbContext = GetEntity();

                    if (!newAccount)
                    {
                        dbContext.USUARIOS.Load();
                        var userFind2 = dbContext.USUARIOS
                            .Where((MenejadorTransacciones.Properties.USUARIOS userItem) => userItem.Username == value)
                            .Select((MenejadorTransacciones.Properties.USUARIOS userItem) => userItem);


                        if (userFind2.Count() == 1)
                        {
                            this.userOfDB = userFind2.First();
                            username = value;
                        }
                        else
                        {
                            username = null;
                            throw new ArgumentException("No se encontro en la base de datos.", nameof(userFind2));
                        }
                    }
                    else
                    {
                        dbContext.USUARIOS.Load();
                        var userFind = dbContext.USUARIOS
                            .Where((MenejadorTransacciones.Properties.USUARIOS userItem) => userItem.Username == value)
                            .Select((MenejadorTransacciones.Properties.USUARIOS userItem) => userItem);
                        if (userFind.Count() > 0)
                        {
                            username = null;
                            throw new ArgumentException("El username ya existe en la base de datos", nameof(this.Username));
                        }
                        username = value;
                    }
                }
                else
                {
                    username = null;
                    throw new ArgumentException("El nombre de usuario debe tener como maximo 14 caracteres", nameof(Username));
                }
            }
        }
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            private set
            {
                if (value.Length > 0 && value.Length < 15)
                {
                    if (!newAccount)
                    {
                        if (value == userOfDB.Password)
                        {
                            password = value;
                        }
                        else
                        {
                            throw new ArgumentException("Contraseña incorrecta", nameof(Password));

                        }
                    }
                    else
                    {
                        password = value;
                    }
                }
                else
                {
                    throw new ArgumentException("La contraseña debe tener como maximo 14 caracteres", nameof(Password));
                }
            }
        }
        public AccountApp(string usernameP, string passwordP, bool newAccountP)
        {
            newAccount = newAccountP;
            Username = usernameP;
            Password = passwordP;
        }

        public int GetID()
        {
            if (!newAccount)
            {
                return userOfDB.ID;
            }
            else
            {
                MenejadorTransacciones.Properties.MovPorUsuariosEntities dbContext = GetEntity();

                userOfDB = new Properties.USUARIOS();
                userOfDB.ID = randomNumbers.Next(0, int.MaxValue);
                userOfDB.Username = this.Username;
                userOfDB.Password = this.Password;

                dbContext.USUARIOS.Local.Add(userOfDB);

                for (bool retry = true; retry == true; retry = false)
                {
                    try
                    {
                        dbContext.SaveChanges();
                    }

                    catch (Exception ex)
                    {
                        if (ex.InnerException.InnerException.Message.ToLower().Contains("duplicate key") == true)
                        {
                            userOfDB.ID = randomNumbers.Next(0, int.MaxValue);
                        }
                    }
                }

                return userOfDB.ID;
            }
        }
    }
}
