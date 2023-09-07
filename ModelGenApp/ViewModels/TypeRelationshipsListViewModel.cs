namespace ModelGenApp.ViewModels;
public class TypeRelationshipsListViewModel: ItemListViewModel<TypeRelationshipViewModel>, IFilter<TypeRelationshipViewModel>
{
  public TypeRelationshipsListViewModel(PhaseResultsViewModel phase, TypeInfoViewModel? owner, string name, TNS typeNameSelector) : base(phase, owner, name)
  {
    _Predicate = new Predicate<TypeRelationshipViewModel>(item => item.Model.Target.IsAcceptedAfter(Phase.PhaseNum));
    _ObjectPredicate = new Predicate<object>(item => (item is TypeRelationshipViewModel vm) && _Predicate.Invoke(vm));
    ShowDisplayOptions = true;
    TypeNameSelector = typeNameSelector;
  }

  public TNS TypeNameSelector { get; private set; }

  public new bool ShowAcceptedOnly
  {
    get => base.ShowAcceptedOnly;
    set => base.ShowAcceptedOnly = value;
  }

  public bool ShowFullTypeName
  {
    get => TypeNameSelector.Namespace;
    set
    {
      if (TypeNameSelector.Namespace != value)
      {
        TypeNameSelector.Namespace = value;
        foreach (var item in this)
          item.ShowFullTypeName = this.ShowFullTypeName;
      }
    }
  }

  protected override void ApplyAcceptedOnlyFilter(bool value)
  {
    if (value)
      VisibleItems.Filter = this as IFilter<EnumInfoViewModel>;
    else
      VisibleItems.Filter = null;
  }

  Predicate<TypeRelationshipViewModel> IFilter<TypeRelationshipViewModel>.GetPredicate() => _Predicate;

  bool IFilter<TypeRelationshipViewModel>.Accept(TypeRelationshipViewModel item) => _Predicate.Invoke(item);

  Predicate<object> IFilter.GetPredicate() => _ObjectPredicate;

  bool IFilter.Accept(object item) => _ObjectPredicate.Invoke(item);

  private Predicate<TypeRelationshipViewModel> _Predicate;

  private Predicate<object> _ObjectPredicate;
}
