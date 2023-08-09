namespace ModelGenApp.ViewModels;
public class NamespacesViewModel : ObservableList<NamespaceViewModel>
{
  public NamespacesViewModel(PhaseViewModel phase, NTS namespacesTypeSelector, string? filter)
  {
    Phase = phase;
    NamespacesTypeSelector = namespacesTypeSelector;
    Filter = filter;
  }

  public PhaseViewModel Phase { get; private set; }

  public NTS NamespacesTypeSelector { get; private set; }

  public string? Filter { get; private set; }



  public void Populate() // We can't populate it asynchronously
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
      nsVM.LoadTypesAsync();
    }
    AddRange(viewModels);
  }

  public bool IsTargetNameVisible => Phase.IsTargetNameVisible;

}
