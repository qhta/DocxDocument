namespace ModelGenApp.ViewModels;

public class NamespacesViewModel : ViewModel
{
  public NamespacesViewModel(PhaseResultsViewModel phase, TypeInfoViewModelFilter? filter)
  {
    Phase = phase;
    Filter = filter;
    Items = new ObservableList<NamespaceViewModel>();
    FillItemsAsync();
  }

  public ObservableList<NamespaceViewModel> Items { get; private set; }

  public PhaseResultsViewModel Phase { get; private set; }

  public NTS NamespacesSelector => Phase.NamespacesSelector;

  public TNS TypeNameSelector => Phase.TypeNameSelector;

  public bool ShowTargetsOnlyEnabled => Phase.ShowTargetsOnlyEnabled;

  public bool ShowTargetsOnly { get => Phase.ShowTargetsOnly; set => Phase.ShowTargetsOnly = value; }

  public bool ShowOriginalName => !TypeNameSelector.Target;
  public bool ShowTargetName => NamespacesSelector.HasFlag(NTS.Target);

  public TypeInfoViewModelFilter? Filter
  {
    get { return _Filter; }
    set
    {
      if (_Filter != value)
      {
        _Filter = value;
        NotifyPropertyChanged(nameof(Filter));
        ApplyFilter();
      }
    }
  }
  private TypeInfoViewModelFilter? _Filter;

  public void ApplyFilter()
  {
    Debug.WriteLine($"NamespacesViewModel.ApplyFilter");
    if (Items!=null)
      foreach (var item in Items)
        item.Filter = Filter;
  }

  public async void FillItemsAsync()
  {
    Debug.WriteLine($"NamespacesViewModel.FillItemsAsync");
    await Task.Factory.StartNew(() => FillItems());
  }

  public void FillItems()
  {
    Debug.WriteLine($"NamespacesViewModel.FillItems.Start at {DateTime.Now.TimeOfDay}");
    Items.Clear();
    var namespaces = new List<Namespace>();
    lock (TypeManager.KnownNamespaces)
    {

      if (TypeNameSelector.Target)
        namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("DocumentModel")).Select(item => item.Value));
      else
        namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("DocumentFormat")).Select(item => item.Value));
      if (NamespacesSelector.HasFlag(NTS.System))
        namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("System")).Select(item => item.Value));
    }
    var viewModels = new List<NamespaceViewModel>();
    foreach (var ns in namespaces)
    {
      var nsVM = new NamespaceViewModel(Phase, ns, Filter);
      viewModels.Add(nsVM); 
    }
    Items.AddRange(viewModels);
    foreach (var nsVM in viewModels) 
      nsVM.FillTypesAsync();
    Debug.WriteLine($"NamespacesViewModel.FillItems.End  at {DateTime.Now.TimeOfDay}");
  }

  public async void RefreshItemsAsync()
  {
    Debug.WriteLine($"NamespacesViewModel.RefreshItemsAsync");
    await Task.Factory.StartNew(() => RefreshItems());
  }

  public void RefreshItems()
  {
    Debug.WriteLine($"NamespacesViewModel.RefreshItems.Start at {DateTime.Now.TimeOfDay}");
    var namespaces = new List<Namespace>();
    if (TypeNameSelector.Target)
      namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("DocumentModel")).Select(item => item.Value));
    else
      namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("DocumentFormat")).Select(item => item.Value));
    if (NamespacesSelector.HasFlag(NTS.System))
      namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("System")).Select(item => item.Value));
    var newNamespaces = new List<Namespace>();
    foreach (var ns in namespaces)
      if (!Items.Any(item => item.Model == ns))
        newNamespaces.Add(ns);

    foreach (var nsVM in Items)
    {
      nsVM.RefreshAsync();
    }

    var viewModels = new List<NamespaceViewModel>();
    foreach (var ns in newNamespaces)
    {
      var nsVM = new NamespaceViewModel(Phase, ns, Filter);
      viewModels.Add(nsVM);
      nsVM.FillTypesAsync();
    }
    Items.AddRange(viewModels);
    Debug.WriteLine($"NamespacesViewModel.RefreshItems.End at {DateTime.Now.TimeOfDay}");
  }

  public bool IsTargetNameVisible => Phase.IsTargetNameVisible;

}
