using CommunityToolkit.Maui.Behaviors;
using RunCalorieCalculator.Models;
using RunCalorieCalculator.Resources;

namespace RunCalorieCalculator;

public partial class MainPage : ContentPage
{

	private User User;

    public MainPage()
	{
		InitializeComponent();
        InitResources();
        User = new User();
    }

    private void InitResources()
    {
        lblGender.Text = AppResource.Gender;
        radioMale.Content = AppResource.GenderMale;
        radioFemale.Content = AppResource.GenderFemale;
        entAge.Placeholder = AppResource.Age;
        lblYears.Text = AppResource.Years;
        entWeight.Placeholder = AppResource.Weight;
        entHeight.Placeholder = AppResource.Height;
        entDuration.Placeholder = AppResource.Duration;
        lblDuration.Text = AppResource.Minutes;
        lblSpeed.Text = AppResource.Speed;
        btnCalculate.Text = AppResource.Calculate;

    }

    private void btnCalculate_Clicked(object sender, EventArgs e)
	{

        if (radioMale.IsChecked)
        {
            User.Gender = Gender.Male;
        }

        if (radioFemale.IsChecked)
        {
            User.Gender = Gender.Female;
        }

        User.Age = int.Parse(entAge.Text);
        User.Weight = Double.Parse(entWeight.Text);
		User.Height = Double.Parse(entHeight.Text);
		User.Duration = int.Parse(entDuration.Text);
		User.RunSpeed = (int)sldSpeed.Value;

		lblResult.Text = 
            $"{AppResource.Result}{Calculation.CalculateCalorie(User.Gender, User.Age, User.Weight, User.Height, User.RunSpeed, User.Duration).ToString("0.00")} kcal";

    }

    private void EntryTextChanged(object sender, TextChangedEventArgs e)
    {
        if ((AgeValidation.IsValid) &&
             (WeightValidation.IsValid) &&
             (HeightValidation.IsValid) &&
             (DurationValidation.IsValid))
        {
            btnCalculate.IsEnabled = true;
        }
        else
        {
            btnCalculate.IsEnabled = false;
        }
    }
}

