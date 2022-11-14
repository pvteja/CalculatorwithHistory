using CalculatorWithHistory.ViewModel;

namespace CalculatorWithHistory.View;

public partial class HistoryPage : ContentPage
{
	public HistoryPage(HistoryViewModel vm )
	{
		InitializeComponent();
		BindingContext = vm;
	}
}