namespace ModelGenApp.ViewModels;
public class PhaseSummaryViewModel : ObservableList<PhaseSummaryInfoViewModel>
{
  public PhaseSummaryViewModel()
  {
    CollectionChanged += SummaryViewModel_CollectionChanged;
  }

  private void SummaryViewModel_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    IEnumerable<PhaseSummaryInfoViewModel> collection;
    if (args.NewItems != null)
      collection = args.NewItems.Cast<PhaseSummaryInfoViewModel>();
    else
      collection = this._Items.Cast<PhaseSummaryInfoViewModel>();
    foreach (var item in collection)
      item.PropertyChanged += Item_PropertyChanged;
  }

  private void Item_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs args)
  {
    if (args.PropertyName == "IsChecked")
    {
      var current = (PhaseSummaryInfoViewModel?)sender;
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
        if (current.IsChecked)
          Filter = current.InfoKind;
        else
          Filter = null;
      }
    }
  }

  public SummaryInfoKind? Filter
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
  private SummaryInfoKind? _Filter;
}
