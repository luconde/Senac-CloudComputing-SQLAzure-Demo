namespace DemoWindowsFormSQLAzure
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGrid = new DataGridView();
            cmdLoad = new Button();
            label1 = new Label();
            txtConnectionString = new TextBox();
            label2 = new Label();
            txtNomeDaTabela = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(43, 175);
            dataGrid.Margin = new Padding(1);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 102;
            dataGrid.RowTemplate.Height = 49;
            dataGrid.Size = new Size(786, 229);
            dataGrid.TabIndex = 0;
            // 
            // cmdLoad
            // 
            cmdLoad.Location = new Point(653, 425);
            cmdLoad.Margin = new Padding(1);
            cmdLoad.Name = "cmdLoad";
            cmdLoad.Size = new Size(176, 26);
            cmdLoad.TabIndex = 1;
            cmdLoad.Text = "Carregar";
            cmdLoad.UseVisualStyleBackColor = true;
            cmdLoad.Click += cmdLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 10);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 2;
            label1.Text = "String de Conexão no Azure SQL:";
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(238, 11);
            txtConnectionString.Margin = new Padding(1);
            txtConnectionString.Multiline = true;
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(593, 87);
            txtConnectionString.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 105);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome da Tabela:";
            // 
            // txtNomeDaTabela
            // 
            txtNomeDaTabela.Location = new Point(238, 102);
            txtNomeDaTabela.Name = "txtNomeDaTabela";
            txtNomeDaTabela.Size = new Size(250, 23);
            txtNomeDaTabela.TabIndex = 5;
            txtNomeDaTabela.Text = "Cliente";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 469);
            Controls.Add(txtNomeDaTabela);
            Controls.Add(label2);
            Controls.Add(txtConnectionString);
            Controls.Add(label1);
            Controls.Add(cmdLoad);
            Controls.Add(dataGrid);
            Margin = new Padding(1);
            Name = "frmPrincipal";
            Text = "Conectando no SQL Azure";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private Button cmdLoad;
        private Label label1;
        private TextBox txtConnectionString;
        private Label label2;
        private TextBox txtNomeDaTabela;
    }
}