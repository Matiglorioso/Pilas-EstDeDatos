namespace Pilas
{
    partial class Form1
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
            this.cmdQuitarPila2 = new System.Windows.Forms.Button();
            this.cmdQuitarPila1 = new System.Windows.Forms.Button();
            this.lstPila1 = new System.Windows.Forms.ListBox();
            this.lstPila2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdQuitarPila2
            // 
            this.cmdQuitarPila2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdQuitarPila2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdQuitarPila2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmdQuitarPila2.Location = new System.Drawing.Point(182, 25);
            this.cmdQuitarPila2.Name = "cmdQuitarPila2";
            this.cmdQuitarPila2.Size = new System.Drawing.Size(73, 52);
            this.cmdQuitarPila2.TabIndex = 0;
            this.cmdQuitarPila2.Text = "<<";
            this.cmdQuitarPila2.UseVisualStyleBackColor = false;
            this.cmdQuitarPila2.Click += new System.EventHandler(this.cmdQuitarPila2_Click);
            // 
            // cmdQuitarPila1
            // 
            this.cmdQuitarPila1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdQuitarPila1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdQuitarPila1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmdQuitarPila1.Location = new System.Drawing.Point(264, 25);
            this.cmdQuitarPila1.Name = "cmdQuitarPila1";
            this.cmdQuitarPila1.Size = new System.Drawing.Size(72, 52);
            this.cmdQuitarPila1.TabIndex = 1;
            this.cmdQuitarPila1.Text = " >>";
            this.cmdQuitarPila1.UseVisualStyleBackColor = false;
            this.cmdQuitarPila1.Click += new System.EventHandler(this.cmdQuitarPila1_Click);
            // 
            // lstPila1
            // 
            this.lstPila1.FormattingEnabled = true;
            this.lstPila1.ItemHeight = 37;
            this.lstPila1.Location = new System.Drawing.Point(12, 91);
            this.lstPila1.Name = "lstPila1";
            this.lstPila1.Size = new System.Drawing.Size(243, 263);
            this.lstPila1.TabIndex = 2;
            // 
            // lstPila2
            // 
            this.lstPila2.FormattingEnabled = true;
            this.lstPila2.ItemHeight = 37;
            this.lstPila2.Location = new System.Drawing.Point(264, 91);
            this.lstPila2.Name = "lstPila2";
            this.lstPila2.Size = new System.Drawing.Size(243, 263);
            this.lstPila2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(164, 370);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 43);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(164, 427);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(198, 43);
            this.txtDNI.TabIndex = 7;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdAgregar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmdAgregar.Location = new System.Drawing.Point(377, 370);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(130, 100);
            this.cmdAgregar.TabIndex = 8;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = false;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(525, 482);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPila2);
            this.Controls.Add(this.lstPila1);
            this.Controls.Add(this.cmdQuitarPila1);
            this.Controls.Add(this.cmdQuitarPila2);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Manejo de Pilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmdQuitarPila2;
        private Button cmdQuitarPila1;
        private ListBox lstPila1;
        private ListBox lstPila2;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Button cmdAgregar;
    }
}