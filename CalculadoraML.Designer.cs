namespace MenejadorTransacciones
{
    partial class CalculadoraML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelImpuestoIVA = new System.Windows.Forms.Label();
            this.labelRetGan = new System.Windows.Forms.Label();
            this.labelCostoEnv = new System.Windows.Forms.Label();
            this.labelRetML = new System.Windows.Forms.Label();
            this.labelCostoProd = new System.Windows.Forms.Label();
            this.labelGanDeseada = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.inputImpIVA = new System.Windows.Forms.TextBox();
            this.inputRetGan = new System.Windows.Forms.TextBox();
            this.inputCostEnv = new System.Windows.Forms.TextBox();
            this.inputCostoProd = new System.Windows.Forms.TextBox();
            this.inputGanDeseada = new System.Windows.Forms.TextBox();
            this.inputRetML = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelImpuestoIVA
            // 
            this.labelImpuestoIVA.AutoSize = true;
            this.labelImpuestoIVA.Location = new System.Drawing.Point(12, 37);
            this.labelImpuestoIVA.Name = "labelImpuestoIVA";
            this.labelImpuestoIVA.Size = new System.Drawing.Size(70, 13);
            this.labelImpuestoIVA.TabIndex = 0;
            this.labelImpuestoIVA.Text = "Impuesto IVA";
            // 
            // labelRetGan
            // 
            this.labelRetGan.AutoSize = true;
            this.labelRetGan.Location = new System.Drawing.Point(0, 72);
            this.labelRetGan.Name = "labelRetGan";
            this.labelRetGan.Size = new System.Drawing.Size(82, 13);
            this.labelRetGan.TabIndex = 1;
            this.labelRetGan.Text = "Retención Gan.";
            // 
            // labelCostoEnv
            // 
            this.labelCostoEnv.AutoSize = true;
            this.labelCostoEnv.Location = new System.Drawing.Point(12, 108);
            this.labelCostoEnv.Name = "labelCostoEnv";
            this.labelCostoEnv.Size = new System.Drawing.Size(66, 13);
            this.labelCostoEnv.TabIndex = 2;
            this.labelCostoEnv.Text = "Costo Envío";
            // 
            // labelRetML
            // 
            this.labelRetML.AutoSize = true;
            this.labelRetML.Location = new System.Drawing.Point(214, 108);
            this.labelRetML.Name = "labelRetML";
            this.labelRetML.Size = new System.Drawing.Size(74, 13);
            this.labelRetML.TabIndex = 3;
            this.labelRetML.Text = "Retención ML";
            // 
            // labelCostoProd
            // 
            this.labelCostoProd.AutoSize = true;
            this.labelCostoProd.Location = new System.Drawing.Point(226, 37);
            this.labelCostoProd.Name = "labelCostoProd";
            this.labelCostoProd.Size = new System.Drawing.Size(62, 13);
            this.labelCostoProd.TabIndex = 4;
            this.labelCostoProd.Text = "Costo Prod.";
            // 
            // labelGanDeseada
            // 
            this.labelGanDeseada.AutoSize = true;
            this.labelGanDeseada.Location = new System.Drawing.Point(212, 72);
            this.labelGanDeseada.Name = "labelGanDeseada";
            this.labelGanDeseada.Size = new System.Drawing.Size(76, 13);
            this.labelGanDeseada.TabIndex = 5;
            this.labelGanDeseada.Text = "Gan. Deseada";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(165, 209);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 7;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // inputImpIVA
            // 
            this.inputImpIVA.Location = new System.Drawing.Point(84, 34);
            this.inputImpIVA.Name = "inputImpIVA";
            this.inputImpIVA.Size = new System.Drawing.Size(100, 20);
            this.inputImpIVA.TabIndex = 9;
            // 
            // inputRetGan
            // 
            this.inputRetGan.Location = new System.Drawing.Point(84, 69);
            this.inputRetGan.Name = "inputRetGan";
            this.inputRetGan.Size = new System.Drawing.Size(100, 20);
            this.inputRetGan.TabIndex = 10;
            // 
            // inputCostEnv
            // 
            this.inputCostEnv.Location = new System.Drawing.Point(84, 105);
            this.inputCostEnv.Name = "inputCostEnv";
            this.inputCostEnv.Size = new System.Drawing.Size(100, 20);
            this.inputCostEnv.TabIndex = 11;
            // 
            // inputCostoProd
            // 
            this.inputCostoProd.Location = new System.Drawing.Point(294, 34);
            this.inputCostoProd.Name = "inputCostoProd";
            this.inputCostoProd.Size = new System.Drawing.Size(100, 20);
            this.inputCostoProd.TabIndex = 12;
            // 
            // inputGanDeseada
            // 
            this.inputGanDeseada.Location = new System.Drawing.Point(294, 69);
            this.inputGanDeseada.Name = "inputGanDeseada";
            this.inputGanDeseada.Size = new System.Drawing.Size(100, 20);
            this.inputGanDeseada.TabIndex = 13;
            // 
            // inputRetML
            // 
            this.inputRetML.Location = new System.Drawing.Point(294, 105);
            this.inputRetML.Name = "inputRetML";
            this.inputRetML.Size = new System.Drawing.Size(100, 20);
            this.inputRetML.TabIndex = 14;
            // 
            // CalculadoraML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 255);
            this.Controls.Add(this.inputRetML);
            this.Controls.Add(this.inputGanDeseada);
            this.Controls.Add(this.inputCostoProd);
            this.Controls.Add(this.inputCostEnv);
            this.Controls.Add(this.inputRetGan);
            this.Controls.Add(this.inputImpIVA);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelGanDeseada);
            this.Controls.Add(this.labelCostoProd);
            this.Controls.Add(this.labelRetML);
            this.Controls.Add(this.labelCostoEnv);
            this.Controls.Add(this.labelRetGan);
            this.Controls.Add(this.labelImpuestoIVA);
            this.Name = "CalculadoraML";
            this.Text = "CalculadoraML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImpuestoIVA;
        private System.Windows.Forms.Label labelRetGan;
        private System.Windows.Forms.Label labelCostoEnv;
        private System.Windows.Forms.Label labelRetML;
        private System.Windows.Forms.Label labelCostoProd;
        private System.Windows.Forms.Label labelGanDeseada;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox inputImpIVA;
        private System.Windows.Forms.TextBox inputRetGan;
        private System.Windows.Forms.TextBox inputCostEnv;
        private System.Windows.Forms.TextBox inputCostoProd;
        private System.Windows.Forms.TextBox inputGanDeseada;
        private System.Windows.Forms.TextBox inputRetML;
    }
}