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
using System.Data.Entity.Validation;
using System.Reflection;
using MenejadorTransacciones.Properties;

namespace MenejadorTransacciones
{
    public partial class FormTransacciones : Form
    {
        private int idUser;
        private string username;

        private MessageBoxIcon IconType { get; set; }
        private MessageBoxButtons ButtonType { get; set; }

        private Nullable<Article.MovementType> movementF = null;
        private Nullable<Article.TaxType> taxF = null;
        public string Username
        {
            get
            {
                return username;
            }
            private set
            {
                username = value;
            }
        }
        public int IDUser
        {
            get
            {
                return idUser;
            }
            private set
            {
                idUser = value;
            }
        }
        public FormTransacciones(int idUserParam, string usernameParam)
        {
            this.IDUser = idUserParam;
            this.Username = usernameParam;
            InitializeComponent();
            this.Text = this.Username;
        }

        private void HandleVisibleTable(bool visibleParam)
        {
            this.dataGridView1.Visible = visibleParam;
            this.bindingNavigator1.Visible = visibleParam;
        }


        private DataTable LINQToData<T>(IEnumerable<T> varlist, params Type[] RejectedTypes)
        {
            DataTable dtReturn = new DataTable();
            PropertyInfo[] oProps = null;

            if (varlist == null)
            {
                return dtReturn;
            }
            foreach (T rec in varlist)
            {
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    PropertyInfo[] resultConsult = oProps
                        .Where((PropertyInfo prop) => RejectedTypes
                            .Where((Type typeItem) => typeItem.GUID == prop.PropertyType.GUID)
                            .Select((Type typeItem) => typeItem)
                            .Count() == 0)
                        .Select((PropertyInfo prop) => prop)
                        .ToArray();                                                       // Devuelve los Property cuyo Type, no esten en RejectedTypes
                    oProps = resultConsult;
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;
                        IEnumerable<Type> typesEncountered = RejectedTypes
                            .Where((Type typeP) => typeP.GUID == colType.GUID)                    // Antes era un distinto (!=)
                            .Select((Type typeP) => typeP);                                    // Devuelve los RejectedTypes que coincidan con el tipo en proceso

                        if (typesEncountered.Count() == 0)                                       // Antes era un > 0
                        {
                            if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                            {
                                colType = colType.GetGenericArguments()[0];
                            }
                            dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                        }
                    }
                }
                DataRow dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                            (rec, null);
                }
                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dtReturned;
            MovPorUsuariosEntities dbTest = new MovPorUsuariosEntities();

            dbTest.MOVIMIENTOS.Load();
            dbTest.ARTICULOS.Load();

            var movFinded = dbTest.MOVIMIENTOS
                .Where((MOVIMIENTOS item) => item.ID_Usuario == this.IDUser)
                .Join(dbTest.ARTICULOS.Select((ARTICULOS item) => item),
                    item => item.ID_Articulo,
                    itemArt => itemArt.ID,
                    (itemMov, itemAr) => new { cantidad = itemMov.Cantidad.Value, precioUnit = itemMov.Precio_Unitario.Value, concept = itemAr.Concepto, fech = itemMov.Fecha.Value })
                .OrderByDescending(item => item.fech);


            dtReturned = LINQToData(movFinded);

            this.labelMaestro.Text = "Datos Gastos";
            HandleVisiblePeriodo(true);
            this.buttonOKPeriodo.Visible = true;
            HandleVisibleTable(true);

