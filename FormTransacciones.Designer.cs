namespace MenejadorTransacciones
{
    partial class FormTransacciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransacciones));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalGastosPeriodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFechaInf = new System.Windows.Forms.Label();
            this.inputFechaInf = new System.Windows.Forms.TextBox();
            this.labelFechaSup = new System.Windows.Forms.Label();
            this.inputFechaSup = new System.Windows.Forms.TextBox();
            this.buttonOKPeriodo = new System.Windows.Forms.Button();
            this.comboBoxArticle = new System.Windows.Forms.ComboBox();
            this.labelArticulos = new System.Windows.Forms.Label();
            this.labelPrecioUnitario = new System.Windows.Forms.Label();
            this.textBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSalario = new System.Windows.Forms.RadioButton();
            this.radioButtonVenta = new System.Windows.Forms.RadioButton();
            this.invRadioBut = new System.Windows.Forms.RadioButton();
            this.gastoRadioBut = new System.Windows.Forms.RadioButton();
            this.InputCantidad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAmbos = new System.Windows.Forms.RadioButton();
            this.radioButtonVar = new System.Windows.Forms.RadioButton();
            this.radioButtonFija = new System.Windows.Forms.RadioButton();
            this.radioButtonNinguno = new System.Windows.Forms.RadioButton();
            this.labelConcepto = new System.Windows.Forms.Label();
            this.inputConcepto = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelMaestro = new System.Windows.Forms.Label();
            this.textBoxFixed = new System.Windows.Forms.TextBox();
            this.labelFixed = new System.Windows.Forms.Label();
            this.labelPorcentaje = new System.Windows.Forms.Label();
            this.textBoxPorcentaje = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.ingresarToolStripMenuItem,
            this.calculadoraMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gastosToolStripMenuItem,
            this.totalGastosPeriodoToolStripMenuItem,
            this.negocioToolStripMenuItem,
            this.articulosToolStripMenuItem});
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // gastosToolStripMenuItem
            // 
            this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            this.gastosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gastosToolStripMenuItem.Text = "Gastos";
            this.gastosToolStripMenuItem.Click += new System.EventHandler(this.gastosToolStripMenuItem_Click);
            // 
            // totalGastosPeriodoToolStripMenuItem
            // 
            this.totalGastosPeriodoToolStripMenuItem.Name = "totalGastosPeriodoToolStripMenuItem";
            this.totalGastosPeriodoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.totalGastosPeriodoToolStripMenuItem.Text = "Total Gastos Periodo";
            this.totalGastosPeriodoToolStripMenuItem.Click += new System.EventHandler(this.totalGastosPeriodoToolStripMenuItem_Click);
            // 
            // negocioToolStripMenuItem
            // 
            this.negocioToolStripMenuItem.Name = "negocioToolStripMenuItem";
            this.negocioToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.negocioToolStripMenuItem.Text = "Negocio";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gastosToolStripMenuItem1,
            this.articuloToolStripMenuItem});
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            // 
            // gastosToolStripMenuItem1
            // 
            this.gastosToolStripMenuItem1.Name = "gastosToolStripMenuItem1";
            this.gastosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.gastosToolStripMenuItem1.Text = "Gastos";
            this.gastosToolStripMenuItem1.Click += new System.EventHandler(this.gastosToolStripMenuItem1_Click);
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.articuloToolStripMenuItem.Text = "Articulo";
            this.articuloToolStripMenuItem.Click += new System.EventHandler(this.articuloToolStripMenuItem_Click);
            // 
            // calculadoraMLToolStripMenuItem
            // 
            this.calculadoraMLToolStripMenuItem.Name = "calculadoraMLToolStripMenuItem";
            this.calculadoraMLToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.calculadoraMLToolStripMenuItem.Text = "Calculadora ML";
            this.calculadoraMLToolStripMenuItem.Click += new System.EventHandler(this.calculadoraMLToolStripMenuItem_Click);
            // 
            // labelFechaInf
            // 
            this.labelFechaInf.Location = new System.Drawing.Point(455, 52);
            this.labelFechaInf.Name = "labelFechaInf";
            this.labelFechaInf.Size = new System.Drawing.Size(100, 23);
            this.labelFechaInf.TabIndex = 4;
            this.labelFechaInf.Text = "Fecha Inferior";
            this.labelFechaInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFechaInf.Visible = false;
            // 
            // inputFechaInf
            // 
            this.inputFechaInf.Location = new System.Drawing.Point(561, 54);
            this.inputFechaInf.Name = "inputFechaInf";
            this.inputFechaInf.Size = new System.Drawing.Size(100, 20);
            this.inputFechaInf.TabIndex = 5;
            this.inputFechaInf.Visible = false;
            // 
            // labelFechaSup
            // 
            this.labelFechaSup.Location = new System.Drawing.Point(455, 113);
            this.labelFechaSup.Name = "labelFechaSup";
            this.labelFechaSup.Size = new System.Drawing.Size(100, 23);
            this.labelFechaSup.TabIndex = 6;
            this.labelFechaSup.Text = "Fecha Superior";
            this.labelFechaSup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFechaSup.Visible = false;
            // 
            // inputFechaSup
            // 
            this.inputFechaSup.Location = new System.Drawing.Point(561, 116);
            this.inputFechaSup.Name = "inputFechaSup";
            this.inputFechaSup.Size = new System.Drawing.Size(100, 20);
            this.inputFechaSup.TabIndex = 7;
            this.inputFechaSup.Visible = false;
            // 
            // buttonOKPeriodo
            // 
            this.buttonOKPeriodo.Location = new System.Drawing.Point(574, 244);
            this.buttonOKPeriodo.Name = "buttonOKPeriodo";
            this.buttonOKPeriodo.Size = new System.Drawing.Size(75, 23);
            this.buttonOKPeriodo.TabIndex = 8;
            this.buttonOKPeriodo.Text = "OK";
            this.buttonOKPeriodo.UseVisualStyleBackColor = true;
            this.buttonOKPeriodo.Visible = false;
            this.buttonOKPeriodo.Click += new System.EventHandler(this.buttonOKPeriodo_Click);
            // 
            // comboBoxArticle
            // 
            this.comboBoxArticle.FormattingEnabled = true;
            this.comboBoxArticle.Location = new System.Drawing.Point(561, 89);
            this.comboBoxArticle.Name = "comboBoxArticle";
            this.comboBoxArticle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArticle.TabIndex = 9;
            this.comboBoxArticle.Visible = false;
            // 
            // labelArticulos
            // 
            this.labelArticulos.Location = new System.Drawing.Point(455, 89);
            this.labelArticulos.Name = "labelArticulos";
            this.labelArticulos.Size = new System.Drawing.Size(100, 23);
            this.labelArticulos.TabIndex = 10;
            this.labelArticulos.Text = "Articulo";
            this.labelArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelArticulos.Visible = false;
            // 
            // labelPrecioUnitario
            // 
            this.labelPrecioUnitario.Location = new System.Drawing.Point(455, 143);
            this.labelPrecioUnitario.Name = "labelPrecioUnitario";
            this.labelPrecioUnitario.Size = new System.Drawing.Size(100, 23);
            this.labelPrecioUnitario.TabIndex = 11;
            this.labelPrecioUnitario.Text = "Precio Unitario";
            this.labelPrecioUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPrecioUnitario.Visible = false;
            // 
            // textBoxPrecioUnitario
            // 
            this.textBoxPrecioUnitario.Location = new System.Drawing.Point(561, 145);
            this.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario";
            this.textBoxPrecioUnitario.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioUnitario.TabIndex = 12;
            this.textBoxPrecioUnitario.Visible = false;
            // 
            // labelCantidad
            // 
            this.labelCantidad.Location = new System.Drawing.Point(455, 199);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(100, 23);
            this.labelCantidad.TabIndex = 13;
            this.labelCantidad.Text = "Cantidad";
            this.labelCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCantidad.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSalario);
            this.groupBox1.Controls.Add(this.radioButtonVenta);
            this.groupBox1.Controls.Add(this.invRadioBut);
            this.groupBox1.Controls.Add(this.gastoRadioBut);
            this.groupBox1.Location = new System.Drawing.Point(417, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 147);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Mov";
            this.groupBox1.Visible = false;
            // 
            // radioButtonSalario
            // 
            this.radioButtonSalario.AutoSize = true;
            this.radioButtonSalario.Location = new System.Drawing.Point(6, 99);
            this.radioButtonSalario.Name = "radioButtonSalario";
            this.radioButtonSalario.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSalario.TabIndex = 3;
            this.radioButtonSalario.TabStop = true;
            this.radioButtonSalario.Text = "Salario";
            this.radioButtonSalario.UseVisualStyleBackColor = true;
            this.radioButtonSalario.CheckedChanged += new System.EventHandler(this.gastoRadioBut_CheckedChanged);
            // 
            // radioButtonVenta
            // 
            this.radioButtonVenta.AutoSize = true;
            this.radioButtonVenta.Location = new System.Drawing.Point(6, 52);
            this.radioButtonVenta.Name = "radioButtonVenta";
            this.radioButtonVenta.Size = new System.Drawing.Size(53, 17);
            this.radioButtonVenta.TabIndex = 2;
            this.radioButtonVenta.TabStop = true;
            this.radioButtonVenta.Text = "Venta";
            this.radioButtonVenta.UseVisualStyleBackColor = true;
            this.radioButtonVenta.CheckedChanged += new System.EventHandler(this.gastoRadioBut_CheckedChanged);
            // 
            // invRadioBut
            // 
            this.invRadioBut.AutoSize = true;
            this.invRadioBut.Location = new System.Drawing.Point(6, 75);
            this.invRadioBut.Name = "invRadioBut";
            this.invRadioBut.Size = new System.Drawing.Size(68, 17);
            this.invRadioBut.TabIndex = 1;
            this.invRadioBut.TabStop = true;
            this.invRadioBut.Text = "Inversión";
            this.invRadioBut.UseVisualStyleBackColor = true;
            this.invRadioBut.CheckedChanged += new System.EventHandler(this.gastoRadioBut_CheckedChanged);
            // 
            // gastoRadioBut
            // 
            this.gastoRadioBut.AutoSize = true;
            this.gastoRadioBut.Location = new System.Drawing.Point(6, 28);
            this.gastoRadioBut.Name = "gastoRadioBut";
            this.gastoRadioBut.Size = new System.Drawing.Size(53, 17);
            this.gastoRadioBut.TabIndex = 0;
            this.gastoRadioBut.TabStop = true;
            this.gastoRadioBut.Text = "Gasto";
            this.gastoRadioBut.UseVisualStyleBackColor = true;
            this.gastoRadioBut.CheckedChanged += new System.EventHandler(this.gastoRadioBut_CheckedChanged);
            // 
            // InputCantidad
            // 
            this.InputCantidad.Location = new System.Drawing.Point(561, 202);
            this.InputCantidad.Name = "InputCantidad";
            this.InputCantidad.Size = new System.Drawing.Size(100, 20);
            this.InputCantidad.TabIndex = 15;
            this.InputCantidad.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonAmbos);
            this.groupBox2.Controls.Add(this.radioButtonVar);
            this.groupBox2.Controls.Add(this.radioButtonFija);
            this.groupBox2.Controls.Add(this.radioButtonNinguno);
            this.groupBox2.Location = new System.Drawing.Point(568, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 132);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Impuestos";
            this.groupBox2.Visible = false;
            // 
            // radioButtonAmbos
            // 
            this.radioButtonAmbos.AutoSize = true;
            this.radioButtonAmbos.Location = new System.Drawing.Point(6, 97);
            this.radioButtonAmbos.Name = "radioButtonAmbos";
            this.radioButtonAmbos.Size = new System.Drawing.Size(57, 17);
            this.radioButtonAmbos.TabIndex = 3;
            this.radioButtonAmbos.TabStop = true;
            this.radioButtonAmbos.Text = "Ambos";
            this.radioButtonAmbos.UseVisualStyleBackColor = true;
            this.radioButtonAmbos.CheckedChanged += new System.EventHandler(this.radioButtonNinguno_CheckedChanged);
            // 
            // radioButtonVar
            // 
            this.radioButtonVar.AutoSize = true;
            this.radioButtonVar.Location = new System.Drawing.Point(6, 74);
            this.radioButtonVar.Name = "radioButtonVar";
            this.radioButtonVar.Size = new System.Drawing.Size(84, 17);
            this.radioButtonVar.TabIndex = 2;
            this.radioButtonVar.TabStop = true;
            this.radioButtonVar.Text = "Proporcional";
            this.radioButtonVar.UseVisualStyleBackColor = true;
            this.radioButtonVar.CheckedChanged += new System.EventHandler(this.radioButtonNinguno_CheckedChanged);
            // 
            // radioButtonFija
            // 
            this.radioButtonFija.AutoSize = true;
            this.radioButtonFija.Location = new System.Drawing.Point(6, 51);
            this.radioButtonFija.Name = "radioButtonFija";
            this.radioButtonFija.Size = new System.Drawing.Size(41, 17);
            this.radioButtonFija.TabIndex = 1;
            this.radioButtonFija.TabStop = true;
            this.radioButtonFija.Text = "Fija";
            this.radioButtonFija.UseVisualStyleBackColor = true;
            this.radioButtonFija.CheckedChanged += new System.EventHandler(this.radioButtonNinguno_CheckedChanged);
            // 
            // radioButtonNinguno
            // 
            this.radioButtonNinguno.AutoSize = true;
            this.radioButtonNinguno.Location = new System.Drawing.Point(6, 28);
            this.radioButtonNinguno.Name = "radioButtonNinguno";
            this.radioButtonNinguno.Size = new System.Drawing.Size(65, 17);
            this.radioButtonNinguno.TabIndex = 0;
            this.radioButtonNinguno.TabStop = true;
            this.radioButtonNinguno.Text = "Ninguno";
            this.radioButtonNinguno.UseVisualStyleBackColor = true;
            this.radioButtonNinguno.CheckedChanged += new System.EventHandler(this.radioButtonNinguno_CheckedChanged);
            // 
            // labelConcepto
            // 
            this.labelConcepto.Location = new System.Drawing.Point(455, 166);
            this.labelConcepto.Name = "labelConcepto";
            this.labelConcepto.Size = new System.Drawing.Size(100, 23);
            this.labelConcepto.TabIndex = 17;
            this.labelConcepto.Text = "Concepto";
            this.labelConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelConcepto.Visible = false;
            // 
            // inputConcepto
            // 
            this.inputConcepto.Location = new System.Drawing.Point(561, 171);
            this.inputConcepto.Name = "inputConcepto";
            this.inputConcepto.Size = new System.Drawing.Size(100, 20);
            this.inputConcepto.TabIndex = 18;
            this.inputConcepto.Visible = false;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.Location = new System.Drawing.Point(455, 218);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(100, 23);
            this.labelDescripcion.TabIndex = 19;
            this.labelDescripcion.Text = "Descripcion";
            this.labelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDescripcion.Visible = false;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(561, 218);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescripcion.TabIndex = 20;
            this.textBoxDescripcion.Visible = false;
            // 
            // labelMaestro
            // 
            this.labelMaestro.Location = new System.Drawing.Point(391, 29);
            this.labelMaestro.Name = "labelMaestro";
            this.labelMaestro.Size = new System.Drawing.Size(140, 23);
            this.labelMaestro.TabIndex = 21;
            // 
            // textBoxFixed
            // 
            this.textBoxFixed.Location = new System.Drawing.Point(688, 171);
            this.textBoxFixed.Name = "textBoxFixed";
            this.textBoxFixed.Size = new System.Drawing.Size(100, 20);
            this.textBoxFixed.TabIndex = 22;
            this.textBoxFixed.Visible = false;
            // 
            // labelFixed
            // 
            this.labelFixed.Location = new System.Drawing.Point(688, 145);
            this.labelFixed.Name = "labelFixed";
            this.labelFixed.Size = new System.Drawing.Size(100, 23);
            this.labelFixed.TabIndex = 23;
            this.labelFixed.Text = "Impuesto Fijo";
            this.labelFixed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFixed.Visible = false;
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.Location = new System.Drawing.Point(688, 202);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(100, 23);
            this.labelPorcentaje.TabIndex = 24;
            this.labelPorcentaje.Text = "Porcentaje";
            this.labelPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPorcentaje.Visible = false;
            // 
            // textBoxPorcentaje
            // 
            this.textBoxPorcentaje.Location = new System.Drawing.Point(691, 228);
            this.textBoxPorcentaje.Name = "textBoxPorcentaje";
            this.textBoxPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.textBoxPorcentaje.TabIndex = 25;
            this.textBoxPorcentaje.Visible = false;
            // 
            // FormTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPorcentaje);
            this.Controls.Add(this.labelPorcentaje);
            this.Controls.Add(this.labelFixed);
            this.Controls.Add(this.textBoxFixed);
            this.Controls.Add(this.labelMaestro);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.inputConcepto);
            this.Controls.Add(this.labelConcepto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InputCantidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.textBoxPrecioUnitario);
            this.Controls.Add(this.labelPrecioUnitario);
            this.Controls.Add(this.labelArticulos);
            this.Controls.Add(this.comboBoxArticle);
            this.Controls.Add(this.buttonOKPeriodo);
            this.Controls.Add(this.inputFechaSup);
            this.Controls.Add(this.labelFechaSup);
            this.Controls.Add(this.inputFechaInf);
            this.Controls.Add(this.labelFechaInf);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTransacciones";
            this.Text = "FormTransacciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalGastosPeriodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraMLToolStripMenuItem;
        private System.Windows.Forms.Label labelFechaInf;
        private System.Windows.Forms.TextBox inputFechaInf;
        private System.Windows.Forms.Label labelFechaSup;
        private System.Windows.Forms.TextBox inputFechaSup;
        private System.Windows.Forms.Button buttonOKPeriodo;
        private System.Windows.Forms.ComboBox comboBoxArticle;
        private System.Windows.Forms.Label labelArticulos;
        private System.Windows.Forms.Label labelPrecioUnitario;
        private System.Windows.Forms.TextBox textBoxPrecioUnitario;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton invRadioBut;
        private System.Windows.Forms.RadioButton gastoRadioBut;
        private System.Windows.Forms.TextBox InputCantidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonAmbos;
        private System.Windows.Forms.RadioButton radioButtonVar;
        private System.Windows.Forms.RadioButton radioButtonFija;
        private System.Windows.Forms.RadioButton radioButtonNinguno;
        private System.Windows.Forms.Label labelConcepto;
        private System.Windows.Forms.TextBox inputConcepto;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelMaestro;
        private System.Windows.Forms.RadioButton radioButtonVenta;
        private System.Windows.Forms.RadioButton radioButtonSalario;
        private System.Windows.Forms.TextBox textBoxFixed;
        private System.Windows.Forms.Label labelFixed;
        private System.Windows.Forms.Label labelPorcentaje;
        private System.Windows.Forms.TextBox textBoxPorcentaje;
    }
}

