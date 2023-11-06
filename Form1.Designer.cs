using System.ComponentModel;

namespace CS311_Project3_ABE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            groupBox1 = new GroupBox();
            ckbMushroom = new CheckBox();
            ckbExtraCheese = new CheckBox();
            ckbJalapeno = new CheckBox();
            ckbBananaPeppers = new CheckBox();
            ckbGreenOlives = new CheckBox();
            ckbBlackOlives = new CheckBox();
            ckbGreenPepper = new CheckBox();
            ckbOnion = new CheckBox();
            ckbSpicyItalianSausage = new CheckBox();
            ckbCanadianBacon = new CheckBox();
            ckbSausage = new CheckBox();
            ckbPepperoni = new CheckBox();
            lblToppings = new Label();
            groupBox2 = new GroupBox();
            rdoRegular = new RadioButton();
            rdoThick = new RadioButton();
            rdoThin = new RadioButton();
            lblCrustType = new Label();
            cboSize = new ComboBox();
            lblSize = new Label();
            label3 = new Label();
            lblOrderSummary = new Label();
            rtfOrderSummary = new RichTextBox();
            btnCalculate = new Button();
            lblSubtotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtSubtotal = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckbMushroom);
            groupBox1.Controls.Add(ckbExtraCheese);
            groupBox1.Controls.Add(ckbJalapeno);
            groupBox1.Controls.Add(ckbBananaPeppers);
            groupBox1.Controls.Add(ckbGreenOlives);
            groupBox1.Controls.Add(ckbBlackOlives);
            groupBox1.Controls.Add(ckbGreenPepper);
            groupBox1.Controls.Add(ckbOnion);
            groupBox1.Controls.Add(ckbSpicyItalianSausage);
            groupBox1.Controls.Add(ckbCanadianBacon);
            groupBox1.Controls.Add(ckbSausage);
            groupBox1.Controls.Add(ckbPepperoni);
            groupBox1.Controls.Add(lblToppings);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cboSize);
            groupBox1.Controls.Add(lblSize);
            groupBox1.Location = new Point(79, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1149, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // ckbMushroom
            // 
            ckbMushroom.AutoSize = true;
            ckbMushroom.Location = new Point(686, 297);
            ckbMushroom.Name = "ckbMushroom";
            ckbMushroom.Size = new Size(163, 36);
            ckbMushroom.TabIndex = 16;
            ckbMushroom.Text = "Mushroom";
            ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            ckbExtraCheese.AutoSize = true;
            ckbExtraCheese.Location = new Point(686, 251);
            ckbExtraCheese.Name = "ckbExtraCheese";
            ckbExtraCheese.Size = new Size(182, 36);
            ckbExtraCheese.TabIndex = 15;
            ckbExtraCheese.Text = "Extra Cheese";
            ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbJalapeno
            // 
            ckbJalapeno.AutoSize = true;
            ckbJalapeno.Location = new Point(686, 209);
            ckbJalapeno.Name = "ckbJalapeno";
            ckbJalapeno.Size = new Size(140, 36);
            ckbJalapeno.TabIndex = 14;
            ckbJalapeno.Text = "Jalapeno";
            ckbJalapeno.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            ckbBananaPeppers.AutoSize = true;
            ckbBananaPeppers.Location = new Point(686, 171);
            ckbBananaPeppers.Name = "ckbBananaPeppers";
            ckbBananaPeppers.Size = new Size(215, 36);
            ckbBananaPeppers.TabIndex = 13;
            ckbBananaPeppers.Text = "Banana Peppers";
            ckbBananaPeppers.UseVisualStyleBackColor = true;
            ckbBananaPeppers.CheckedChanged += checkBox9_CheckedChanged;
            // 
            // ckbGreenOlives
            // 
            ckbGreenOlives.AutoSize = true;
            ckbGreenOlives.Location = new Point(416, 297);
            ckbGreenOlives.Name = "ckbGreenOlives";
            ckbGreenOlives.Size = new Size(182, 36);
            ckbGreenOlives.TabIndex = 12;
            ckbGreenOlives.Text = "Green Olives";
            ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            ckbBlackOlives.AutoSize = true;
            ckbBlackOlives.Location = new Point(416, 255);
            ckbBlackOlives.Name = "ckbBlackOlives";
            ckbBlackOlives.Size = new Size(173, 36);
            ckbBlackOlives.TabIndex = 11;
            ckbBlackOlives.Text = "Black Olives";
            ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            ckbGreenPepper.AutoSize = true;
            ckbGreenPepper.Location = new Point(416, 213);
            ckbGreenPepper.Name = "ckbGreenPepper";
            ckbGreenPepper.Size = new Size(191, 36);
            ckbGreenPepper.TabIndex = 10;
            ckbGreenPepper.Text = "Green Pepper";
            ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Location = new Point(416, 171);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(112, 36);
            ckbOnion.TabIndex = 9;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            ckbSpicyItalianSausage.AutoSize = true;
            ckbSpicyItalianSausage.Location = new Point(89, 293);
            ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            ckbSpicyItalianSausage.Size = new Size(268, 36);
            ckbSpicyItalianSausage.TabIndex = 8;
            ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            ckbCanadianBacon.AutoSize = true;
            ckbCanadianBacon.Location = new Point(89, 251);
            ckbCanadianBacon.Name = "ckbCanadianBacon";
            ckbCanadianBacon.Size = new Size(217, 36);
            ckbCanadianBacon.TabIndex = 7;
            ckbCanadianBacon.Text = "Canadian Bacon";
            ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Location = new Point(89, 209);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(134, 36);
            ckbSausage.TabIndex = 6;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            ckbPepperoni.AutoSize = true;
            ckbPepperoni.Location = new Point(89, 167);
            ckbPepperoni.Name = "ckbPepperoni";
            ckbPepperoni.Size = new Size(154, 36);
            ckbPepperoni.TabIndex = 5;
            ckbPepperoni.Text = "Pepperoni";
            ckbPepperoni.UseVisualStyleBackColor = true;
            ckbPepperoni.CheckedChanged += ckbPepperoni_CheckedChanged;
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToppings.Location = new Point(15, 116);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(126, 32);
            lblToppings.TabIndex = 4;
            lblToppings.Text = "Toppings:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoRegular);
            groupBox2.Controls.Add(rdoThick);
            groupBox2.Controls.Add(rdoThin);
            groupBox2.Controls.Add(lblCrustType);
            groupBox2.Location = new Point(474, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(703, 80);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdoRegular.Location = new Point(436, 31);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(133, 36);
            rdoRegular.TabIndex = 5;
            rdoRegular.TabStop = true;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdoThick.Location = new Point(315, 33);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(105, 36);
            rdoThick.TabIndex = 4;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            rdoThick.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdoThin.Location = new Point(198, 33);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(95, 36);
            rdoThin.TabIndex = 3;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            rdoThin.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // lblCrustType
            // 
            lblCrustType.AutoSize = true;
            lblCrustType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCrustType.Location = new Point(57, 35);
            lblCrustType.Name = "lblCrustType";
            lblCrustType.Size = new Size(145, 32);
            lblCrustType.TabIndex = 2;
            lblCrustType.Text = "Crust type: ";
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboSize.Location = new Point(131, 38);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(296, 40);
            cboSize.TabIndex = 1;
            cboSize.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.Location = new Point(39, 43);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(66, 32);
            lblSize.TabIndex = 0;
            lblSize.Text = "Size:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(346, 25);
            label3.Name = "label3";
            label3.Size = new Size(954, 128);
            label3.TabIndex = 2;
            label3.Text = "Adam's Pizza Palace";
            label3.Click += label3_Click;
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.Location = new Point(82, 626);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(188, 32);
            lblOrderSummary.TabIndex = 3;
            lblOrderSummary.Text = "Order Summary:";
            lblOrderSummary.Click += label5_Click;
            // 
            // rtfOrderSummary
            // 
            rtfOrderSummary.Location = new Point(297, 630);
            rtfOrderSummary.Name = "rtfOrderSummary";
            rtfOrderSummary.Size = new Size(490, 275);
            rtfOrderSummary.TabIndex = 4;
            rtfOrderSummary.Text = "";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(959, 786);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(266, 119);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(962, 629);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(108, 32);
            lblSubtotal.TabIndex = 6;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(1011, 677);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(52, 32);
            lblTax.TabIndex = 7;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(993, 722);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 32);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(1093, 629);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(132, 39);
            txtSubtotal.TabIndex = 9;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(1093, 674);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(132, 39);
            txtTax.TabIndex = 10;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1093, 719);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(132, 39);
            txtTotal.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pizza;
            pictureBox1.Location = new Point(83, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 948);
            Controls.Add(pictureBox1);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubtotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(btnCalculate);
            Controls.Add(rtfOrderSummary);
            Controls.Add(lblOrderSummary);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Adam's Pizza Palace";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboSize;
        private Label lblSize;
        private GroupBox groupBox2;
        private Label lblCrustType;
        private RadioButton rdoRegular;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private Label label3;
        private CheckBox ckbPepperoni;
        private Label lblToppings;
        private CheckBox ckbBananaPeppers;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbOnion;
        private CheckBox ckbSpicyItalianSausage;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbSausage;
        private CheckBox ckbMushroom;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbJalapeno;
        private Label lblOrderSummary;
        private RichTextBox rtfOrderSummary;
        private Button btnCalculate;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSubtotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private PictureBox pictureBox1;
    }
}