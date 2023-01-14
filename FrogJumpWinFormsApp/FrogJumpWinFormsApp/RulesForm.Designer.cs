namespace FrogJumpWinFormsApp
{
    partial class RulesForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "1) На экране находятся жабки и пустая кувшинка. С каждой стороны по 4 жабки, смот" +
                "рящих в ондну сторону.",
            "",
            "2) Для того, что бы сделать ход, вам нужно кликнуть по жабке и она прыгнет на пус" +
                "той кувшин, поменявшись с ним местами.",
            "",
            "3) За ход можно перепрыгнуть только 1 жабку.",
            "",
            "4) Чистой победой считается, когда жабки поменялись местами за минимальное количе" +
                "ство ходов (тоесть 24).",
            ""});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(891, 164);
            this.listBox1.TabIndex = 0;
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 164);
            this.Controls.Add(this.listBox1);
            this.Name = "RulesForm";
            this.Text = "Правила";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
    }
}