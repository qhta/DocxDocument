namespace ModelGenApp.ViewModels;
public class PropListViewModel : MemberListViewModel<PropInfoViewModel>, IFilter<PropInfoViewModel>
{
  public PropListViewModel(ClassInfoViewModel owner, string name, TNS typeNameSelector): base(owner, name)
  {
    ShowDisplayOptions = true;
    TypeNameSelector = typeNameSelector; 
    _Predicate = new Predicate<PropInfoViewModel>(item=> item.Model.IsAcceptedAfter(owner.Phase.PhaseNum));
    _ObjectPredicate = new Predicate<object>(item=> (item is PropInfoViewModel vm) && _Predicate.Invoke(vm));
  }

  public TNS TypeNameSelector { get; private set; }

  public bool ShowFullTypeName
  {
    get => TypeNameSelector.Namespace;
    set
    {
      if (TypeNameSelector.Namespace != value)
      {
        TypeNameSelector.Namespace = value;
        foreach (var prop in this)
          prop.ShowFullTypeName = this.ShowFullTypeName;
      }
    }
  }

  protected override void ApplyAcceptedOnlyFilter(bool value)
  {
    if (value)
      VisibleItems.Filter = this as IFilter<PropInfoViewModel>;
    else
      VisibleItems.Filter = null;
  }

  Predicate<PropInfoViewModel> IFilter<PropInfoViewModel>.GetPredicate() => _Predicate;

  bool IFilter<PropInfoViewModel>.Accept(PropInfoViewModel item) => _Predicate.Invoke(item);

  Predicate<object> IFilter.GetPredicate() => _ObjectPredicate;

  bool IFilter.Accept(object item) => _ObjectPredicate.Invoke(item);

  private Predicate<PropInfoViewModel> _Predicate;

  private Predicate<object> _ObjectPredicate;

}
