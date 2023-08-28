namespace ModelGenApp.Views;
public partial class PhaseResultsView : UserControl
{
  public PhaseResultsView()
  {
    InitializeComponent();
  }

  private void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs args)
  {
    if (DataContext is PhaseViewModel phaseViewModel)
    {
      if (args.AddedItems.Count > 0)
      {
        var selectedItem = args.AddedItems[0];
        if (selectedItem is TabItem tabItem)
        {
          if (tabItem.Content is TypeListView typeListView)
          {
            if (typeListView.DataContext == null)
            {
              phaseViewModel.InitTypes();
            }
          }
        }
      }
    }
  }
}
