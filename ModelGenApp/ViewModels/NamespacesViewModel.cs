namespace ModelGenApp.ViewModels;

public class NamespacesViewModel : ViewModel
{
  public NamespacesViewModel(PhaseResultsViewModel phase, NTS namespacesTypeSelector, TypeInfoFilter? filter)
  {
    Phase = phase;
    NamespacesTypeSelector = namespacesTypeSelector;
    Filter = filter;
    Items = new ObservableList<NamespaceViewModel>();
    FillItems();
  }

  public ObservableList<NamespaceViewModel> Items {get; private set;}

  public PhaseResultsViewModel Phase { get; private set; }

  public NTS NamespacesTypeSelector { get; private set; }

  public TypeInfoFilter? Filter { get; private set; }

  public void FillItems() // We can't populate it asynchronously
  {
    Items.Clear();
    var namespaces = new List<Namespace>();
    if (NamespacesTypeSelector.HasFlag(NTS.Origin))
      namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("DocumentFormat")).Select(item => item.Value));
    else if (NamespacesTypeSelector.HasFlag(NTS.Target))
      namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("DocumentModel")).Select(item => item.Value));
    if (NamespacesTypeSelector.HasFlag(NTS.System))
      namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("System")).Select(item => item.Value));
    var viewModels = new List<NamespaceViewModel>();
    foreach (var ns in namespaces)
    {
      var nsVM = new NamespaceViewModel(Phase, ns, Filter);
      viewModels.Add(nsVM);
      nsVM.FillTypesAsync();
    }
    Items.AddRange(viewModels);
  }

  public async void RefreshItemsAsync()
  {
    await Task.Run(() => RefreshItems() );
  }

  public void RefreshItems()
  {
    var namespaces = new List<Namespace>();
    if (NamespacesTypeSelector.HasFlag(NTS.Origin))
      namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("DocumentFormat")).Select(item => item.Value));
    else if (NamespacesTypeSelector.HasFlag(NTS.Target))
      namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("DocumentModel")).Select(item => item.Value));
    if (NamespacesTypeSelector.HasFlag(NTS.System))
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
  }

  public bool IsTargetNameVisible => Phase.IsTargetNameVisible;

}
