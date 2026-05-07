namespace PizzaProject
{
    partial class Form1
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkExtraChess = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPepperss = new System.Windows.Forms.CheckBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.lbMainTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.lbSummaryCurst = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSummaryToppings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbSummaryEat = new System.Windows.Forms.Label();
            this.gbCurstType = new System.Windows.Forms.GroupBox();
            this.rbThinkCurst = new System.Windows.Forms.RadioButton();
            this.rbThinCurst = new System.Windows.Forms.RadioButton();
            this.lbSummarySize = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.gbToppings.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbCurstType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnOrder.Location = new System.Drawing.Point(429, 618);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(135, 36);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnReset.Location = new System.Drawing.Point(588, 618);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 36);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "ResetForm";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkExtraChess
            // 
            this.chkExtraChess.AutoSize = true;
            this.chkExtraChess.Location = new System.Drawing.Point(20, 45);
            this.chkExtraChess.Margin = new System.Windows.Forms.Padding(4);
            this.chkExtraChess.Name = "chkExtraChess";
            this.chkExtraChess.Size = new System.Drawing.Size(184, 33);
            this.chkExtraChess.TabIndex = 2;
            this.chkExtraChess.Text = "Extra Chess";
            this.chkExtraChess.UseVisualStyleBackColor = true;
            this.chkExtraChess.CheckedChanged += new System.EventHandler(this.chkExtraChess_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(20, 91);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(4);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(180, 33);
            this.chkMushrooms.TabIndex = 3;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(20, 143);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(4);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(162, 33);
            this.chkTomatoes.TabIndex = 4;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(192, 45);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(115, 33);
            this.chkOnion.TabIndex = 5;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chknion_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(192, 91);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(4);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(119, 33);
            this.chkOlives.TabIndex = 6;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkGreenPepperss
            // 
            this.chkGreenPepperss.AutoSize = true;
            this.chkGreenPepperss.Location = new System.Drawing.Point(192, 143);
            this.chkGreenPepperss.Margin = new System.Windows.Forms.Padding(4);
            this.chkGreenPepperss.Name = "chkGreenPepperss";
            this.chkGreenPepperss.Size = new System.Drawing.Size(253, 33);
            this.chkGreenPepperss.TabIndex = 7;
            this.chkGreenPepperss.Text = "Greeen Peppeers";
            this.chkGreenPepperss.UseVisualStyleBackColor = true;
            this.chkGreenPepperss.CheckedChanged += new System.EventHandler(this.chkGreenPepperss_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkExtraChess);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkGreenPepperss);
            this.gbToppings.Location = new System.Drawing.Point(396, 155);
            this.gbToppings.Margin = new System.Windows.Forms.Padding(4);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Padding = new System.Windows.Forms.Padding(4);
            this.gbToppings.Size = new System.Drawing.Size(347, 205);
            this.gbToppings.TabIndex = 8;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            this.gbToppings.Enter += new System.EventHandler(this.gbToppings_Enter);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(21, 45);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(4);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(114, 34);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(21, 90);
            this.rbMeduim.Margin = new System.Windows.Forms.Padding(4);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(142, 34);
            this.rbMeduim.TabIndex = 9;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(21, 139);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(4);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(114, 34);
            this.rbLarge.TabIndex = 10;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(15, 54);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(4);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(110, 33);
            this.rbEatIn.TabIndex = 11;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged_1);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(131, 54);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(4);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(151, 33);
            this.rbTakeOut.TabIndex = 13;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // lbMainTitle
            // 
            this.lbMainTitle.AutoSize = true;
            this.lbMainTitle.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbMainTitle.Location = new System.Drawing.Point(381, 41);
            this.lbMainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMainTitle.Name = "lbMainTitle";
            this.lbMainTitle.Size = new System.Drawing.Size(666, 85);
            this.lbMainTitle.TabIndex = 14;
            this.lbMainTitle.Text = "Make Your pizza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(860, 504);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Price:";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(75, 155);
            this.gbSize.Margin = new System.Windows.Forms.Padding(4);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(4);
            this.gbSize.Size = new System.Drawing.Size(256, 205);
            this.gbSize.TabIndex = 19;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // lbSummaryCurst
            // 
            this.lbSummaryCurst.AutoSize = true;
            this.lbSummaryCurst.Location = new System.Drawing.Point(922, 294);
            this.lbSummaryCurst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSummaryCurst.Name = "lbSummaryCurst";
            this.lbSummaryCurst.Size = new System.Drawing.Size(133, 29);
            this.lbSummaryCurst.TabIndex = 26;
            this.lbSummaryCurst.Text = "Thin Curst";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(832, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Curst Type: ";
            // 
            // lbSummaryToppings
            // 
            this.lbSummaryToppings.AutoSize = true;
            this.lbSummaryToppings.Location = new System.Drawing.Point(884, 235);
            this.lbSummaryToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSummaryToppings.Name = "lbSummaryToppings";
            this.lbSummaryToppings.Size = new System.Drawing.Size(165, 29);
            this.lbSummaryToppings.TabIndex = 24;
            this.lbSummaryToppings.Text = "No Toppings";
            this.lbSummaryToppings.Click += new System.EventHandler(this.lbSummaryToppings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(832, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Size: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(822, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Order Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(832, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Topppings: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(832, 345);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "Where To Eat:";
            // 
            // lbSummaryEat
            // 
            this.lbSummaryEat.AutoSize = true;
            this.lbSummaryEat.Location = new System.Drawing.Point(928, 372);
            this.lbSummaryEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSummaryEat.Name = "lbSummaryEat";
            this.lbSummaryEat.Size = new System.Drawing.Size(79, 29);
            this.lbSummaryEat.TabIndex = 28;
            this.lbSummaryEat.Text = "Eat In";
            // 
            // gbCurstType
            // 
            this.gbCurstType.Controls.Add(this.rbThinkCurst);
            this.gbCurstType.Controls.Add(this.rbThinCurst);
            this.gbCurstType.Location = new System.Drawing.Point(75, 456);
            this.gbCurstType.Margin = new System.Windows.Forms.Padding(4);
            this.gbCurstType.Name = "gbCurstType";
            this.gbCurstType.Padding = new System.Windows.Forms.Padding(4);
            this.gbCurstType.Size = new System.Drawing.Size(267, 210);
            this.gbCurstType.TabIndex = 30;
            this.gbCurstType.TabStop = false;
            this.gbCurstType.Text = "Crust Type";
            this.gbCurstType.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbThinkCurst
            // 
            this.rbThinkCurst.AutoSize = true;
            this.rbThinkCurst.Location = new System.Drawing.Point(32, 95);
            this.rbThinkCurst.Margin = new System.Windows.Forms.Padding(4);
            this.rbThinkCurst.Name = "rbThinkCurst";
            this.rbThinkCurst.Size = new System.Drawing.Size(177, 33);
            this.rbThinkCurst.TabIndex = 14;
            this.rbThinkCurst.TabStop = true;
            this.rbThinkCurst.Text = "Think Curst";
            this.rbThinkCurst.UseVisualStyleBackColor = true;
            this.rbThinkCurst.CheckedChanged += new System.EventHandler(this.rbThinkCurst_CheckedChanged);
            // 
            // rbThinCurst
            // 
            this.rbThinCurst.AutoSize = true;
            this.rbThinCurst.Location = new System.Drawing.Point(32, 49);
            this.rbThinCurst.Margin = new System.Windows.Forms.Padding(4);
            this.rbThinCurst.Name = "rbThinCurst";
            this.rbThinCurst.Size = new System.Drawing.Size(164, 33);
            this.rbThinCurst.TabIndex = 13;
            this.rbThinCurst.TabStop = true;
            this.rbThinCurst.Text = "Thin Curst";
            this.rbThinCurst.UseVisualStyleBackColor = true;
            this.rbThinCurst.CheckedChanged += new System.EventHandler(this.rbThinCurst_CheckedChanged);
            // 
            // lbSummarySize
            // 
            this.lbSummarySize.AutoSize = true;
            this.lbSummarySize.Location = new System.Drawing.Point(928, 182);
            this.lbSummarySize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSummarySize.Name = "lbSummarySize";
            this.lbSummarySize.Size = new System.Drawing.Size(0, 29);
            this.lbSummarySize.TabIndex = 31;
            this.lbSummarySize.Click += new System.EventHandler(this.lbSummarySize_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbPrice.Location = new System.Drawing.Point(919, 551);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(150, 83);
            this.lbPrice.TabIndex = 32;
            this.lbPrice.Text = "0 $";
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(429, 470);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(297, 100);
            this.gbWhereToEat.TabIndex = 36;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 1109);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbSummarySize);
            this.Controls.Add(this.gbCurstType);
            this.Controls.Add(this.lbSummaryEat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbSummaryCurst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSummaryToppings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMainTitle);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCurstType.ResumeLayout(false);
            this.gbCurstType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkExtraChess;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkGreenPepperss;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.Label lbMainTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.Label lbSummaryCurst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSummaryToppings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSummaryEat;
        private System.Windows.Forms.GroupBox gbCurstType;
        private System.Windows.Forms.RadioButton rbThinCurst;
        private System.Windows.Forms.RadioButton rbThinkCurst;
        private System.Windows.Forms.Label lbSummarySize;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.GroupBox gbWhereToEat;
    }
}

