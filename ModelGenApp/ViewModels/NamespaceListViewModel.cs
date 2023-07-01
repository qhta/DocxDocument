namespace ModelGenApp.ViewModels;
public class NamespaceListViewModel: DispatchedCollection<NamespaceViewModel>
{
  public NamespaceListViewModel(PhaseViewModel phase, NTS nts, string? filter)
  {
    Phase = phase;
    var namespaces = TypeManager.GetNamespaces(nts).OrderBy(item=>item);
    foreach (var ns in namespaces)
    {
      var nsVM = new NamespaceViewModel(phase, ns );
      var nsTypes = TypeManager.GetNamespaceTypes(ns).OrderBy(item=>item.Name).ToList();
      if (filter!=null)
      {
        if (filter == SummaryInfoKind.AcceptedTypes.ToString())
          nsTypes = nsTypes.Where(item => item.IsAccepted).ToList();
        if (filter == SummaryInfoKind.RejectedTypes.ToString())
          nsTypes = nsTypes.Where(item => item.IsRejected).ToList();
      }
      var nsTypesVM = nsTypes.Select(item=>new TypeInfoViewModel(item, nts.HasFlag(NTS.Origin))).ToList();
      nsVM.AllTypes.AddRange(nsTypesVM);
      Add(nsVM);
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

}
