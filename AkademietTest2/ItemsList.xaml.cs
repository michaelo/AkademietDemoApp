using System.Collections.ObjectModel;

namespace AkademietTest2;

public partial class ItemsList : ContentPage
{

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
}
