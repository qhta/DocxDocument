namespace ModelGenApp.ViewModels;
public class SummaryViewModel: DispatchedCollection<SummaryValueViewModel>
{
  protected override void InsertItem(int index, SummaryValueViewModel item)
  {
    base.InsertItem(index, item);
    item.PropertyChanged += Item_PropertyChanged;
  }

  private void Item_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
  {
    if (e.PropertyName=="IsChecked")
    {
      var current = (SummaryValueViewModel?)sender;
      if (current != null) 
      { 
        var isChecked = current.IsChecked;
        if (isChecked)
        {
          foreach (var item in this)
          {
            if (item!=current)
              item.IsChecked = false;
          }
          Filter = current.InfoKind.ToString();
        }
      }
    }
  }

  public string? Filter
  {
    get { return _Filter; }
    set
    {
      if (_Filter != value)
      {
        _Filter = value;
        NotifyPropertyChanged(nameof(Filter));
      }
    }
  }
  private string? _Filter;
}
