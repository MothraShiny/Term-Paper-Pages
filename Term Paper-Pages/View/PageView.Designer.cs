namespace Term_Paper_Pages.View
{
    partial class PageView
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
            label1 = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            tabControl1 = new TabControl();
            tabPagePetList = new TabPage();
            buttonResetSearch = new Button();
            numericUpDownLettersCountMoreThan = new NumericUpDown();
            label11 = new Label();
            buttonSearchLettersCountMoreThan = new Button();
            label12 = new Label();
            labelAverageLettersCount = new Label();
            dataGridView = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            tabPagePetDetail = new TabPage();
            label10 = new Label();
            numericUpDownNumberOfLines = new NumericUpDown();
            label9 = new Label();
            numericUpDownPageNumber = new NumericUpDown();
            label8 = new Label();
            numericUpDownNumberOfParagraphs = new NumericUpDown();
            label6 = new Label();
            numericUpDownFontSize = new NumericUpDown();
            label5 = new Label();
            numericUpDownNumberOfСonsonants = new NumericUpDown();
            label4 = new Label();
            numericUpDownNumberOfVowels = new NumericUpDown();
            label7 = new Label();
            numericUpDownNumberOfLetters = new NumericUpDown();
            btnCancel = new Button();
            btnSave = new Button();
            label3 = new Label();
            txtPageId = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLettersCountMoreThan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabPagePetDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfLines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPageNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfParagraphs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfСonsonants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfVowels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfLetters).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 29);
            label1.TabIndex = 0;
            label1.Text = "СТРАНИЦЫ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 56);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(851, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 30);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePetList);
            tabControl1.Controls.Add(tabPagePetDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 56);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(892, 411);
            tabControl1.TabIndex = 2;
            // 
            // tabPagePetList
            // 
            tabPagePetList.Controls.Add(buttonResetSearch);
            tabPagePetList.Controls.Add(numericUpDownLettersCountMoreThan);
            tabPagePetList.Controls.Add(label11);
            tabPagePetList.Controls.Add(buttonSearchLettersCountMoreThan);
            tabPagePetList.Controls.Add(label12);
            tabPagePetList.Controls.Add(labelAverageLettersCount);
            tabPagePetList.Controls.Add(dataGridView);
            tabPagePetList.Controls.Add(btnDelete);
            tabPagePetList.Controls.Add(btnEdit);
            tabPagePetList.Controls.Add(btnAddNew);
            tabPagePetList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPagePetList.Location = new Point(4, 34);
            tabPagePetList.Name = "tabPagePetList";
            tabPagePetList.Padding = new Padding(3);
            tabPagePetList.Size = new Size(884, 373);
            tabPagePetList.TabIndex = 0;
            tabPagePetList.Text = "Список страниц";
            tabPagePetList.UseVisualStyleBackColor = true;
            // 
            // buttonResetSearch
            // 
            buttonResetSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonResetSearch.Location = new Point(614, 31);
            buttonResetSearch.Name = "buttonResetSearch";
            buttonResetSearch.Size = new Size(123, 30);
            buttonResetSearch.TabIndex = 13;
            buttonResetSearch.Text = "Сбросить";
            buttonResetSearch.UseVisualStyleBackColor = true;
            // 
            // numericUpDownLettersCountMoreThan
            // 
            numericUpDownLettersCountMoreThan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownLettersCountMoreThan.Location = new Point(352, 31);
            numericUpDownLettersCountMoreThan.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownLettersCountMoreThan.Name = "numericUpDownLettersCountMoreThan";
            numericUpDownLettersCountMoreThan.Size = new Size(150, 30);
            numericUpDownLettersCountMoreThan.TabIndex = 12;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(102, 33);
            label11.Name = "label11";
            label11.Size = new Size(244, 25);
            label11.TabIndex = 11;
            label11.Text = "Поиск (букв > заданного)";
            // 
            // buttonSearchLettersCountMoreThan
            // 
            buttonSearchLettersCountMoreThan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearchLettersCountMoreThan.Location = new Point(509, 31);
            buttonSearchLettersCountMoreThan.Name = "buttonSearchLettersCountMoreThan";
            buttonSearchLettersCountMoreThan.Size = new Size(99, 30);
            buttonSearchLettersCountMoreThan.TabIndex = 10;
            buttonSearchLettersCountMoreThan.Text = "Поиск";
            buttonSearchLettersCountMoreThan.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(24, 334);
            label12.Name = "label12";
            label12.Size = new Size(322, 25);
            label12.TabIndex = 9;
            label12.Text = "Среднее кол-во букв на странице";
            // 
            // labelAverageLettersCount
            // 
            labelAverageLettersCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelAverageLettersCount.AutoSize = true;
            labelAverageLettersCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAverageLettersCount.Location = new Point(352, 334);
            labelAverageLettersCount.Name = "labelAverageLettersCount";
            labelAverageLettersCount.Size = new Size(23, 25);
            labelAverageLettersCount.TabIndex = 8;
            labelAverageLettersCount.Text = "0";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.Gainsboro;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(24, 63);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(713, 268);
            dataGridView.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(743, 134);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(743, 98);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 30);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.Location = new Point(743, 62);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(123, 30);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Добавить";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // tabPagePetDetail
            // 
            tabPagePetDetail.Controls.Add(label10);
            tabPagePetDetail.Controls.Add(numericUpDownNumberOfLines);
            tabPagePetDetail.Controls.Add(label9);
            tabPagePetDetail.Controls.Add(numericUpDownPageNumber);
            tabPagePetDetail.Controls.Add(label8);
            tabPagePetDetail.Controls.Add(numericUpDownNumberOfParagraphs);
            tabPagePetDetail.Controls.Add(label6);
            tabPagePetDetail.Controls.Add(numericUpDownFontSize);
            tabPagePetDetail.Controls.Add(label5);
            tabPagePetDetail.Controls.Add(numericUpDownNumberOfСonsonants);
            tabPagePetDetail.Controls.Add(label4);
            tabPagePetDetail.Controls.Add(numericUpDownNumberOfVowels);
            tabPagePetDetail.Controls.Add(label7);
            tabPagePetDetail.Controls.Add(numericUpDownNumberOfLetters);
            tabPagePetDetail.Controls.Add(btnCancel);
            tabPagePetDetail.Controls.Add(btnSave);
            tabPagePetDetail.Controls.Add(label3);
            tabPagePetDetail.Controls.Add(txtPageId);
            tabPagePetDetail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPagePetDetail.Location = new Point(4, 29);
            tabPagePetDetail.Name = "tabPagePetDetail";
            tabPagePetDetail.Padding = new Padding(3);
            tabPagePetDetail.Size = new Size(884, 378);
            tabPagePetDetail.TabIndex = 1;
            tabPagePetDetail.Text = "Страница подробно";
            tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(482, 214);
            label10.Name = "label10";
            label10.Size = new Size(128, 25);
            label10.TabIndex = 29;
            label10.Text = "Число строк";
            // 
            // numericUpDownNumberOfLines
            // 
            numericUpDownNumberOfLines.Location = new Point(482, 242);
            numericUpDownNumberOfLines.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownNumberOfLines.Name = "numericUpDownNumberOfLines";
            numericUpDownNumberOfLines.Size = new Size(168, 34);
            numericUpDownNumberOfLines.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(270, 214);
            label9.Name = "label9";
            label9.Size = new Size(171, 25);
            label9.TabIndex = 27;
            label9.Text = "Номер страницы";
            // 
            // numericUpDownPageNumber
            // 
            numericUpDownPageNumber.Location = new Point(270, 242);
            numericUpDownPageNumber.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownPageNumber.Name = "numericUpDownPageNumber";
            numericUpDownPageNumber.Size = new Size(168, 34);
            numericUpDownPageNumber.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(63, 214);
            label8.Name = "label8";
            label8.Size = new Size(155, 25);
            label8.TabIndex = 25;
            label8.Text = "Кол-во абзацев";
            // 
            // numericUpDownNumberOfParagraphs
            // 
            numericUpDownNumberOfParagraphs.Location = new Point(63, 242);
            numericUpDownNumberOfParagraphs.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownNumberOfParagraphs.Name = "numericUpDownNumberOfParagraphs";
            numericUpDownNumberOfParagraphs.Size = new Size(168, 34);
            numericUpDownNumberOfParagraphs.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(697, 115);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 23;
            label6.Text = "Размер шрифта";
            // 
            // numericUpDownFontSize
            // 
            numericUpDownFontSize.Location = new Point(697, 143);
            numericUpDownFontSize.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownFontSize.Name = "numericUpDownFontSize";
            numericUpDownFontSize.Size = new Size(168, 34);
            numericUpDownFontSize.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(482, 115);
            label5.Name = "label5";
            label5.Size = new Size(176, 25);
            label5.TabIndex = 21;
            label5.Text = "Кол-во согласных";
            // 
            // numericUpDownNumberOfСonsonants
            // 
            numericUpDownNumberOfСonsonants.Location = new Point(482, 143);
            numericUpDownNumberOfСonsonants.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownNumberOfСonsonants.Name = "numericUpDownNumberOfСonsonants";
            numericUpDownNumberOfСonsonants.Size = new Size(168, 34);
            numericUpDownNumberOfСonsonants.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(270, 115);
            label4.Name = "label4";
            label4.Size = new Size(155, 25);
            label4.TabIndex = 19;
            label4.Text = "Кол-во гласных";
            // 
            // numericUpDownNumberOfVowels
            // 
            numericUpDownNumberOfVowels.Location = new Point(270, 143);
            numericUpDownNumberOfVowels.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownNumberOfVowels.Name = "numericUpDownNumberOfVowels";
            numericUpDownNumberOfVowels.Size = new Size(168, 34);
            numericUpDownNumberOfVowels.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(63, 115);
            label7.Name = "label7";
            label7.Size = new Size(120, 25);
            label7.TabIndex = 17;
            label7.Text = "Кол-во букв";
            // 
            // numericUpDownNumberOfLetters
            // 
            numericUpDownNumberOfLetters.Location = new Point(63, 143);
            numericUpDownNumberOfLetters.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownNumberOfLetters.Name = "numericUpDownNumberOfLetters";
            numericUpDownNumberOfLetters.Size = new Size(168, 34);
            numericUpDownNumberOfLetters.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(258, 323);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 44);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(61, 323);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 44);
            btnSave.TabIndex = 14;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 26);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 7;
            label3.Text = "Страница ID:";
            // 
            // txtPageId
            // 
            txtPageId.Location = new Point(63, 54);
            txtPageId.Name = "txtPageId";
            txtPageId.ReadOnly = true;
            txtPageId.Size = new Size(154, 34);
            txtPageId.TabIndex = 6;
            txtPageId.Text = "0";
            // 
            // PageView
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 467);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PageView";
            Text = "Страница";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPagePetList.ResumeLayout(false);
            tabPagePetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLettersCountMoreThan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabPagePetDetail.ResumeLayout(false);
            tabPagePetDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfLines).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPageNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfParagraphs).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfСonsonants).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfVowels).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfLetters).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePetList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TabPage tabPagePetDetail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPageId;
        private System.Windows.Forms.Button btnClose;
        private NumericUpDown numericUpDownNumberOfLetters;
        private Label label7;
        private NumericUpDown numericUpDownNumberOfVowels;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownNumberOfСonsonants;
        private NumericUpDown numericUpDownFontSize;
        private Label label6;
        private Label label8;
        private NumericUpDown numericUpDownNumberOfParagraphs;
        private Label label9;
        private NumericUpDown numericUpDownPageNumber;
        private Label label10;
        private NumericUpDown numericUpDownNumberOfLines;
        private Label label12;
        private Label labelAverageLettersCount;
        private NumericUpDown numericUpDownLettersCountMoreThan;
        private Label label11;
        private Button buttonSearchLettersCountMoreThan;
        private Button buttonResetSearch;
    }
}