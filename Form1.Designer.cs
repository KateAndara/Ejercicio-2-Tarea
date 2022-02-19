namespace Ejercicio_2_Tarea
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.EdadtextBox = new System.Windows.Forms.TextBox();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.DatoscomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad del Estudiante";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(312, 103);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(150, 31);
            this.NombretextBox.TabIndex = 2;
            // 
            // EdadtextBox
            // 
            this.EdadtextBox.Location = new System.Drawing.Point(312, 199);
            this.EdadtextBox.Name = "EdadtextBox";
            this.EdadtextBox.Size = new System.Drawing.Size(150, 31);
            this.EdadtextBox.TabIndex = 3;
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mostrarbutton.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mostrarbutton.Location = new System.Drawing.Point(312, 328);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(150, 69);
            this.Mostrarbutton.TabIndex = 4;
            this.Mostrarbutton.Text = "Mostrar Datos";
            this.Mostrarbutton.UseVisualStyleBackColor = false;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // DatoscomboBox
            // 
            this.DatoscomboBox.FormattingEnabled = true;
            this.DatoscomboBox.Location = new System.Drawing.Point(483, 440);
            this.DatoscomboBox.Name = "DatoscomboBox";
            this.DatoscomboBox.Size = new System.Drawing.Size(182, 33);
            this.DatoscomboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre y Edad del Estudiante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 7;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardarbutton.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Guardarbutton.Location = new System.Drawing.Point(553, 137);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(112, 63);
            this.Guardarbutton.TabIndex = 8;
            this.Guardarbutton.Text = "Guardar Datos";
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(232, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datos de Estudiantes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 575);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatoscomboBox);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.EdadtextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NombretextBox;
        private TextBox EdadtextBox;
        private Button Mostrarbutton;
        private ComboBox DatoscomboBox;
        private Label label3;
        private Label label4;
        private Button Guardarbutton;
        private Label label5;
    }
}