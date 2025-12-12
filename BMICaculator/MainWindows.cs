namespace BMICaculator;

public partial class MainWindows : Form {
    public MainWindows() {
        InitializeComponent();
    }

    private void submitBtn_Click(object sender, EventArgs e) {
        float height = float.Parse(heightTxt.Text);
        float weight = float.Parse(weightTxt.Text);

        height /= 100;
        
        double bmi = BmiCalculator(height, weight);
        BMIResult.Text = "Your BMI = " + bmi.ToString("F2");
        BMICategory.Text = "Your BMI Category = " + BmiCategory(bmi);
    }

    private Double BmiCalculator(float height  , float weight) {
        return weight / Math.Pow(height, 2); 
    }

    private String BmiCategory(double bmi) {
        String bmiCategory = "";

        if (bmi < 18.5) {
            bmiCategory = "Underweight";
        } else if (bmi < 25) {
            bmiCategory = "Normal";
        } else if (bmi < 30) {
            bmiCategory = "Overweight";
        } else if (bmi < 35) {
            bmiCategory = "Obesity ";
        } else {
            bmiCategory = "Obesity II";
        }
        return bmiCategory;
    }

    private void BmiCalculator_onload(object sender, EventArgs e) {
        MessageBox.Show("Welcome To BMI Calculator", "Welcome");
    }
}