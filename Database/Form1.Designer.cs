
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
            this.TableDataGridView = new System.Windows.Forms.DataGridView();
            this.SqlQueryTextBox = new System.Windows.Forms.TextBox();
            this.SqlQueryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableDataGridView
            // 
            this.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDataGridView.Location = new System.Drawing.Point(389, 12);
            this.TableDataGridView.Name = "TableDataGridView";
            this.TableDataGridView.Size = new System.Drawing.Size(464, 452);
            this.TableDataGridView.TabIndex = 0;
            // 
            // SqlQueryTextBox
            // 
            this.SqlQueryTextBox.Location = new System.Drawing.Point(12, 12);
            this.SqlQueryTextBox.Multiline = true;
            this.SqlQueryTextBox.Name = "SqlQueryTextBox";
            this.SqlQueryTextBox.Size = new System.Drawing.Size(371, 410);
            this.SqlQueryTextBox.TabIndex = 1;
            // 
            // SqlQueryButton
            // 
            this.SqlQueryButton.Location = new System.Drawing.Point(117, 440);
            this.SqlQueryButton.Name = "SqlQueryButton";
            this.SqlQueryButton.Size = new System.Drawing.Size(156, 24);
            this.SqlQueryButton.TabIndex = 2;
            this.SqlQueryButton.Text = "Запрос";
            this.SqlQueryButton.UseVisualStyleBackColor = true;
            this.SqlQueryButton.Click += new System.EventHandler(this.SqlQueryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 476);
            this.Controls.Add(this.SqlQueryButton);
            this.Controls.Add(this.SqlQueryTextBox);
            this.Controls.Add(this.TableDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TableDataGridView;
        private System.Windows.Forms.TextBox SqlQueryTextBox;
        private System.Windows.Forms.Button SqlQueryButton;
    }
}

