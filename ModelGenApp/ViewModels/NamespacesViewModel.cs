namespace ModelGenApp.ViewModels;

public class NamespacesViewModel : ObservableList<NamespaceViewModel>
{
  public NamespacesViewModel(PhaseViewModel phase, NTS namespacesTypeSelector, SummaryInfoKind? filter)
  {
    Phase = phase;
    NamespacesTypeSelector = namespacesTypeSelector;
    Filter = filter;
    FillItems();
  }

  public PhaseViewModel Phase { get; private set; }

  public NTS NamespacesTypeSelector { get; private set; }

  public SummaryInfoKind? Filter { get; private set; }

  public void FillItems() // We can't populate it asynchronously
  {
    Clear();
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
    AddRange(viewModels);
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
      if (!this.Any(item => item.Model == ns))
        newNamespaces.Add(ns);

    foreach (var nsVM in this)
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
    AddRange(viewModels);
  }

  public bool IsTargetNameVisible => Phase.IsTargetNameVisible;

}
