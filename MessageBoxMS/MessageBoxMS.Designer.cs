namespace MessageBoxMS
{
    partial class MessageBoxMS
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pbxIcono = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 33);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(138, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(129, 27);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Boton 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(3, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(129, 27);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "Boton 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(273, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(130, 27);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Boton 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(61, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(41, 15);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "label1";
            // 
            // pbxIcono
            // 
            this.pbxIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcono.Image = global::MessageBoxMS.Properties.Resources.informacion24;
            this.pbxIcono.Location = new System.Drawing.Point(9, 7);
            this.pbxIcono.Name = "pbxIcono";
            this.pbxIcono.Size = new System.Drawing.Size(39, 33);
            this.pbxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxIcono.TabIndex = 2;
            this.pbxIcono.TabStop = false;
            // 
            // MessageBoxMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MessageBoxMS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(430, 138);
            this.Controls.Add(this.pbxIcono);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxMS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxMS";
            this.Shown += new System.EventHandler(this.MessageBoxMS_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pbxIcono;
    }
}