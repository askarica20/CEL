namespace CELnovi
{
    partial class FrmOprema
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
            this.dgvOprema = new System.Windows.Forms.DataGridView();
            this.btnUnesi2 = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOprema
            // 
            this.dgvOprema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOprema.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvOprema.Location = new System.Drawing.Point(63, 54);
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOprema.Size = new System.Drawing.Size(1043, 289);
            this.dgvOprema.TabIndex = 0;
            // 
            // btnUnesi2
            // 
            this.btnUnesi2.BackColor = System.Drawing.Color.Lime;
            this.btnUnesi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesi2.ForeColor = System.Drawing.Color.Black;
            this.btnUnesi2.Location = new System.Drawing.Point(859, 362);
            this.btnUnesi2.Name = "btnUnesi2";
            this.btnUnesi2.Size = new System.Drawing.Size(227, 43);
            this.btnUnesi2.TabIndex = 1;
            this.btnUnesi2.Text = "UNESI OPREMU";
            this.btnUnesi2.UseVisualStyleBackColor = false;
            this.btnUnesi2.Click += new System.EventHandler(this.btnUnesi2Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.Lime;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.Color.Black;
            this.btnUredi.Location = new System.Drawing.Point(691, 362);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(138, 43);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "UREDI";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.bntUrediClick);
            // 
            // FrmOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1173, 450);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnesi2);
            this.Controls.Add(this.dgvOprema);
            this.Name = "FrmOprema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOprema";
            this.Load += new System.EventHandler(this.FrmOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.Button btnUnesi2;
        private System.Windows.Forms.Button btnUredi;
    }
}