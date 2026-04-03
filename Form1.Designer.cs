namespace Console_App
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            txt_2 = new Button();
            dataGridView1 = new DataGridView();
            Open = new DataGridViewTextBoxColumn();
            Pending = new DataGridViewTextBoxColumn();
            Resolve = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            button1 = new Button();
            txt_3 = new Button();
            txt_4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(459, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // txt_2
            // 
            txt_2.Location = new Point(238, 409);
            txt_2.Name = "txt_2";
            txt_2.Size = new Size(152, 29);
            txt_2.TabIndex = 2;
            txt_2.Text = "Save Ticket";
            txt_2.UseVisualStyleBackColor = true;
            txt_2.Click += txt_2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Open, Pending, Resolve, Data });
            dataGridView1.Location = new Point(55, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(529, 245);
            dataGridView1.TabIndex = 3;
            // 
            // Open
            // 
            Open.HeaderText = "Name";
            Open.MinimumWidth = 6;
            Open.Name = "Open";
            Open.Width = 125;
            // 
            // Pending
            // 
            Pending.HeaderText = "Issue";
            Pending.MinimumWidth = 6;
            Pending.Name = "Pending";
            Pending.Width = 125;
            // 
            // Resolve
            // 
            Resolve.HeaderText = "Status";
            Resolve.MinimumWidth = 6;
            Resolve.Name = "Resolve";
            Resolve.Width = 125;
            // 
            // Data
            // 
            Data.HeaderText = "Date";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            Data.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(611, 51);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 4;
            button1.Text = "Customer Name";
            button1.UseVisualStyleBackColor = true;
            // 
            // txt_3
            // 
            txt_3.Location = new Point(207, 53);
            txt_3.Name = "txt_3";
            txt_3.Size = new Size(152, 29);
            txt_3.TabIndex = 5;
            txt_3.Text = "Ticket Status";
            txt_3.UseVisualStyleBackColor = true;
            // 
            // txt_4
            // 
            txt_4.Location = new Point(611, 192);
            txt_4.Name = "txt_4";
            txt_4.Size = new Size(152, 29);
            txt_4.TabIndex = 6;
            txt_4.Text = "Current Ticket List";
            txt_4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_4);
            Controls.Add(txt_3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txt_2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Secure Help Desk";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button txt_2;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Open;
        private DataGridViewTextBoxColumn Pending;
        private DataGridViewTextBoxColumn Resolve;
        private DataGridViewTextBoxColumn Data;
        private Button txt_3;
        private Button txt_4;
    }
}
