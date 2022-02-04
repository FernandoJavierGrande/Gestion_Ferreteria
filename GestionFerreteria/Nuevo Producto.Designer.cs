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
            this.boton_guardar = new System.Windows.Forms.Button();
            this.txt_descProv = new System.Windows.Forms.TextBox();
            this.txt_precioProveedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.boton_limpiar = new System.Windows.Forms.Button();
            this.txt_StockMin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(77, 184);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(146, 27);
            this.txt_codigo.TabIndex = 0;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(304, 184);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(176, 27);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(552, 184);
            this.txt_marca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(142, 27);
            this.txt_marca.TabIndex = 2;
            this.txt_marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_marca_KeyPress);
            this.txt_marca.Leave += new System.EventHandler(this.txt_marca_Leave);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(1001, 184);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(252, 193);
            this.txt_desc.TabIndex = 4;
            this.txt_desc.Text = "ALJSBDSKSKS555AAsddd";
            this.txt_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desc_KeyPress);
            // 
            // cmb_cat
            // 
            this.cmb_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cat.FormattingEnabled = true;
            this.cmb_cat.Location = new System.Drawing.Point(759, 184);
            this.cmb_cat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_cat.Name = "cmb_cat";
            this.cmb_cat.Size = new System.Drawing.Size(151, 28);
            this.cmb_cat.TabIndex = 3;
            this.cmb_cat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_cat_KeyPress);
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(442, 447);
            this.txt_costo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(94, 27);
            this.txt_costo.TabIndex = 7;
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo_KeyPress);
            this.txt_costo.Leave += new System.EventHandler(this.txt_costo_Leave);
            // 
            // txt_porc
            // 
            this.txt_porc.Location = new System.Drawing.Point(646, 446);
            this.txt_porc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_porc.Name = "txt_porc";
            this.txt_porc.Size = new System.Drawing.Size(58, 27);
            this.txt_porc.TabIndex = 8;
            this.txt_porc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_porc_KeyPress);
            this.txt_porc.Leave += new System.EventHandler(this.txt_porc_Leave);
            // 
            // txt_preciof
            // 
            this.txt_preciof.Location = new System.Drawing.Point(838, 447);
            this.txt_preciof.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_preciof.Name = "txt_preciof";
            this.txt_preciof.Size = new System.Drawing.Size(124, 27);
            this.txt_preciof.TabIndex = 9;
            this.txt_preciof.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_preciof_KeyPress);
            this.txt_preciof.Leave += new System.EventHandler(this.txt_preciof_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1075, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(803, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Costo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Porcentaje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(848, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Precio final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nuevo producto id: ";
            // 
            // label_nuevoId
            // 
            this.label_nuevoId.AutoSize = true;
            this.label_nuevoId.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nuevoId.Location = new System.Drawing.Point(360, 64);
            this.label_nuevoId.Name = "label_nuevoId";
            this.label_nuevoId.Size = new System.Drawing.Size(40, 27);
            this.label_nuevoId.TabIndex = 17;
            this.label_nuevoId.Text = "id";
            // 
            // boton_guardar
            // 
            this.boton_guardar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.boton_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_guardar.Location = new System.Drawing.Point(1014, 570);
            this.boton_guardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(258, 182);
            this.boton_guardar.TabIndex = 11;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = false;
            this.boton_guardar.Click += new System.EventHandler(this.boton_guardar_Click);
            // 
            // txt_descProv
            // 
            this.txt_descProv.Location = new System.Drawing.Point(308, 446);
            this.txt_descProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_descProv.Name = "txt_descProv";
            this.txt_descProv.Size = new System.Drawing.Size(42, 27);
            this.txt_descProv.TabIndex = 6;
            this.txt_descProv.Text = "0";
            this.txt_descProv.TextChanged += new System.EventHandler(this.txt_descProv_TextChanged);
            this.txt_descProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descProv_KeyPress);
            this.txt_descProv.Leave += new System.EventHandler(this.txt_descProv_Leave);
            // 
            // txt_precioProveedor
            // 
            this.txt_precioProveedor.Location = new System.Drawing.Point(78, 446);
            this.txt_precioProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_precioProveedor.Name = "txt_precioProveedor";
            this.txt_precioProveedor.Size = new System.Drawing.Size(124, 27);
            this.txt_precioProveedor.TabIndex = 5;
            this.txt_precioProveedor.Text = "0";
            this.txt_precioProveedor.TextChanged += new System.EventHandler(this.txt_precioProveedor_TextChanged);
            this.txt_precioProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioProveedor_KeyPress);
            this.txt_precioProveedor.Leave += new System.EventHandler(this.txt_precioProveedor_Leave);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(77, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 51);
            this.label10.TabIndex = 21;
            this.label10.Text = "Precio de Lista de proveedor";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(262, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 53);
            this.label11.TabIndex = 22;
            this.label11.Text = "Descuento sobre\r\nprecio de lista %\r\n";
            // 
            // boton_limpiar
            // 
            this.boton_limpiar.Location = new System.Drawing.Point(240, 634);
            this.boton_limpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boton_limpiar.Name = "boton_limpiar";
            this.boton_limpiar.Size = new System.Drawing.Size(189, 54);
            this.boton_limpiar.TabIndex = 23;
            this.boton_limpiar.Text = "Limpiar";
            this.boton_limpiar.UseVisualStyleBackColor = true;
            this.boton_limpiar.Click += new System.EventHandler(this.boton_limpiar_Click);
            // 
            // txt_StockMin
            // 
            this.txt_StockMin.Location = new System.Drawing.Point(1093, 448);
            this.txt_StockMin.Name = "txt_StockMin";
            this.txt_StockMin.Size = new System.Drawing.Size(45, 27);
            this.txt_StockMin.TabIndex = 10;
            this.txt_StockMin.TextChanged += new System.EventHandler(this.txt_StockMin_TextChanged);
            this.txt_StockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StockMin_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1064, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Stock mínimo";
            // 
            // agregarNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1603, 787);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_StockMin);
            this.Controls.Add(this.boton_limpiar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_precioProveedor);
            this.Controls.Add(this.txt_descProv);
            this.Controls.Add(this.boton_guardar);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.TextBox txt_descProv;
        private System.Windows.Forms.TextBox txt_precioProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button boton_limpiar;
        private System.Windows.Forms.TextBox txt_StockMin;
        private System.Windows.Forms.Label label12;
    }
}