namespace ModelGenApp.ViewModels;
public class NamespaceListViewModel : DispatchedCollection<NamespaceViewModel>
{
  public NamespaceListViewModel(PhaseViewModel phase, NTS nts, string? filter)
  {
    Phase = phase;
    var namespaces = new List<Namespace>();
    if (nts.HasFlag(NTS.Origin))
      namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("DocumentFormat")).Select(item => item.Value));
    else if (nts.HasFlag(NTS.Target))
      namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("DocumentModel")).Select(item => item.Value));
    if (nts.HasFlag(NTS.System))
      namespaces.AddRange(TypeManager.KnownNamespaces.Where(item => item.Key.StartsWith("System")).Select(item => item.Value));
    foreach (var ns in namespaces)
    {
      var nsVM = new NamespaceViewModel(phase, ns, filter);
      Add(nsVM);
      nsVM.LoadTypes();
    }
  }

  public PhaseViewModel Phase { get; private set; }

  public NTS Kind
  {
    get { return _Kind; }
    set
    {
      if (_Kind != value)
      {
        _Kind = value;
        NotifyPropertyChanged(nameof(Kind));
      }
    }
  }
  private NTS _Kind;

  public bool IsTargetNameVisible => Phase.IsTargetNameVisible;
}
