
namespace WindowsDefenderExclusionsEditor
{
    partial class AppForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deletePathButton = new System.Windows.Forms.Button();
            this.exclusionPathList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteProcessButton = new System.Windows.Forms.Button();
            this.exclusionProcessList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteExtensionButton = new System.Windows.Forms.Button();
            this.exclusionExtensionList = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deletePathButton);
            this.tabPage1.Controls.Add(this.exclusionPathList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paths";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deletePathButton
            // 
            this.deletePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePathButton.AutoSize = true;
            this.deletePathButton.Location = new System.Drawing.Point(657, 393);
            this.deletePathButton.Name = "deletePathButton";
            this.deletePathButton.Size = new System.Drawing.Size(127, 23);
            this.deletePathButton.TabIndex = 2;
            this.deletePathButton.Text = "Delete selected";
            this.deletePathButton.UseVisualStyleBackColor = true;
            this.deletePathButton.Click += new System.EventHandler(this.deletePathButton_Click);
            // 
            // exclusionPathList
            // 
            this.exclusionPathList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exclusionPathList.FormattingEnabled = true;
            this.exclusionPathList.Location = new System.Drawing.Point(8, 8);
            this.exclusionPathList.Name = "exclusionPathList";
            this.exclusionPathList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.exclusionPathList.Size = new System.Drawing.Size(776, 368);
            this.exclusionPathList.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteProcessButton);
            this.tabPage2.Controls.Add(this.exclusionProcessList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Processes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteProcessButton
            // 
            this.deleteProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProcessButton.AutoSize = true;
            this.deleteProcessButton.Location = new System.Drawing.Point(657, 393);
            this.deleteProcessButton.Name = "deleteProcessButton";
            this.deleteProcessButton.Size = new System.Drawing.Size(127, 23);
            this.deleteProcessButton.TabIndex = 3;
            this.deleteProcessButton.Text = "Delete selected";
            this.deleteProcessButton.UseVisualStyleBackColor = true;
            this.deleteProcessButton.Click += new System.EventHandler(this.deleteProcessButton_Click);
            // 
            // exclusionProcessList
            // 
            this.exclusionProcessList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exclusionProcessList.FormattingEnabled = true;
            this.exclusionProcessList.Location = new System.Drawing.Point(8, 8);
            this.exclusionProcessList.Name = "exclusionProcessList";
            this.exclusionProcessList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.exclusionProcessList.Size = new System.Drawing.Size(776, 368);
            this.exclusionProcessList.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteExtensionButton);
            this.tabPage3.Controls.Add(this.exclusionExtensionList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Extensions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteExtensionButton
            // 
            this.deleteExtensionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteExtensionButton.AutoSize = true;
            this.deleteExtensionButton.Location = new System.Drawing.Point(657, 393);
            this.deleteExtensionButton.Name = "deleteExtensionButton";
            this.deleteExtensionButton.Size = new System.Drawing.Size(127, 23);
            this.deleteExtensionButton.TabIndex = 3;
            this.deleteExtensionButton.Text = "Delete selected";
            this.deleteExtensionButton.UseVisualStyleBackColor = true;
            this.deleteExtensionButton.Click += new System.EventHandler(this.deleteExtensionButton_Click);
            // 
            // exclusionExtensionList
            // 
            this.exclusionExtensionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exclusionExtensionList.FormattingEnabled = true;
            this.exclusionExtensionList.Location = new System.Drawing.Point(8, 8);
            this.exclusionExtensionList.Name = "exclusionExtensionList";
            this.exclusionExtensionList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.exclusionExtensionList.Size = new System.Drawing.Size(776, 368);
            this.exclusionExtensionList.TabIndex = 2;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AppForm";
            this.Text = "Windows Defender Exclusions Editor";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox exclusionPathList;
        private System.Windows.Forms.ListBox exclusionProcessList;
        private System.Windows.Forms.ListBox exclusionExtensionList;
        private System.Windows.Forms.Button deletePathButton;
        private System.Windows.Forms.Button deleteProcessButton;
        private System.Windows.Forms.Button deleteExtensionButton;
    }
}

