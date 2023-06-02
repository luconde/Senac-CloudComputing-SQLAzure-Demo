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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(104, 183);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 102;
            this.dataGrid.RowTemplate.Height = 49;
            this.dataGrid.Size = new System.Drawing.Size(1910, 625);
            this.dataGrid.TabIndex = 0;
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(1586, 846);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(428, 71);
            this.cmdLoad.TabIndex = 1;
            this.cmdLoad.Text = "Carregar";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "String de Conexão no Azure SQL:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(579, 30);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(1435, 118);
            this.txtConnectionString.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2068, 959);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.dataGrid);
            this.Name = "frmPrincipal";
            this.Text = "Conectando no SQL Azure";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGrid;
        private Button cmdLoad;
        private Label label1;
        private TextBox txtConnectionString;
    }
}