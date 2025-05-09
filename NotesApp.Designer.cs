namespace NotesApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            TextMessage = new TextBox();
            TextTitle = new TextBox();
            dataGridView1 = new DataGridView();
            ButtonNew = new Button();
            ButtonSave = new Button();
            ButtonRead = new Button();
            ButtonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 47);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 136);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Message:";
            // 
            // TextMessage
            // 
            TextMessage.Location = new Point(150, 105);
            TextMessage.Multiline = true;
            TextMessage.Name = "TextMessage";
            TextMessage.Size = new Size(209, 174);
            TextMessage.TabIndex = 2;
            // 
            // TextTitle
            // 
            TextTitle.Location = new Point(150, 47);
            TextTitle.Name = "TextTitle";
            TextTitle.Size = new Size(100, 23);
            TextTitle.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(447, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(247, 235);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ButtonNew
            // 
            ButtonNew.Location = new Point(150, 331);
            ButtonNew.Name = "ButtonNew";
            ButtonNew.Size = new Size(75, 23);
            ButtonNew.TabIndex = 5;
            ButtonNew.Text = "New";
            ButtonNew.UseVisualStyleBackColor = true;
            ButtonNew.Click += ButtonNew_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(284, 331);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 23);
            ButtonSave.TabIndex = 6;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonRead
            // 
            ButtonRead.Location = new Point(447, 331);
            ButtonRead.Name = "ButtonRead";
            ButtonRead.Size = new Size(75, 23);
            ButtonRead.TabIndex = 7;
            ButtonRead.Text = "Read";
            ButtonRead.UseVisualStyleBackColor = true;
            ButtonRead.Click += ButtonRead_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(604, 331);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 8;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonRead);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonNew);
            Controls.Add(dataGridView1);
            Controls.Add(TextTitle);
            Controls.Add(TextMessage);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextMessage;
        private TextBox TextTitle;
        private DataGridView dataGridView1;
        private Button ButtonNew;
        private Button ButtonSave;
        private Button ButtonRead;
        private Button ButtonDelete;
    }
}
