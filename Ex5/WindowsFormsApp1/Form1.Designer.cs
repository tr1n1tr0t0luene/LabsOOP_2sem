using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _1
{

    public class Form1 : Form
    {

        private Button btnBackGrColor;
        private Button btnHello;
        private Button btnOpacity;
        private Button btnSetOfActions;
        private CheckBox chBoxBackGrCol;
        private CheckBox chBoxHello;
        private CheckBox chBoxOpacity;
        private IContainer components;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBackGrColor_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.LightGray)
            {
                BackColor = Color.Yellow;
                return;
            }
            BackColor = Color.LightGray;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вітаю!");
        }

        private void btnOpacity_Click(object sender, EventArgs e)
        {
            Opacity = 1.5 - Opacity;
        }

        private void btnSetOfActions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\u042F \u0441\u0443\u043F\u0435\u0440\u043C\u0435\u0433\u0430\u043A\u043D\u043E\u043F\u043A\u0430,\n\u0456 \u0446\u044C\u043E\u0433\u043E \u043C\u0435\u043D\u0435 \u043D\u0435 \u043F\u043E\u0437\u0431\u0430\u0432\u0438\u0448!");
        }

        private void chBoxBackGrCol_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxBackGrCol.Checked)
            {
                btnSetOfActions.Click += new EventHandler(btnBackGrColor_Click);
                return;
            }
            btnSetOfActions.Click -= new EventHandler(btnBackGrColor_Click);
        }

        private void chBoxHello_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxHello.Checked)
            {
                btnSetOfActions.Click += new EventHandler(btnHello_Click);
                return;
            }
            btnSetOfActions.Click -= new EventHandler(btnHello_Click);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxOpacity.Checked)
            {
                btnSetOfActions.Click += new EventHandler(btnOpacity_Click);
                return;
            }
            btnSetOfActions.Click -= new EventHandler(btnOpacity_Click);
        }

        private void InitializeComponent()
        {
            btnOpacity = new Button();
            btnHello = new Button();
            btnSetOfActions = new Button();
            btnBackGrColor = new Button();
            chBoxOpacity = new CheckBox();
            chBoxBackGrCol = new CheckBox();
            chBoxHello = new CheckBox();
            SuspendLayout();
            btnOpacity.Location = new Point(0, 0);
            btnOpacity.Name = "btnOpacity";
            btnOpacity.Size = new Size(75, 23);
            btnOpacity.TabIndex = 0;
            btnOpacity.Text = "\u041F\u0440\u043E\u0437\u043E\u0440\u0456\u0441\u0442\u044C";
            btnOpacity.UseVisualStyleBackColor = true;
            btnOpacity.Click += new EventHandler(btnOpacity_Click);
            btnHello.Location = new Point(162, 0);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(75, 23);
            btnHello.TabIndex = 2;
            btnHello.Text = "hello World";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += new EventHandler(btnHello_Click);
            btnSetOfActions.Location = new Point(0, 29);
            btnSetOfActions.Name = "btnSetOfActions";
            btnSetOfActions.Size = new Size(237, 23);
            btnSetOfActions.TabIndex = 3;
            btnSetOfActions.Text = "\u0441\u0443\u043F\u0435\u0440\u043C\u0435\u0433\u0430\u043A\u043D\u043E\u043F\u043A\u0430";
            btnSetOfActions.UseVisualStyleBackColor = true;
            btnSetOfActions.Click += new EventHandler(btnSetOfActions_Click);
            btnBackGrColor.Location = new Point(81, 0);
            btnBackGrColor.Name = "btnBackGrColor";
            btnBackGrColor.Size = new Size(75, 23);
            btnBackGrColor.TabIndex = 1;
            btnBackGrColor.Text = "\u041A\u043E\u043B\u0456\u0440 \u0442\u043B\u0430";
            btnBackGrColor.UseVisualStyleBackColor = true;
            btnBackGrColor.Click += new EventHandler(btnBackGrColor_Click);
            chBoxOpacity.AutoSize = true;
            chBoxOpacity.Location = new Point(0, 58);
            chBoxOpacity.Name = "chBoxOpacity";
            chBoxOpacity.Size = new Size(246, 17);
            chBoxOpacity.TabIndex = 4;
            chBoxOpacity.Text = "\"\u0441\u0443\u043F\u0435\u0440\u043C\u0435\u0433\u0430\u043A\u043D\u043E\u043F\u043A\u0430\" \u043F\u043E\u0433\u043B\u0438\u043D\u0430\u0454 \"\u041F\u0440\u043E\u0437\u043E\u0440\u0456\u0441\u0442\u044C\"";
            chBoxOpacity.UseVisualStyleBackColor = true;
            chBoxOpacity.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            chBoxBackGrCol.AutoSize = true;
            chBoxBackGrCol.Location = new Point(0, 81);
            chBoxBackGrCol.Name = "chBoxBackGrCol";
            chBoxBackGrCol.Size = new Size(236, 17);
            chBoxBackGrCol.TabIndex = 5;
            chBoxBackGrCol.Text = "\"\u0441\u0443\u043F\u0435\u0440\u043C\u0435\u0433\u0430\u043A\u043D\u043E\u043F\u043A\u0430\" \u043F\u043E\u0433\u043B\u0438\u043D\u0430\u0454 \"\u041A\u043E\u043B\u0456\u0440 \u0442\u043B\u0430\"";
            chBoxBackGrCol.UseVisualStyleBackColor = true;
            chBoxBackGrCol.CheckedChanged += new EventHandler(chBoxBackGrCol_CheckedChanged);
            chBoxHello.AutoSize = true;
            chBoxHello.Location = new Point(0, 104);
            chBoxHello.Name = "chBoxHello";
            chBoxHello.Size = new Size(244, 17);
            chBoxHello.TabIndex = 6;
            chBoxHello.Text = "\"\u0441\u0443\u043F\u0435\u0440\u043C\u0435\u0433\u0430\u043A\u043D\u043E\u043F\u043A\u0430\" \u043F\u043E\u0433\u043B\u0438\u043D\u0430\u0454 \"Hello World\"";
            chBoxHello.UseVisualStyleBackColor = true;
            chBoxHello.CheckedChanged += new EventHandler(chBoxHello_CheckedChanged);
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 262);
            Controls.Add(chBoxHello);
            Controls.Add(chBoxBackGrCol);
            Controls.Add(chBoxOpacity);
            Controls.Add(btnBackGrColor);
            Controls.Add(btnSetOfActions);
            Controls.Add(btnHello);
            Controls.Add(btnOpacity);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
            this.Close();
        }

    } // class Form1

}


