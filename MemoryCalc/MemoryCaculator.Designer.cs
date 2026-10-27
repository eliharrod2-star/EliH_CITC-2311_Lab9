namespace WinFormsApp1
{
    partial class Calculator
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
            txt_Answer = new TextBox();
            btn_Back = new Button();
            btn_Clear = new Button();
            btn_Seven = new Button();
            btn_Four = new Button();
            btn_One = new Button();
            btn_Zero = new Button();
            btn_Eight = new Button();
            btn_Five = new Button();
            btn_Two = new Button();
            btn_ChangeSign = new Button();
            btn_Nine = new Button();
            btn_Six = new Button();
            btn_Three = new Button();
            btn_Decimal = new Button();
            btn_Divide = new Button();
            btn_Multiply = new Button();
            btn_Subtract = new Button();
            btn_Add = new Button();
            btn_Equal = new Button();
            btn_Reciprical = new Button();
            btn_SqaureRoot = new Button();
            btn_MemClear = new Button();
            btn_MemRecall = new Button();
            btn_MemSave = new Button();
            btn_MemAdd = new Button();
            txt_Mem = new TextBox();
            SuspendLayout();
            // 
            // txt_Answer
            // 
            txt_Answer.Location = new Point(18, 12);
            txt_Answer.Name = "txt_Answer";
            txt_Answer.Size = new Size(276, 27);
            txt_Answer.TabIndex = 0;
            txt_Answer.TextChanged += txt_Answer_TextChanged;
            // 
            // btn_Back
            // 
            btn_Back.ForeColor = Color.Red;
            btn_Back.Location = new Point(65, 45);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(88, 34);
            btn_Back.TabIndex = 1;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            btn_Clear.ForeColor = Color.Red;
            btn_Clear.Location = new Point(159, 45);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(135, 34);
            btn_Clear.TabIndex = 2;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Seven
            // 
            btn_Seven.ForeColor = Color.Blue;
            btn_Seven.Location = new Point(65, 85);
            btn_Seven.Name = "btn_Seven";
            btn_Seven.Size = new Size(41, 34);
            btn_Seven.TabIndex = 3;
            btn_Seven.Text = "7";
            btn_Seven.UseVisualStyleBackColor = true;
            // 
            // btn_Four
            // 
            btn_Four.ForeColor = Color.Blue;
            btn_Four.Location = new Point(65, 125);
            btn_Four.Name = "btn_Four";
            btn_Four.Size = new Size(41, 34);
            btn_Four.TabIndex = 4;
            btn_Four.Text = "4";
            btn_Four.UseVisualStyleBackColor = true;
            // 
            // btn_One
            // 
            btn_One.ForeColor = Color.Blue;
            btn_One.Location = new Point(65, 167);
            btn_One.Name = "btn_One";
            btn_One.Size = new Size(41, 33);
            btn_One.TabIndex = 5;
            btn_One.Text = "1";
            btn_One.UseVisualStyleBackColor = true;
            // 
            // btn_Zero
            // 
            btn_Zero.ForeColor = Color.Blue;
            btn_Zero.Location = new Point(65, 204);
            btn_Zero.Name = "btn_Zero";
            btn_Zero.Size = new Size(41, 33);
            btn_Zero.TabIndex = 6;
            btn_Zero.Text = "0";
            btn_Zero.UseVisualStyleBackColor = true;
            // 
            // btn_Eight
            // 
            btn_Eight.ForeColor = Color.Blue;
            btn_Eight.Location = new Point(112, 85);
            btn_Eight.Name = "btn_Eight";
            btn_Eight.Size = new Size(41, 34);
            btn_Eight.TabIndex = 7;
            btn_Eight.Text = "8";
            btn_Eight.UseVisualStyleBackColor = true;
            // 
            // btn_Five
            // 
            btn_Five.ForeColor = Color.Blue;
            btn_Five.Location = new Point(112, 125);
            btn_Five.Name = "btn_Five";
            btn_Five.Size = new Size(41, 34);
            btn_Five.TabIndex = 8;
            btn_Five.Text = "5";
            btn_Five.UseVisualStyleBackColor = true;
            // 
            // btn_Two
            // 
            btn_Two.ForeColor = Color.Blue;
            btn_Two.Location = new Point(112, 165);
            btn_Two.Name = "btn_Two";
            btn_Two.Size = new Size(41, 34);
            btn_Two.TabIndex = 9;
            btn_Two.Text = "2";
            btn_Two.UseVisualStyleBackColor = true;
            // 
            // btn_ChangeSign
            // 
            btn_ChangeSign.ForeColor = Color.Blue;
            btn_ChangeSign.Location = new Point(112, 206);
            btn_ChangeSign.Name = "btn_ChangeSign";
            btn_ChangeSign.Size = new Size(41, 33);
            btn_ChangeSign.TabIndex = 10;
            btn_ChangeSign.Text = "+/-";
            btn_ChangeSign.UseVisualStyleBackColor = true;
            // 
            // btn_Nine
            // 
            btn_Nine.ForeColor = Color.Blue;
            btn_Nine.Location = new Point(159, 85);
            btn_Nine.Name = "btn_Nine";
            btn_Nine.Size = new Size(41, 34);
            btn_Nine.TabIndex = 11;
            btn_Nine.Text = "9";
            btn_Nine.UseVisualStyleBackColor = true;
            // 
            // btn_Six
            // 
            btn_Six.ForeColor = Color.Blue;
            btn_Six.Location = new Point(159, 125);
            btn_Six.Name = "btn_Six";
            btn_Six.Size = new Size(41, 34);
            btn_Six.TabIndex = 13;
            btn_Six.Text = "6";
            btn_Six.UseVisualStyleBackColor = true;
            // 
            // btn_Three
            // 
            btn_Three.ForeColor = Color.Blue;
            btn_Three.Location = new Point(159, 167);
            btn_Three.Name = "btn_Three";
            btn_Three.Size = new Size(41, 34);
            btn_Three.TabIndex = 14;
            btn_Three.Text = "3";
            btn_Three.UseVisualStyleBackColor = true;
            // 
            // btn_Decimal
            // 
            btn_Decimal.ForeColor = Color.Blue;
            btn_Decimal.Location = new Point(159, 204);
            btn_Decimal.Name = "btn_Decimal";
            btn_Decimal.Size = new Size(41, 33);
            btn_Decimal.TabIndex = 15;
            btn_Decimal.Text = ".";
            btn_Decimal.UseVisualStyleBackColor = true;
            // 
            // btn_Divide
            // 
            btn_Divide.ForeColor = Color.Red;
            btn_Divide.Location = new Point(206, 85);
            btn_Divide.Name = "btn_Divide";
            btn_Divide.Size = new Size(41, 34);
            btn_Divide.TabIndex = 16;
            btn_Divide.Text = "/";
            btn_Divide.UseVisualStyleBackColor = true;
            // 
            // btn_Multiply
            // 
            btn_Multiply.ForeColor = Color.Red;
            btn_Multiply.Location = new Point(206, 125);
            btn_Multiply.Name = "btn_Multiply";
            btn_Multiply.Size = new Size(41, 34);
            btn_Multiply.TabIndex = 17;
            btn_Multiply.Text = "*";
            btn_Multiply.UseVisualStyleBackColor = true;
            // 
            // btn_Subtract
            // 
            btn_Subtract.ForeColor = Color.Red;
            btn_Subtract.Location = new Point(206, 165);
            btn_Subtract.Name = "btn_Subtract";
            btn_Subtract.Size = new Size(41, 34);
            btn_Subtract.TabIndex = 18;
            btn_Subtract.Text = "-";
            btn_Subtract.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.ForeColor = Color.Red;
            btn_Add.Location = new Point(206, 204);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(41, 33);
            btn_Add.TabIndex = 19;
            btn_Add.Text = "+";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Equal
            // 
            btn_Equal.ForeColor = Color.Red;
            btn_Equal.Location = new Point(253, 167);
            btn_Equal.Name = "btn_Equal";
            btn_Equal.Size = new Size(41, 72);
            btn_Equal.TabIndex = 20;
            btn_Equal.Text = "=";
            btn_Equal.UseVisualStyleBackColor = true;
            // 
            // btn_Reciprical
            // 
            btn_Reciprical.ForeColor = Color.Blue;
            btn_Reciprical.Location = new Point(253, 125);
            btn_Reciprical.Name = "btn_Reciprical";
            btn_Reciprical.Size = new Size(41, 34);
            btn_Reciprical.TabIndex = 21;
            btn_Reciprical.Text = "1/X";
            btn_Reciprical.UseVisualStyleBackColor = true;
            // 
            // btn_SqaureRoot
            // 
            btn_SqaureRoot.ForeColor = Color.Blue;
            btn_SqaureRoot.Location = new Point(253, 85);
            btn_SqaureRoot.Name = "btn_SqaureRoot";
            btn_SqaureRoot.Size = new Size(41, 34);
            btn_SqaureRoot.TabIndex = 22;
            btn_SqaureRoot.Text = "Sqr";
            btn_SqaureRoot.UseVisualStyleBackColor = true;
            // 
            // btn_MemClear
            // 
            btn_MemClear.ForeColor = Color.Red;
            btn_MemClear.Location = new Point(18, 85);
            btn_MemClear.Name = "btn_MemClear";
            btn_MemClear.Size = new Size(41, 34);
            btn_MemClear.TabIndex = 23;
            btn_MemClear.Text = "MC";
            btn_MemClear.UseVisualStyleBackColor = true;
            // 
            // btn_MemRecall
            // 
            btn_MemRecall.ForeColor = Color.Red;
            btn_MemRecall.Location = new Point(18, 125);
            btn_MemRecall.Name = "btn_MemRecall";
            btn_MemRecall.Size = new Size(41, 34);
            btn_MemRecall.TabIndex = 24;
            btn_MemRecall.Text = "MR";
            btn_MemRecall.UseVisualStyleBackColor = true;
            // 
            // btn_MemSave
            // 
            btn_MemSave.ForeColor = Color.Red;
            btn_MemSave.Location = new Point(18, 167);
            btn_MemSave.Name = "btn_MemSave";
            btn_MemSave.Size = new Size(41, 32);
            btn_MemSave.TabIndex = 25;
            btn_MemSave.Text = "MS";
            btn_MemSave.UseVisualStyleBackColor = true;
            // 
            // btn_MemAdd
            // 
            btn_MemAdd.ForeColor = Color.Red;
            btn_MemAdd.Location = new Point(18, 204);
            btn_MemAdd.Name = "btn_MemAdd";
            btn_MemAdd.Size = new Size(41, 33);
            btn_MemAdd.TabIndex = 26;
            btn_MemAdd.Text = "M+";
            btn_MemAdd.UseVisualStyleBackColor = true;
            // 
            // txt_Mem
            // 
            txt_Mem.Location = new Point(18, 52);
            txt_Mem.Name = "txt_Mem";
            txt_Mem.ReadOnly = true;
            txt_Mem.Size = new Size(41, 27);
            txt_Mem.TabIndex = 27;
            // 
            // Calculator
            // 
            AcceptButton = btn_Back;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Clear;
            ClientSize = new Size(319, 264);
            Controls.Add(txt_Mem);
            Controls.Add(btn_MemAdd);
            Controls.Add(btn_MemSave);
            Controls.Add(btn_MemRecall);
            Controls.Add(btn_MemClear);
            Controls.Add(btn_SqaureRoot);
            Controls.Add(btn_Reciprical);
            Controls.Add(btn_Equal);
            Controls.Add(btn_Add);
            Controls.Add(btn_Subtract);
            Controls.Add(btn_Multiply);
            Controls.Add(btn_Divide);
            Controls.Add(btn_Decimal);
            Controls.Add(btn_Three);
            Controls.Add(btn_Six);
            Controls.Add(btn_Nine);
            Controls.Add(btn_ChangeSign);
            Controls.Add(btn_Two);
            Controls.Add(btn_Five);
            Controls.Add(btn_Eight);
            Controls.Add(btn_Zero);
            Controls.Add(btn_One);
            Controls.Add(btn_Four);
            Controls.Add(btn_Seven);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Back);
            Controls.Add(txt_Answer);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Answer;
        private Button btn_Back;
        private Button btn_Clear;
        private Button btn_Seven;
        private Button btn_Four;
        private Button btn_One;
        private Button btn_Zero;
        private Button btn_Eight;
        private Button btn_Five;
        private Button btn_Two;
        private Button btn_ChangeSign;
        private Button btn_Nine;
        private Button btn_Six;
        private Button btn_Three;
        private Button btn_Decimal;
        private Button btn_Divide;
        private Button btn_Multiply;
        private Button btn_Subtract;
        private Button btn_Add;
        private Button btn_Equal;
        private Button btn_Reciprical;
        private Button btn_SqaureRoot;
        private Button btn_MemClear;
        private Button btn_MemRecall;
        private Button btn_MemSave;
        private Button btn_MemAdd;
        private TextBox txt_Mem;
    }
}
