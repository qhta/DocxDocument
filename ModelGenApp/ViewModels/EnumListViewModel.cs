namespace ModelGenApp.ViewModels;
public class EnumListViewModel: MemberListViewModel<EnumInfoViewModel>, IFilter<EnumInfoViewModel>
{
  public EnumListViewModel(PhaseResultsViewModel phase, EnumTypeInfoViewModel? owner, string name): base(phase, owner, name)
  {
    _Predicate = new Predicate<EnumInfoViewModel>(item=> item.Model.IsAcceptedAfter(Phase.PhaseNum));
    _ObjectPredicate = new Predicate<object>(item=> (item is EnumInfoViewModel vm) && _Predicate.Invoke(vm));
    ShowDisplayOptions = true;
  }

  protected override void ApplyAcceptedOnlyFilter(bool value)
  {
    if (value)
      VisibleItems.Filter = this as IFilter<EnumInfoViewModel>;
    else
      VisibleItems.Filter = null;
  }

  Predicate<EnumInfoViewModel> IFilter<EnumInfoViewModel>.GetPredicate() => _Predicate;

  bool IFilter<EnumInfoViewModel>.Accept(EnumInfoViewModel item) => _Predicate.Invoke(item);

  Predicate<object> IFilter.GetPredicate() => _ObjectPredicate;

  bool IFilter.Accept(object item) => _ObjectPredicate.Invoke(item);

  private Predicate<EnumInfoViewModel> _Predicate;

  private Predicate<object> _ObjectPredicate;
}
