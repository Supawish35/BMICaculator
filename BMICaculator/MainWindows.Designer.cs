namespace BMICaculator;

partial class MainWindows {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        submitBtn = new System.Windows.Forms.Button();
        heightTxt = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        weightTxt = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        BMIResult = new System.Windows.Forms.Label();
        BMICategory = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // submitBtn
        // 
        submitBtn.Location = new System.Drawing.Point(518, 109);
        submitBtn.Name = "submitBtn";
        submitBtn.Size = new System.Drawing.Size(80, 33);
        submitBtn.TabIndex = 0;
        submitBtn.Text = "submit";
        submitBtn.UseVisualStyleBackColor = true;
        submitBtn.Click += submitBtn_Click;
        // 
        // heightTxt
        // 
        heightTxt.Location = new System.Drawing.Point(241, 34);
        heightTxt.Name = "heightTxt";
        heightTxt.Size = new System.Drawing.Size(357, 27);
        heightTxt.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(174, 38);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(61, 23);
        label1.TabIndex = 2;
        label1.Text = "Height\r\n";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(174, 71);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(61, 23);
        label2.TabIndex = 4;
        label2.Text = "Weight\r\n";
        // 
        // weightTxt
        // 
        weightTxt.Location = new System.Drawing.Point(241, 67);
        weightTxt.Name = "weightTxt";
        weightTxt.Size = new System.Drawing.Size(357, 27);
        weightTxt.TabIndex = 3;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(174, 316);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(190, 30);
        label3.TabIndex = 5;
        label3.Text = "BMI Category";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(174, 346);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(190, 103);
        label4.TabIndex = 6;
        label4.Text = "Underweight\r\nHealthy\r\nOverweight\r\nObesity\r\n";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(408, 316);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(190, 30);
        label5.TabIndex = 7;
        label5.Text = "\tBMI Range";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(408, 346);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(190, 109);
        label6.TabIndex = 8;
        label6.Text = "Below 18.5\r\n18.5 – 24.9\r\n25.0 – 29.9\r\n30.0 or above";
        // 
        // BMIResult
        // 
        BMIResult.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        BMIResult.Location = new System.Drawing.Point(174, 168);
        BMIResult.Name = "BMIResult";
        BMIResult.Size = new System.Drawing.Size(424, 54);
        BMIResult.TabIndex = 9;
        BMIResult.Text = "Your BMI = ";
        // 
        // BMICategory
        // 
        BMICategory.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        BMICategory.Location = new System.Drawing.Point(174, 222);
        BMICategory.Name = "BMICategory";
        BMICategory.Size = new System.Drawing.Size(424, 54);
        BMICategory.TabIndex = 10;
        BMICategory.Text = "Your BMI Category = ";
        // 
        // MainWindows
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 569);
        Controls.Add(BMICategory);
        Controls.Add(BMIResult);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(weightTxt);
        Controls.Add(label1);
        Controls.Add(heightTxt);
        Controls.Add(submitBtn);
        Text = "BMI Calculator";
        ResumeLayout(false);
        PerformLayout();
        Load += BmiCalculator_onload;
    }

    private System.Windows.Forms.Label BMICategory;

    private System.Windows.Forms.Label BMIResult;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Button submitBtn;
    private System.Windows.Forms.TextBox heightTxt;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox weightTxt;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    #endregion
}