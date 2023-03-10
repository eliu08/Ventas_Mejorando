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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.txtIDreferencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timeInicio = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxMinutoInicio = new System.Windows.Forms.ComboBox();
            this.comboBoxHoraInicio = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxMinutoFinal = new System.Windows.Forms.ComboBox();
            this.comboBoxHoraFinal = new System.Windows.Forms.ComboBox();
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
            this.timeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeFinal.Location = new System.Drawing.Point(1004, 458);
            this.timeFinal.Name = "timeFinal";
            this.timeFinal.Size = new System.Drawing.Size(94, 22);
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
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(485, 180);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(582, 13);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.ReadOnly = true;
            this.dataGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProductos.Size = new System.Drawing.Size(604, 425);
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
            this.timeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeInicio.Location = new System.Drawing.Point(582, 458);
            this.timeInicio.Name = "timeInicio";
            this.timeInicio.Size = new System.Drawing.Size(102, 20);
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
            this.label12.Location = new System.Drawing.Point(1001, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Hasta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(687, 441);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Hora : Minutos";
            // 
            // comboBoxMinutoInicio
            // 
            this.comboBoxMinutoInicio.FormattingEnabled = true;
            this.comboBoxMinutoInicio.Items.AddRange(new object[] {
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
            this.comboBoxMinutoInicio.Location = new System.Drawing.Point(723, 457);
            this.comboBoxMinutoInicio.Name = "comboBoxMinutoInicio";
            this.comboBoxMinutoInicio.Size = new System.Drawing.Size(36, 21);
            this.comboBoxMinutoInicio.TabIndex = 37;
            this.comboBoxMinutoInicio.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinutoInicio_SelectedValueChanged);
            // 
            // comboBoxHoraInicio
            // 
            this.comboBoxHoraInicio.FormattingEnabled = true;
            this.comboBoxHoraInicio.Items.AddRange(new object[] {
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
            this.comboBoxHoraInicio.Location = new System.Drawing.Point(690, 457);
            this.comboBoxHoraInicio.Name = "comboBoxHoraInicio";
            this.comboBoxHoraInicio.Size = new System.Drawing.Size(36, 21);
            this.comboBoxHoraInicio.TabIndex = 36;
            this.comboBoxHoraInicio.SelectedValueChanged += new System.EventHandler(this.comboBoxHoraInicio_SelectedValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1101, 442);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Hora : Minutos";
            // 
            // comboBoxMinutoFinal
            // 
            this.comboBoxMinutoFinal.FormattingEnabled = true;
            this.comboBoxMinutoFinal.Items.AddRange(new object[] {
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
            this.comboBoxMinutoFinal.Location = new System.Drawing.Point(1137, 458);
            this.comboBoxMinutoFinal.Name = "comboBoxMinutoFinal";
            this.comboBoxMinutoFinal.Size = new System.Drawing.Size(36, 21);
            this.comboBoxMinutoFinal.TabIndex = 40;
            this.comboBoxMinutoFinal.SelectedValueChanged += new System.EventHandler(this.comboBoxMinutoFinal_SelectedValueChanged);
            // 
            // comboBoxHoraFinal
            // 
            this.comboBoxHoraFinal.FormattingEnabled = true;
            this.comboBoxHoraFinal.Items.AddRange(new object[] {
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
            this.comboBoxHoraFinal.Location = new System.Drawing.Point(1104, 458);
            this.comboBoxHoraFinal.Name = "comboBoxHoraFinal";
            this.comboBoxHoraFinal.Size = new System.Drawing.Size(36, 21);
            this.comboBoxHoraFinal.TabIndex = 39;
            this.comboBoxHoraFinal.SelectedValueChanged += new System.EventHandler(this.comboBoxHoraFinal_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 490);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxMinutoFinal);
            this.Controls.Add(this.comboBoxHoraFinal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxMinutoInicio);
            this.Controls.Add(this.comboBoxHoraInicio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.timeFinal);
            this.Controls.Add(this.timeInicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIDreferencia);
            this.Controls.Add(this.dataGridProductos);
            this.Controls.Add(this.btnRefresh);
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxMinutoInicio;
        private System.Windows.Forms.ComboBox comboBoxHoraInicio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxMinutoFinal;
        private System.Windows.Forms.ComboBox comboBoxHoraFinal;

        public DateTimePicker TimeInicio { get => timeInicio; set => timeInicio = value; }
        public DateTimePicker TimeFinal { get => timeFinal; set => timeFinal = value; }
        public DataGridView DataGridProductos { get => dataGridProductos; set => dataGridProductos = value; }
    }
}

