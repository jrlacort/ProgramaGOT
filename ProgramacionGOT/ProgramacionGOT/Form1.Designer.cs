﻿namespace ProgramacionGOT
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Baratheon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botonCasaBaratheon);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(452, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Historia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.botonHistoria);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 84);
            this.button3.TabIndex = 2;
            this.button3.Text = "Martell";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.botonCasaMartell);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 84);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lannister";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.botonCasaLannister);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 84);
            this.button5.TabIndex = 4;
            this.button5.Text = "Stark";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.botonCasaStark);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(89, 140);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 84);
            this.button6.TabIndex = 5;
            this.button6.Text = "Targaryen";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.botonCasaTargaryen);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 429);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

