﻿namespace Wall_E;

partial class Aplication
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
        this.Entrada = new System.Windows.Forms.RichTextBox();
        this.Plano = new System.Windows.Forms.PictureBox();
        this.Consola = new System.Windows.Forms.Label();
        this.Run = new System.Windows.Forms.Button();
        this.Clean = new System.Windows.Forms.Button();
        this.Save = new System.Windows.Forms.Button();
        this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        ((System.ComponentModel.ISupportInitialize)(this.Plano)).BeginInit();
        this.SuspendLayout();
        // 
        // Entrada
        // 
        // this.Entrada.Location = new System.Drawing.Point(12, 12);
        // this.Entrada.Name = "Entrada";
        // this.Entrada.Size = new System.Drawing.Size(239, 312);
        // this.Entrada.TabIndex = 0;
        // this.Entrada.Text = "";
        this.Entrada.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Entrada.Location = new System.Drawing.Point(12, 12);
        this.Entrada.Name = "Entrada";
        this.Entrada.Size = new System.Drawing.Size(472, 503);
        this.Entrada.TabIndex = 0;
        this.Entrada.Text = "";
        // 
        // Plano
        // 
        // this.Plano.Location = new System.Drawing.Point(348, 12);
        // this.Plano.Name = "Plano";
        // this.Plano.Size = new System.Drawing.Size(440, 440);
        // this.Plano.TabIndex = 1;
        // this.Plano.TabStop = false;
        this.Plano.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        this.Plano.Dock = System.Windows.Forms.DockStyle.Right;
        this.Plano.Location = new System.Drawing.Point(627, 0);
        this.Plano.Name = "Plano";
        this.Plano.Size = new System.Drawing.Size(809, 823);
        this.Plano.TabIndex = 1;
        this.Plano.TabStop = false;
        //this.Plano.Click += new System.EventHandler(this.Plano_Click);
        // 
        // Consola
        // 
        // this.Consola.AutoSize = true;
        // this.Consola.Location = new System.Drawing.Point(12, 331);
        // this.Consola.Name = "Consola";
        // this.Consola.Size = new System.Drawing.Size(0, 16);
        // this.Consola.TabIndex = 2;
        this.Consola.AutoSize = true;
        this.Consola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        this.Consola.Location = new System.Drawing.Point(13, 522);
        this.Consola.Name = "Consola";
        this.Consola.Size = new System.Drawing.Size(0, 16);
        this.Consola.TabIndex = 5;
        // 
        // Run
        // 
        // this.Run.Location = new System.Drawing.Point(257, 24);
        // this.Run.Name = "Run";
        // this.Run.Size = new System.Drawing.Size(85, 23);
        // this.Run.TabIndex = 3;
        // this.Run.Text = "RUN";
        // this.Run.UseVisualStyleBackColor = true;
        this.Run.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Run.Location = new System.Drawing.Point(516, 67);
        this.Run.Name = "Run";
        this.Run.Size = new System.Drawing.Size(84, 60);
        this.Run.TabIndex = 2;
        this.Run.Text = "Run";
        this.Run.UseVisualStyleBackColor = true;
        this.Run.Click += new System.EventHandler(this.Run_Click);
        // 
        // Clean
        // 
        // this.Clear.Location = new System.Drawing.Point(257, 66);
        // this.Clear.Name = "Clear";
        // this.Clear.Size = new System.Drawing.Size(85, 23);
        // this.Clear.TabIndex = 4;
        // this.Clear.Text = "CLEAR";
        // this.Clear.UseVisualStyleBackColor = true;
        this.Clean.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Clean.Location = new System.Drawing.Point(516, 214);
        this.Clean.Name = "Clean";
        this.Clean.Size = new System.Drawing.Size(84, 60);
        this.Clean.TabIndex = 3;
        this.Clean.Text = "Clean";
        this.Clean.UseVisualStyleBackColor = true;
        this.Clean.Click += new System.EventHandler(this.Clean_Click);

        // 
        // SAVE
        //
        // this.Save.Location = new System.Drawing.Point(257, 150);
        // this.Save.Name = "Save";
        // this.Save.Size = new System.Drawing.Size(85, 23);
        // this.Save.TabIndex = 6;
        // this.Save.Text = "SAVE";
        // this.Save.UseVisualStyleBackColor = true;
        // this.Save.Click += new System.EventHandler(this.Save_Click);
        this.Save.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Save.Location = new System.Drawing.Point(516, 364);
        this.Save.Name = "Save";
        this.Save.Size = new System.Drawing.Size(84, 60);
        this.Save.TabIndex = 4;
        this.Save.Text = "Save";
        this.Save.UseVisualStyleBackColor = true;
        this.Save.Click += new System.EventHandler(this.Save_Click);


        // 
        // Form1
        // 
        // this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        // this.ClientSize = new System.Drawing.Size(800, 450);
        // this.Controls.Add(this.Clear);
        // this.Controls.Add(this.Run);
        // this.Controls.Add(this.Consola);
        // this.Controls.Add(this.Plano);
        // this.Controls.Add(this.Entrada);
        // this.Controls.Add(this.Save);
        // this.Name = "Form1";
        // this.Text = "Form1";
        // ((System.ComponentModel.ISupportInitialize)(this.Plano)).EndInit();
        // this.ResumeLayout(false);
        // this.PerformLayout();
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        this.ClientSize = new System.Drawing.Size(1436, 823);
        this.Controls.Add(this.Consola);
        this.Controls.Add(this.Save);
        this.Controls.Add(this.Clean);
        this.Controls.Add(this.Run);
        this.Controls.Add(this.Plano);
        this.Controls.Add(this.Entrada);
        this.Name = "Form1";
        this.Text = "GeoWall_E";
        ((System.ComponentModel.ISupportInitialize)(this.Plano)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();


    }

    #endregion

    private System.Windows.Forms.RichTextBox Entrada;
    private System.Windows.Forms.PictureBox Plano;
    private System.Windows.Forms.Label Consola;
    private System.Windows.Forms.Button Run;
    private System.Windows.Forms.Button Clean;
    private System.Windows.Forms.Button Save;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
}
