using System.Windows.Forms;

namespace Ventas
{
    partial class Form1
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
            this.timeFinal = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPoducto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.txtIDreferencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timeInicio = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.comboBoxMinuto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // timeFinal
            // 
            this.timeFinal.ContextMenuStrip = this.contextMenuStrip1;
            this.timeFinal.CustomFormat = "yyyy-MM-dd HH:mm";
            this.timeFinal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFinal.Location = new System.Drawing.Point(911, 458);
            this.timeFinal.Name = "timeFinal";
            this.timeFinal.Size = new System.Drawing.Size(200, 22);
            this.timeFinal.TabIndex = 30;
            this.timeFinal.Value = new System.DateTime(2023, 2, 14, 0, 0, 0, 0);
            this.timeFinal.ValueChanged += new System.EventHandler(this.timeFinal_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPoducto
            // 
            this.txtPoducto.Location = new System.Drawing.Point(15, 50);
            this.txtPoducto.Name = "txtPoducto";
            this.txtPoducto.Size = new System.Drawing.Size(545, 20);
            this.txtPoducto.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 180);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producto";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(15, 95);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(545, 20);
            this.txtDetalles.TabIndex = 5;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(15, 144);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(137, 20);
            this.txtMonto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monto";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(177, 180);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(96, 180);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Monto";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(12, 307);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(137, 20);
            this.txtFecha.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Monto";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Monto";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 360);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 20);
            this.textBox4.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Monto";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(298, 360);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 20);
            this.textBox5.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Monto";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(298, 307);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(137, 20);
            this.textBox6.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Monto";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(155, 307);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(137, 20);
            this.textBox7.TabIndex = 21;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(485, 180);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(582, 13);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.ReadOnly = true;
            this.dataGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProductos.Size = new System.Drawing.Size(529, 425);
            this.dataGridProductos.TabIndex = 24;
            this.dataGridProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductos_CellClick);
            // 
            // txtIDreferencia
            // 
            this.txtIDreferencia.Location = new System.Drawing.Point(423, 144);
            this.txtIDreferencia.Name = "txtIDreferencia";
            this.txtIDreferencia.ReadOnly = true;
            this.txtIDreferencia.Size = new System.Drawing.Size(137, 20);
            this.txtIDreferencia.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "ID Referencia";
            // 
            // timeInicio
            // 
            this.timeInicio.CustomFormat = "";
            this.timeInicio.Location = new System.Drawing.Point(582, 458);
            this.timeInicio.Name = "timeInicio";
            this.timeInicio.Size = new System.Drawing.Size(200, 20);
            this.timeInicio.TabIndex = 29;
            this.timeInicio.ValueChanged += new System.EventHandler(this.timeInicio_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(579, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Desde";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(908, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Hasta";
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "23",
            "00"});
            this.comboBoxHora.Location = new System.Drawing.Point(286, 181);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(36, 21);
            this.comboBoxHora.TabIndex = 33;
            // 
            // comboBoxMinuto
            // 
            this.comboBoxMinuto.FormattingEnabled = true;
            this.comboBoxMinuto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "00"});
            this.comboBoxMinuto.Location = new System.Drawing.Point(319, 181);
            this.comboBoxMinuto.Name = "comboBoxMinuto";
            this.comboBoxMinuto.Size = new System.Drawing.Size(36, 21);
            this.comboBoxMinuto.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 490);
            this.Controls.Add(this.comboBoxMinuto);
            this.Controls.Add(this.comboBoxHora);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.timeFinal);
            this.Controls.Add(this.timeInicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIDreferencia);
            this.Controls.Add(this.dataGridProductos);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPoducto);
            this.Name = "Form1";
            this.Text = "Inventario de Productos Centro de internet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPoducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.TextBox txtIDreferencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker timeInicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker timeFinal;
        private ComboBox comboBoxHora;
        private ComboBox comboBoxMinuto;

        public DateTimePicker TimeInicio { get => timeInicio; set => timeInicio = value; }
        public DateTimePicker TimeFinal { get => timeFinal; set => timeFinal = value; }
    }
}

