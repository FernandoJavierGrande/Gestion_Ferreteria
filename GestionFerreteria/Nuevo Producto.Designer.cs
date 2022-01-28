namespace GestionFerreteria
{
    partial class agregarNuevoProducto
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
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.cmb_cat = new System.Windows.Forms.ComboBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_porc = new System.Windows.Forms.TextBox();
            this.txt_preciof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_nuevoId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_descProv = new System.Windows.Forms.TextBox();
            this.txt_precioProveedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(61, 147);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(117, 22);
            this.txt_codigo.TabIndex = 0;
            this.txt_codigo.Text = "2556";
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(243, 147);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(142, 22);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "PINZA";
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(443, 145);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(114, 22);
            this.txt_marca.TabIndex = 2;
            this.txt_marca.Text = "CROSSMAN";
            this.txt_marca.Leave += new System.EventHandler(this.txt_marca_Leave);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(840, 143);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(202, 155);
            this.txt_desc.TabIndex = 4;
            this.txt_desc.Text = "ALJSBDSKSKS555AAsddd";
            // 
            // cmb_cat
            // 
            this.cmb_cat.FormattingEnabled = true;
            this.cmb_cat.Location = new System.Drawing.Point(605, 145);
            this.cmb_cat.Name = "cmb_cat";
            this.cmb_cat.Size = new System.Drawing.Size(121, 24);
            this.cmb_cat.TabIndex = 3;
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(353, 358);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(76, 22);
            this.txt_costo.TabIndex = 7;
            this.txt_costo.Text = "100";
            this.txt_costo.Leave += new System.EventHandler(this.txt_costo_Leave);
            // 
            // txt_porc
            // 
            this.txt_porc.Location = new System.Drawing.Point(518, 357);
            this.txt_porc.Name = "txt_porc";
            this.txt_porc.Size = new System.Drawing.Size(60, 22);
            this.txt_porc.TabIndex = 8;
            this.txt_porc.Leave += new System.EventHandler(this.txt_porc_Leave);
            // 
            // txt_preciof
            // 
            this.txt_preciof.Location = new System.Drawing.Point(671, 358);
            this.txt_preciof.Name = "txt_preciof";
            this.txt_preciof.Size = new System.Drawing.Size(100, 22);
            this.txt_preciof.TabIndex = 9;
            this.txt_preciof.Text = "200";
            this.txt_preciof.Leave += new System.EventHandler(this.txt_preciof_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(837, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Costo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Porcentaje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(679, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Precio final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nuevo producto id: ";
            // 
            // label_nuevoId
            // 
            this.label_nuevoId.AutoSize = true;
            this.label_nuevoId.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nuevoId.Location = new System.Drawing.Point(327, 51);
            this.label_nuevoId.Name = "label_nuevoId";
            this.label_nuevoId.Size = new System.Drawing.Size(40, 27);
            this.label_nuevoId.TabIndex = 17;
            this.label_nuevoId.Text = "id";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(840, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 146);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_descProv
            // 
            this.txt_descProv.Location = new System.Drawing.Point(212, 357);
            this.txt_descProv.Name = "txt_descProv";
            this.txt_descProv.Size = new System.Drawing.Size(59, 22);
            this.txt_descProv.TabIndex = 6;
            this.txt_descProv.Text = "12";
            this.txt_descProv.TextChanged += new System.EventHandler(this.txt_descProv_TextChanged);
            this.txt_descProv.Leave += new System.EventHandler(this.txt_descProv_Leave);
            // 
            // txt_precioProveedor
            // 
            this.txt_precioProveedor.Location = new System.Drawing.Point(62, 357);
            this.txt_precioProveedor.Name = "txt_precioProveedor";
            this.txt_precioProveedor.Size = new System.Drawing.Size(100, 22);
            this.txt_precioProveedor.TabIndex = 5;
            this.txt_precioProveedor.Text = "1";
            this.txt_precioProveedor.TextChanged += new System.EventHandler(this.txt_precioProveedor_TextChanged);
            this.txt_precioProveedor.Leave += new System.EventHandler(this.txt_precioProv_Leave);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(66, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 41);
            this.label10.TabIndex = 21;
            this.label10.Text = "Precio de Lista de proveedor";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(194, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 42);
            this.label11.TabIndex = 22;
            this.label11.Text = "Descuento sobre\r\nprecio de lista %\r\n";
            // 
            // agregarNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1175, 630);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_precioProveedor);
            this.Controls.Add(this.txt_descProv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_nuevoId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_preciof);
            this.Controls.Add(this.txt_porc);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.cmb_cat);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Name = "agregarNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevo producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.agregarNuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.ComboBox cmb_cat;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_porc;
        private System.Windows.Forms.TextBox txt_preciof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_nuevoId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_descProv;
        private System.Windows.Forms.TextBox txt_precioProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}