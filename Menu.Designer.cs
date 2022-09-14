﻿namespace Proyecto_Final
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvInventario = new System.Windows.Forms.ListView();
            this.cModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvVendedores = new System.Windows.Forms.ListView();
            this.cCedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido AlejoStuntXXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vendedores";
            // 
            // lvInventario
            // 
            this.lvInventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cModelo,
            this.cValor,
            this.cCantidad});
            this.lvInventario.HideSelection = false;
            this.lvInventario.Location = new System.Drawing.Point(117, 113);
            this.lvInventario.Name = "lvInventario";
            this.lvInventario.Size = new System.Drawing.Size(482, 97);
            this.lvInventario.TabIndex = 4;
            this.lvInventario.UseCompatibleStateImageBehavior = false;
            this.lvInventario.View = System.Windows.Forms.View.Details;
            // 
            // cModelo
            // 
            this.cModelo.Text = "Modelo";
            this.cModelo.Width = 150;
            // 
            // cValor
            // 
            this.cValor.Text = "Valor";
            this.cValor.Width = 150;
            // 
            // cCantidad
            // 
            this.cCantidad.Text = "Cantidad";
            this.cCantidad.Width = 150;
            // 
            // lvVendedores
            // 
            this.lvVendedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cCedula,
            this.cNombre,
            this.cTotal});
            this.lvVendedores.HideSelection = false;
            this.lvVendedores.Location = new System.Drawing.Point(117, 283);
            this.lvVendedores.Name = "lvVendedores";
            this.lvVendedores.Size = new System.Drawing.Size(482, 97);
            this.lvVendedores.TabIndex = 5;
            this.lvVendedores.UseCompatibleStateImageBehavior = false;
            this.lvVendedores.View = System.Windows.Forms.View.Details;
            // 
            // cCedula
            // 
            this.cCedula.Text = "Cedula";
            this.cCedula.Width = 150;
            // 
            // cNombre
            // 
            this.cNombre.Text = "Nombre";
            this.cNombre.Width = 150;
            // 
            // cTotal
            // 
            this.cTotal.Text = "Total Vendido";
            this.cTotal.Width = 150;
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(605, 149);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(75, 23);
            this.btnInventario.TabIndex = 6;
            this.btnInventario.Text = "Actualizar";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnVendedores
            // 
            this.btnVendedores.Location = new System.Drawing.Point(605, 305);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(75, 23);
            this.btnVendedores.TabIndex = 7;
            this.btnVendedores.Text = "Actualizar";
            this.btnVendedores.UseVisualStyleBackColor = true;
            this.btnVendedores.Click += new System.EventHandler(this.btnVendedores_Click);
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(352, 409);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 29);
            this.btnVender.TabIndex = 8;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(605, 334);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(75, 23);
            this.btnVentas.TabIndex = 9;
            this.btnVentas.Text = "Ver Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnVendedores);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.lvVendedores);
            this.Controls.Add(this.lvInventario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "AlejoStuntXXX";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvInventario;
        private System.Windows.Forms.ColumnHeader cModelo;
        private System.Windows.Forms.ColumnHeader cValor;
        private System.Windows.Forms.ColumnHeader cCantidad;
        private System.Windows.Forms.ListView lvVendedores;
        private System.Windows.Forms.ColumnHeader cCedula;
        private System.Windows.Forms.ColumnHeader cNombre;
        private System.Windows.Forms.ColumnHeader cTotal;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVendedores;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}