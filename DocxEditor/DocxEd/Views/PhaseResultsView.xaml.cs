namespace DocxEd.Views;

public partial class PhaseResultsView : UserControl
{
  public PhaseResultsView()
  {
    InitializeComponent();
  }

  private void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs args)
  {
    if (DataContext is PhaseResultsViewModel phaseViewModel)
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
          else
          if (tabItem.Content is PropListView propListView)
          {
            if (propListView.DataContext == null)
            {
              phaseViewModel.InitProperties();
            }
          }
        }
      }
    }
  }
}
