
namespace EnglishTyping
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.typing = new System.Windows.Forms.RichTextBox();
            this.listBox_suggestion = new System.Windows.Forms.ListBox();
            this.listbox_synonym = new System.Windows.Forms.ListBox();
            this.listBox_suggestionStartWith = new System.Windows.Forms.ListBox();
            this.listBox_suggestionContain = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // typing
            // 
            this.typing.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typing.Location = new System.Drawing.Point(249, 239);
            this.typing.Name = "typing";
            this.typing.Size = new System.Drawing.Size(575, 152);
            this.typing.TabIndex = 0;
            this.typing.Text = "";
            this.typing.TextChanged += new System.EventHandler(this.typing_TextChanged);
            // 
            // listBox_suggestion
            // 
            this.listBox_suggestion.FormattingEnabled = true;
            this.listBox_suggestion.ItemHeight = 12;
            this.listBox_suggestion.Location = new System.Drawing.Point(534, 431);
            this.listBox_suggestion.Name = "listBox_suggestion";
            this.listBox_suggestion.Size = new System.Drawing.Size(135, 352);
            this.listBox_suggestion.TabIndex = 1;
            this.listBox_suggestion.SelectedIndexChanged += new System.EventHandler(this.listBox_suggestion_SelectedIndexChanged);
            // 
            // listbox_synonym
            // 
            this.listbox_synonym.FormattingEnabled = true;
            this.listbox_synonym.ItemHeight = 12;
            this.listbox_synonym.Location = new System.Drawing.Point(689, 431);
            this.listbox_synonym.Name = "listbox_synonym";
            this.listbox_synonym.Size = new System.Drawing.Size(135, 352);
            this.listbox_synonym.TabIndex = 2;
            // 
            // listBox_suggestionStartWith
            // 
            this.listBox_suggestionStartWith.FormattingEnabled = true;
            this.listBox_suggestionStartWith.ItemHeight = 12;
            this.listBox_suggestionStartWith.Location = new System.Drawing.Point(249, 431);
            this.listBox_suggestionStartWith.Name = "listBox_suggestionStartWith";
            this.listBox_suggestionStartWith.Size = new System.Drawing.Size(120, 352);
            this.listBox_suggestionStartWith.TabIndex = 3;
            this.listBox_suggestionStartWith.SelectedIndexChanged += new System.EventHandler(this.listBox_suggestionStartWith_SelectedIndexChanged);
            // 
            // listBox_suggestionContain
            // 
            this.listBox_suggestionContain.FormattingEnabled = true;
            this.listBox_suggestionContain.ItemHeight = 12;
            this.listBox_suggestionContain.Location = new System.Drawing.Point(390, 431);
            this.listBox_suggestionContain.Name = "listBox_suggestionContain";
            this.listBox_suggestionContain.Size = new System.Drawing.Size(120, 352);
            this.listBox_suggestionContain.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 810);
            this.Controls.Add(this.listBox_suggestionContain);
            this.Controls.Add(this.listBox_suggestionStartWith);
            this.Controls.Add(this.listbox_synonym);
            this.Controls.Add(this.listBox_suggestion);
            this.Controls.Add(this.typing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnglishTyping";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox typing;
        private System.Windows.Forms.ListBox listBox_suggestion;
        private System.Windows.Forms.ListBox listbox_synonym;
        private System.Windows.Forms.ListBox listBox_suggestionStartWith;
        private System.Windows.Forms.ListBox listBox_suggestionContain;
    }
}

