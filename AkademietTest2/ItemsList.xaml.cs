using System.Collections.ObjectModel;

namespace AkademietTest2;


public partial class ItemsList : ContentPage
{

    //string documentId = "your-document-id";
    //string sheetId = "your-sheet-id";
    //string range = "A1:D10";

    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public IEnumerable<Item> Items { get; set;  } = new List<Item>
	{
		new Item
		{
			Title = "Tittel",
			Description = "Beskrivelse"
		},
        new Item
        {
            Title = "En til",
            Description = "Litt lengre beskrivelse her"
        }
    };


	public ItemsList()
	{
		InitializeComponent();
		ItemsView.ItemsSource = Items;
    }

    async void BackBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    async void RefreshDataBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await DisplayAlert("Alert", "TOOD: Implementer lasting av data", "OK");
    }
    //void RefreshDataBtn_Clicked(System.Object sender, System.EventArgs e)
    //{
    //    // Replace the path and filename with the path to your JSON key file
    //    string jsonKeyFilePath = "C:\path\to\your\keyfile.json";

    //    // Create a new credential object from the JSON key file
    //    var credential = GoogleCredential.FromFile(jsonKeyFilePath).CreateScoped(SheetsService.Scope.SpreadsheetsReadonly);

    //    // Create a new Sheets API service object
    //    var service = new SheetsService(new BaseClientService.Initializer()
    //    {
    //        HttpClientInitializer = credential,
    //        ApplicationName = "My Sheets API App",
    //    });



    //    var request = service.Spreadsheets.Values.Get(documentId, range);
    //    var response = request.Execute();

    //    // Get the list of rows from the response
    //    var rows = response.Values;

    //    // Loop through the rows and print the values of each cell
    //    foreach (var row in rows)
    //    {
    //        foreach (var cell in row)
    //        {
    //            Console.Write(cell + "\t");
    //        }
    //        Console.WriteLine();
    //    }
    //}<Button x:Name="RefreshDataBtn" Clicked="RefreshDataBtn_Clicked" Text="Hent data" />
}
