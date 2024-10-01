namespace Term_Paper_Pages.View
{
    partial class MainView
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
            panel1 = new Panel();
            btnAboutBox = new Button();
            btnHandbook = new Button();
            btnPages = new Button();
            helpProvider1 = new HelpProvider();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAboutBox);
            panel1.Controls.Add(btnHandbook);
            panel1.Controls.Add(btnPages);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 869);
            panel1.TabIndex = 0;
            // 
            // btnAboutBox
            // 
            btnAboutBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAboutBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAboutBox.Location = new Point(4, 380);
            btnAboutBox.Margin = new Padding(4, 5, 4, 5);
            btnAboutBox.Name = "btnAboutBox";
            btnAboutBox.Size = new Size(263, 57);
            btnAboutBox.TabIndex = 2;
            btnAboutBox.Text = "О Программе";
            btnAboutBox.UseVisualStyleBackColor = true;
            // 
            // btnHandbook
            // 
            btnHandbook.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHandbook.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHandbook.Location = new Point(0, 447);
            btnHandbook.Margin = new Padding(4, 5, 4, 5);
            btnHandbook.Name = "btnHandbook";
            btnHandbook.Size = new Size(263, 57);
            btnHandbook.TabIndex = 1;
            btnHandbook.Text = "Справочник";
            btnHandbook.UseVisualStyleBackColor = true;
            // 
            // btnPages
            // 
            btnPages.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPages.Location = new Point(4, 83);
            btnPages.Margin = new Padding(4, 5, 4, 5);
            btnPages.Name = "btnPages";
            btnPages.Size = new Size(263, 57);
            btnPages.TabIndex = 0;
            btnPages.Text = "Страницы";
            btnPages.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1617, 869);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPages;
        private Button btnAboutBox;
        private Button btnHandbook;
        private HelpProvider helpProvider1;
    }
}