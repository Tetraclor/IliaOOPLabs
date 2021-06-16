
namespace Database
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.таблица1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Database.Database1DataSet();
            this.таблица1TableAdapter = new Database.Database1DataSetTableAdapters.Таблица1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодРайонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лесистостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.широтаРайонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.долготаРайонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.узлыСлеваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.узлыСправаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.таблица1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // таблица1BindingSource
            // 
            this.таблица1BindingSource.DataMember = "Таблица1";
            this.таблица1BindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.database1DataSet;
            this.bindingSource1.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблица1TableAdapter
            // 
            this.таблица1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодРайонаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.лесистостьDataGridViewTextBoxColumn,
            this.широтаРайонаDataGridViewTextBoxColumn,
            this.долготаРайонаDataGridViewTextBoxColumn,
            this.узлыСлеваDataGridViewTextBoxColumn,
            this.узлыСправаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.таблица1BindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодРайонаDataGridViewTextBoxColumn
            // 
            this.кодРайонаDataGridViewTextBoxColumn.DataPropertyName = "Код района";
            this.кодРайонаDataGridViewTextBoxColumn.HeaderText = "Код района";
            this.кодРайонаDataGridViewTextBoxColumn.Name = "кодРайонаDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // лесистостьDataGridViewTextBoxColumn
            // 
            this.лесистостьDataGridViewTextBoxColumn.DataPropertyName = "Лесистость";
            this.лесистостьDataGridViewTextBoxColumn.HeaderText = "Лесистость";
            this.лесистостьDataGridViewTextBoxColumn.Name = "лесистостьDataGridViewTextBoxColumn";
            // 
            // широтаРайонаDataGridViewTextBoxColumn
            // 
            this.широтаРайонаDataGridViewTextBoxColumn.DataPropertyName = "Широта района";
            this.широтаРайонаDataGridViewTextBoxColumn.HeaderText = "Широта района";
            this.широтаРайонаDataGridViewTextBoxColumn.Name = "широтаРайонаDataGridViewTextBoxColumn";
            // 
            // долготаРайонаDataGridViewTextBoxColumn
            // 
            this.долготаРайонаDataGridViewTextBoxColumn.DataPropertyName = "Долгота района";
            this.долготаРайонаDataGridViewTextBoxColumn.HeaderText = "Долгота района";
            this.долготаРайонаDataGridViewTextBoxColumn.Name = "долготаРайонаDataGridViewTextBoxColumn";
            // 
            // узлыСлеваDataGridViewTextBoxColumn
            // 
            this.узлыСлеваDataGridViewTextBoxColumn.DataPropertyName = "Узлы слева";
            this.узлыСлеваDataGridViewTextBoxColumn.HeaderText = "Узлы слева";
            this.узлыСлеваDataGridViewTextBoxColumn.Name = "узлыСлеваDataGridViewTextBoxColumn";
            // 
            // узлыСправаDataGridViewTextBoxColumn
            // 
            this.узлыСправаDataGridViewTextBoxColumn.DataPropertyName = "Узлы справа";
            this.узлыСправаDataGridViewTextBoxColumn.HeaderText = "Узлы справа";
            this.узлыСправаDataGridViewTextBoxColumn.Name = "узлыСправаDataGridViewTextBoxColumn";
            // 
            // таблица1BindingSource1
            // 
            this.таблица1BindingSource1.DataMember = "Таблица1";
            this.таблица1BindingSource1.DataSource = this.bindingSource1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource таблица1BindingSource;
        private Database1DataSetTableAdapters.Таблица1TableAdapter таблица1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРайонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn лесистостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn широтаРайонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn долготаРайонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn узлыСлеваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn узлыСправаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource таблица1BindingSource1;
    }
}

