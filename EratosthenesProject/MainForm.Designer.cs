
namespace EratosthenesProject
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sieveGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.answerRichTextBox = new System.Windows.Forms.RichTextBox();
            this.numbersButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sieveGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nUpDown
            // 
            this.nUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUpDown.Location = new System.Drawing.Point(87, 12);
            this.nUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(120, 38);
            this.nUpDown.TabIndex = 0;
            this.nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "N =";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sieveGridView);
            this.groupBox1.Location = new System.Drawing.Point(19, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(475, 382);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Решето Эратосфена";
            // 
            // sieveGridView
            // 
            this.sieveGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sieveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sieveGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.sieveGridView.EnableHeadersVisualStyles = false;
            this.sieveGridView.Location = new System.Drawing.Point(5, 21);
            this.sieveGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sieveGridView.Name = "sieveGridView";
            this.sieveGridView.RowHeadersWidth = 51;
            this.sieveGridView.RowTemplate.Height = 24;
            this.sieveGridView.Size = new System.Drawing.Size(460, 354);
            this.sieveGridView.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(500, 353);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(292, 79);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить ответ...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // answerRichTextBox
            // 
            this.answerRichTextBox.Location = new System.Drawing.Point(500, 78);
            this.answerRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerRichTextBox.Name = "answerRichTextBox";
            this.answerRichTextBox.Size = new System.Drawing.Size(292, 270);
            this.answerRichTextBox.TabIndex = 1;
            this.answerRichTextBox.Text = "";
            // 
            // numbersButton
            // 
            this.numbersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numbersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numbersButton.Location = new System.Drawing.Point(213, 12);
            this.numbersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numbersButton.Name = "numbersButton";
            this.numbersButton.Size = new System.Drawing.Size(272, 38);
            this.numbersButton.TabIndex = 3;
            this.numbersButton.Text = "Найти первые N простых чисел";
            this.numbersButton.UseVisualStyleBackColor = true;
            this.numbersButton.Click += new System.EventHandler(this.numbersButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutButton.Location = new System.Drawing.Point(491, 14);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(299, 38);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "О программе";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.answerRichTextBox);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.numbersButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUpDown);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск простых чисел";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sieveGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView sieveGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox answerRichTextBox;
        private System.Windows.Forms.Button numbersButton;
        private System.Windows.Forms.Button aboutButton;
    }
}