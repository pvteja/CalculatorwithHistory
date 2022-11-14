using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CalculatorWithHistory.ViewModel;

public partial class HistoryViewModel : ObservableObject
{
	
	public HistoryViewModel()
	{
		items=new ObservableCollection<string>();
	}

	[ObservableProperty]
	ObservableCollection<string> items;

	[ObservableProperty]
	public string text;

	[RelayCommand]
	void Add()

	{
		
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
		items.Add(text);
            Debug.WriteLine(text);

        text= string.Empty;
	       }
	[RelayCommand]
	 async void DeleteAll()
	{
		if (items.Count == 0)
		{
			await Application.Current.MainPage.DisplayAlert("No History", "No History to Clear.", "Ok");
		}
		else
		{
			bool x = await Application.Current.MainPage.DisplayAlert("Question?", "Would you like to Clear  the History", "Yes", "No");
			if (x)
				items.Clear();
		}
	}
}