
namespace SPP1_GUI
{
     /*partial class Form1
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(135, 174);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

         }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
    }*/

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChooseInpt = new System.Windows.Forms.Button();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChooseOutpt = new System.Windows.Forms.Button();
            this.outputAddress = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSort = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChooseInpt);
            this.groupBox1.Controls.Add(this.inputAddress);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(400, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input file address";
            // 
            // btnChooseInpt
            // 
            this.btnChooseInpt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChooseInpt.Location = new System.Drawing.Point(363, 19);
            this.btnChooseInpt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChooseInpt.Name = "btnChooseInpt";
            this.btnChooseInpt.Size = new System.Drawing.Size(33, 32);
            this.btnChooseInpt.TabIndex = 1;
            this.btnChooseInpt.Text = "...";
            this.btnChooseInpt.UseVisualStyleBackColor = true;
            this.btnChooseInpt.Click += new System.EventHandler(this.BtnChooseInpt_Click);
            // 
            // inputAddress
            // 
            this.inputAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputAddress.Location = new System.Drawing.Point(4, 19);
            this.inputAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(392, 23);
            this.inputAddress.TabIndex = 0;
            this.inputAddress.TextChanged += new System.EventHandler(this.inputAddress_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChooseOutpt);
            this.groupBox2.Controls.Add(this.outputAddress);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(400, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output file address";
            // 
            // btnChooseOutpt
            // 
            this.btnChooseOutpt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChooseOutpt.Location = new System.Drawing.Point(363, 19);
            this.btnChooseOutpt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChooseOutpt.Name = "btnChooseOutpt";
            this.btnChooseOutpt.Size = new System.Drawing.Size(33, 32);
            this.btnChooseOutpt.TabIndex = 1;
            this.btnChooseOutpt.Text = "...";
            this.btnChooseOutpt.UseVisualStyleBackColor = true;
            this.btnChooseOutpt.Click += new System.EventHandler(this.BtnChooseOutpt_Click);
            // 
            // outputAddress
            // 
            this.outputAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputAddress.Location = new System.Drawing.Point(4, 19);
            this.outputAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outputAddress.Name = "outputAddress";
            this.outputAddress.Size = new System.Drawing.Size(392, 23);
            this.outputAddress.TabIndex = 0;
            this.outputAddress.TextChanged += new System.EventHandler(this.outputAddress_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSort, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 159);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSort.Location = new System.Drawing.Point(4, 123);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(400, 33);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 159);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseInpt;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChooseOutpt;
        private System.Windows.Forms.TextBox outputAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