            HandleVisibleIngresarMov(false);
            HandleVisibleIngresarArticulo(false);
            this.dataGridView1.DataSource = dtReturned;
            this.bindingSource1.DataSource = dtReturned;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }


        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gastosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HandleVisibleIngresarMov(true);
            HandleVisiblePeriodo(false);
            HandleVisibleIngresarArticulo(false);
            HandleVisibleTable(false);
            this.buttonOKPeriodo.Visible = true;
            this.labelMaestro.Text = "Ingresar Gasto";


            Properties.MovPorUsuariosEntities consultaM = BusinessEntity.GetEntity();
            consultaM.ARTICULOS.Load();

            Dictionary<int, string> arrayArticulos = consultaM.ARTICULOS
                .ToDictionary((Properties.ARTICULOS art) => art.ID, (Properties.ARTICULOS art) => art.Concepto);

            this.comboBoxArticle.DataSource = new BindingSource(arrayArticulos, null);
            this.comboBoxArticle.DisplayMember = "Value";
            this.comboBoxArticle.ValueMember = "Key";
        }


        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dtReturned;
            MovPorUsuariosEntities dbTest = new MovPorUsuariosEntities();

            dbTest.ARTICULOS.Load();
            var articuloFind = dbTest.ARTICULOS
                .Select((ARTICULOS userItem) => userItem);

            dtReturned = LINQToData(articuloFind, typeof(System.Collections.Generic.ICollection<MOVIMIENTOS>));

            this.labelMaestro.Text = "Articulos";
            HandleVisiblePeriodo(false);
            this.buttonOKPeriodo.Visible = true;
            HandleVisibleIngresarMov(false);
            HandleVisibleIngresarArticulo(false);
            HandleVisibleTable(true);
            this.dataGridView1.DataSource = dtReturned;
            this.bindingSource1.DataSource = dtReturned;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void HandleVisiblePeriodo(bool show)
        {
            this.labelFechaInf.Visible = show;
            this.labelFechaSup.Visible = show;
            this.inputFechaInf.Visible = show;
            this.inputFechaSup.Visible = show;
        }

        private void HandleVisibleIngresarMov(bool show)
        {
            this.comboBoxArticle.Visible = show;
            this.textBoxPrecioUnitario.Visible = show;
            this.InputCantidad.Visible = show;
            this.labelArticulos.Visible = show;
            this.labelPrecioUnitario.Visible = show;
            this.labelCantidad.Visible = show;
        }

        private void HandleVisibleIngresarArticulo(bool show)
        {
            this.groupBox1.Visible = show;
            this.groupBox2.Visible = show;
            this.labelConcepto.Visible = show;
            this.inputConcepto.Visible = show;
            this.labelDescripcion.Visible = show;
            this.textBoxDescripcion.Visible = show;
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleVisibleIngresarArticulo(true);
            HandleVisibleIngresarMov(false);
            HandleVisiblePeriodo(false);
            HandleVisibleTable(false);
            this.buttonOKPeriodo.Visible = true;
            this.labelMaestro.Text = "Ingresar Articulo";

        }

        private void buttonOKPeriodo_Click(object sender, EventArgs e)
        {
            Article myArticle;
            BusinessItem myBussItem;
            int IDBase;
            decimal precioUnitario;
            int cantidadLeida;
            DataTable dt;
            DateTime fechasup;
            DateTime fechainf;

            Properties.MovPorUsuariosEntities myMov = BusinessEntity.GetEntity();
            Properties.ARTICULOS artip = new Properties.ARTICULOS();
            Properties.MOVIMIENTOS movp = new Properties.MOVIMIENTOS();

            if (this.labelMaestro.Text == "Ingresar Articulo")
            {
                IngresarArticulo(out myArticle);
                IDBase = myArticle.GetID();
                artip.ID = IDBase;
                artip.Concepto = myArticle.Concepto;
                artip.Descripcion = myArticle.Description;
                artip.Tipo_de_Movimiento = myArticle.MovementString;
                myMov.ARTICULOS.Local.Add(artip);
                myMov.SaveChanges();

                this.IconType = MessageBoxIcon.Information;
                this.ButtonType = MessageBoxButtons.OK;

                MessageBox.Show($"El articulo fue registrado exitosamente", "New Article", this.ButtonType, this.IconType);
            }
            else if (this.labelMaestro.Text == "Ingresar Gasto")
            {
                KeyValuePair<int, string> selectedComboBox = (KeyValuePair<int, string>)this.comboBoxArticle.SelectedItem;
                precioUnitario = decimal.Parse(this.textBoxPrecioUnitario.Text);
                cantidadLeida = System.Int32.Parse(this.InputCantidad.Text);
                myBussItem = new BusinessItem(precioUnitario, cantidadLeida, selectedComboBox.Key, DateTime.Today, this.IDUser);

                movp.Precio_Unitario = (double)myBussItem.PricePerUnit;
                movp.N_de_movimiento = myBussItem.GetNumberOfMovement();
                movp.Cantidad = myBussItem.Quantity;
                movp.ID_Articulo = myBussItem.IDArt;
                movp.ID_Usuario = myBussItem.IDUser;
                movp.Fecha = myBussItem.DateOfMovement;

                this.IconType = MessageBoxIcon.Information;
                this.ButtonType = MessageBoxButtons.OK;
                myMov.MOVIMIENTOS.Local.Add(movp);
                myMov.SaveChanges();
                MessageBox.Show($"El movimiento fue registrado exitosamente", "New Movement", this.ButtonType, this.IconType);
            }
            else if (this.labelMaestro.Text == "Datos Gastos")
            {
                fechasup = DateTime.Parse(this.inputFechaSup.Text);
                fechainf = DateTime.Parse(this.inputFechaInf.Text);

                myMov.MOVIMIENTOS.Load();
                myMov.ARTICULOS.Load();
                DateTime.Parse("03/01/2020");
                var queryByDate = myMov.MOVIMIENTOS
                    .Where((Properties.MOVIMIENTOS itemMov) => itemMov.Fecha.Value >= fechainf && itemMov.Fecha.Value <= fechasup && itemMov.ID_Usuario.Value == this.IDUser)
                    .Join(myMov.ARTICULOS.Select((ARTICULOS item) => item),
                     (MOVIMIENTOS itemM) => itemM.ID_Articulo,
                     (ARTICULOS itemA) => itemA.ID,
                     (MOVIMIENTOS itemM, ARTICULOS itemA) => new { cantidad = itemM.Cantidad.Value, precioUnit = itemM.Precio_Unitario.Value, concept = itemA.Concepto, fech = itemM.Fecha.Value })
                    .OrderByDescending(item => item.fech);

                dt = LINQToData(queryByDate);
                this.dataGridView1.DataSource = dt;
                this.bindingSource1.DataSource = dt;
                this.bindingNavigator1.BindingSource = this.bindingSource1;
            }
            else if (this.labelMaestro.Text == "Balance por Periodo")
            {
                fechasup = DateTime.Parse(this.inputFechaSup.Text);
                fechainf = DateTime.Parse(this.inputFechaInf.Text);
                myMov.MOVIMIENTOS.Load();
                myMov.ARTICULOS.Load();
                double gastos = 0;
                try
                {
                    gastos = myMov.MOVIMIENTOS
                        .Where((Properties.MOVIMIENTOS item) => item.ID_Usuario == this.IDUser && item.Fecha.Value >= fechainf && item.Fecha.Value <= fechasup &&
                            myMov.ARTICULOS.Where((Properties.ARTICULOS itemArt) => itemArt.ID == item.ID_Articulo && (itemArt.Tipo_de_Movimiento.Contains("Gas") ||
                                itemArt.Tipo_de_Movimiento.Contains("Inv")))
                                .Any())
                        .Select((Properties.MOVIMIENTOS item) => item.Precio_Unitario.Value * item.Cantidad.Value)
                        .Sum();
                }
                catch (InvalidOperationException)
                {
                    gastos = 0; // El caso en que no hay ningun item para Sum() Falla con este tipo de excepcion
                }
                
                
                double ganancias = 0;

                try
                {
                    ganancias = myMov.MOVIMIENTOS
                        .Where((Properties.MOVIMIENTOS item) => item.ID_Usuario == this.IDUser && item.Fecha.Value >= fechainf && item.Fecha.Value <= fechasup &&
                            myMov.ARTICULOS.Where((Properties.ARTICULOS itemArt) => itemArt.ID == item.ID_Articulo && (itemArt.Tipo_de_Movimiento.Contains("Ven") ||
                                itemArt.Tipo_de_Movimiento.Contains("Sal")))
                                .Any())
                        .Select((Properties.MOVIMIENTOS item) => item.Precio_Unitario.Value * item.Cantidad.Value)
                        .Sum();
                }
                catch (InvalidOperationException)
                {
                    ganancias = 0; // El caso en que no hay ningun item para Sum() falla con este tipo de excepcion
                }

                this.IconType = MessageBoxIcon.Information;
                this.ButtonType = MessageBoxButtons.OK;

                MessageBox.Show($"Los gastos totales son {gastos}\nLas ganancias totales son {ganancias}", "Resumen", this.ButtonType, this.IconType);
            }
        }
       

        private void IngresarArticulo(out Article article)
        {
            decimal taxProportional;
            decimal taxFixed;

            switch (this.taxF)
            {
                case Article.TaxType.Fixed:
                    taxFixed = System.Decimal.Parse(this.textBoxFixed.Text);
                    article = new Article(this.inputConcepto.Text, this.textBoxDescripcion.Text, this.movementF.Value, this.taxF.Value, taxFixed);
                    break;
                case Article.TaxType.Proportional:
                    taxProportional = System.Decimal.Parse(this.textBoxPorcentaje.Text);
                    article = new Article(this.inputConcepto.Text, this.textBoxDescripcion.Text, this.movementF.Value, this.taxF.Value, porcentual: taxProportional);
                    break;
                case Article.TaxType.Both:
                    taxFixed = System.Decimal.Parse(this.textBoxFixed.Text);
                    taxProportional = System.Decimal.Parse(this.textBoxPorcentaje.Text);
                    article = new Article(this.inputConcepto.Text, this.textBoxDescripcion.Text, this.movementF.Value, this.taxF.Value, taxFixed, taxProportional);
                    break;
                case Article.TaxType.Less:
                    article = new Article(this.inputConcepto.Text, this.textBoxDescripcion.Text, this.movementF.Value, this.taxF.Value);
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// El evento se llama radioButtonNinguno pero en realidad es el manejador de eventos de todos los radioButtons
        /// en el GroupBox de Impuestos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonNinguno_CheckedChanged(object senderP, EventArgs e)
        {
            RadioButton sender = (RadioButton)senderP;
            if (sender == this.radioButtonNinguno && sender.Checked)
            {
                this.labelFixed.Visible = false;
                this.textBoxFixed.Visible = false;
                this.labelPorcentaje.Visible = false;
                this.textBoxPorcentaje.Visible = false;
                this.taxF = Article.TaxType.Less;
            }
            else if (sender == this.radioButtonVar && sender.Checked)
            {
                this.labelFixed.Visible = false;
                this.textBoxFixed.Visible = false;
                this.labelPorcentaje.Visible = true;
                this.textBoxPorcentaje.Visible = true;
                this.taxF = Article.TaxType.Proportional;
            }
            else if (sender == this.radioButtonAmbos && sender.Checked)
            {
                this.labelFixed.Visible = true;
                this.textBoxFixed.Visible = true;
                this.textBoxPorcentaje.Visible = true;
                this.labelPorcentaje.Visible = true;
                this.taxF = Article.TaxType.Both;
            }
            else if (sender == this.radioButtonFija && sender.Checked)
            {
                this.labelFixed.Visible = true;
                this.textBoxFixed.Visible = true;
                this.textBoxPorcentaje.Visible = false;
                this.labelPorcentaje.Visible = false;
                this.taxF = Article.TaxType.Fixed;
            }
        }

        private void gastoRadioBut_CheckedChanged(object senderP, EventArgs e)
        {
            RadioButton sender = (RadioButton)senderP;
            if (sender.Checked)
            {
                if (sender == this.gastoRadioBut)
                {
                    this.movementF = Article.MovementType.Gastos;
                }
                else if (sender == this.radioButtonVenta)
                {
                    this.movementF = Article.MovementType.Ventas;
                }
                else if (sender == this.invRadioBut)
                {
                    this.movementF = Article.MovementType.Inversion;
                }
                else if (sender == this.radioButtonSalario)
                {
                    this.movementF = Article.MovementType.Salario;
                }
            }
        }

        private void totalGastosPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.labelMaestro.Text = "Balance por Periodo";
            HandleVisiblePeriodo(true);
            HandleVisibleIngresarMov(false);
            HandleVisibleIngresarArticulo(false);
            HandleVisibleTable(false);

            this.buttonOKPeriodo.Visible = true;
        }

        private void calculadoraMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculadoraML newFormC = new CalculadoraML();
            newFormC.Show();
        }
    }

}
