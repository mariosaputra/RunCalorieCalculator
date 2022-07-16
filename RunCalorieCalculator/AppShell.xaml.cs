using RunCalorieCalculator.Resources;

namespace RunCalorieCalculator;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Title.Title = AppResource.Title;
	}
}
