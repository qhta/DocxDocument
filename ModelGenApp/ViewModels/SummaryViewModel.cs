namespace ModelGenApp.ViewModels;
public class SummaryViewModel : ObservableList<SummaryValueViewModel>
{
  public SummaryViewModel()
  {
    CollectionChanged += SummaryViewModel_CollectionChanged;
  }

  private void SummaryViewModel_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    IEnumerable<SummaryValueViewModel> collection;
    if (args.NewItems != null)
      collection = args.NewItems.Cast<SummaryValueViewModel>();
    else
      collection = this._items.Cast<SummaryValueViewModel>();
    foreach (var item in collection)
      item.PropertyChanged += Item_PropertyChanged;
  }

  private void Item_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
  {
    if (e.PropertyName == "IsChecked")
    {
      var current = (SummaryValueViewModel?)sender;
      if (current != null)
      {
        var isChecked = current.IsChecked;
        if (isChecked)
        {
          foreach (var item in this)
          {
            if (item != current)
              item.IsChecked = false;
          }
        }
        Filter = current.InfoKind.ToString();
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
