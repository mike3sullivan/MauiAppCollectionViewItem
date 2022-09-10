using System.Collections.ObjectModel;

namespace MauiAppCollectionViewItem;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
	public ObservableCollection<string> Data { get; set; } 
		= new ObservableCollection<string>
			{
				"AAAA","BBBB","CCCC","DDDD"
			};
}

