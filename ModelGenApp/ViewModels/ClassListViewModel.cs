namespace ModelGenApp.ViewModels;
public class ClassListViewModel: TypeListViewModel
{
  public ClassListViewModel(PhaseViewModel phase, NamespaceViewModel nspace, string name, 
    NKS typeNameSelector, TKS typeKindSelector, SummaryInfoKind? filter, TypeListViewModel source): 
    base(phase, nspace, name, typeNameSelector, typeKindSelector, filter, source)
  {
  }

  public override IList Items { get; } = new ObservableList<ClassInfoViewModel>();

  protected override TypeInfoViewModel CreateItemViewModel(TypeInfo item, PhaseViewModel phase)
  {
    return new ClassInfoViewModel(phase, item, TypeNameSelector);
  }

  protected override void AddRange(IEnumerable<TypeInfoViewModel> list)
  {
     (Items as ObservableList<ClassInfoViewModel>)?.AddRange(list.Cast<ClassInfoViewModel>());
  }
}
