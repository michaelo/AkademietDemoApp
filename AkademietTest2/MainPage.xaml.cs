using Microsoft.Maui.Maps;

namespace AkademietTest2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    async void NavListBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("//ItemsList");
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Vibration.Default.Vibrate(0.5);
    }

    void HapticTestBtn_Clicked(System.Object sender, System.EventArgs e)
    {
		HapticFeedback.Default.Perform(HapticFeedbackType.Click);
    }

    async void map_Loaded(System.Object sender, System.EventArgs e)
    {
		var loc = await Geolocation.Default.GetLocationAsync();
		var mapSpan = new MapSpan(loc, 0.1, 0.1);
		
		map.MoveToRegion(mapSpan);
		
    }
}
