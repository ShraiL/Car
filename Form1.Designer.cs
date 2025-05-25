using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LashaMurgvaLominadzeShraieri.Final
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            modelBox = new TextBox();
            speedBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addBtn = new Button();
            listBox = new ListBox();
            deleteBtn = new Button();
            updateBtn = new Button();
            SuspendLayout();

            // modelBox
            modelBox.Location = new Point(14, 92);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(114, 27);
            modelBox.TabIndex = 0;

            // speedBox
            speedBox.Location = new Point(135, 92);
            speedBox.Name = "speedBox";
            speedBox.Size = new Size(114, 27);
            speedBox.TabIndex = 1;

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(14, 56);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "Car Model";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(135, 56);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 3;
            label2.Text = "Top Speed";

            // addBtn
            addBtn.Location = new Point(14, 168);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(86, 31);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addCar;

            // listBox
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(14, 308);
            listBox.Name = "listBox";
            listBox.Size = new Size(886, 264);
            listBox.TabIndex = 5;

            // deleteBtn
            deleteBtn.Location = new Point(135, 168);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(86, 31);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteCar;

            // updateBtn
            updateBtn.Location = new Point(245, 168);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(listBox);
            Controls.Add(addBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(speedBox);
            Controls.Add(modelBox);
            Name = "Form1";
            Text = "Car Registry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox modelBox;
        private TextBox speedBox;
        private Label label1;
        private Label label2;
        private Button addBtn;
        private ListBox listBox;
        private Button deleteBtn;
        private Button updateBtn;
    }
}
