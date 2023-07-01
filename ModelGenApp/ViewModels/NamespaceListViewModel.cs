namespace ModelGenApp.ViewModels;
public class NamespaceListViewModel: DispatchedCollection<NamespaceViewModel>
{
  public NamespaceListViewModel(PhaseViewModel phase, NTS filter)
  {
    Phase = phase;
    var namespaces = TypeManager.GetNamespaces(filter).OrderBy(item=>item);
    foreach (var ns in namespaces)
    {
      var nsVM = new NamespaceViewModel(phase, ns );
      var nsTypes = TypeManager.GetNamespaceTypes(ns).OrderBy(item=>item.Name)
        .Select(item=>new TypeInfoViewModel(item, filter.HasFlag(NTS.Origin))).ToList();
      nsVM.AllTypes.AddRange(nsTypes);
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
