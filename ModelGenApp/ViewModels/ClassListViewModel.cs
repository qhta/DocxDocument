namespace ModelGenApp.ViewModels;
public class ClassListViewModel: TypeListViewModel<ClassInfoViewModel>
{
  public ClassListViewModel(PhaseResultsViewModel phase, NamespaceViewModel nspace, string name, 
    TNS typeNameSelector, TKS typeKindSelector, TypeInfoViewModelFilter? filter, TypeListViewModel<TypeInfoViewModel> source): 
    base(phase, nspace, name, typeNameSelector, typeKindSelector, filter, source)
  {
  }

  protected override TypeInfoViewModel CreateItemViewModel(TypeInfo item, PhaseResultsViewModel phase)
  {
    return new ClassInfoViewModel(phase, item, TypeNameSelector);
  }

  protected override void AddRange(IEnumerable<TypeInfoViewModel> list)
  {
     (Items as ObservableList<ClassInfoViewModel>)?.AddRange(list.Cast<ClassInfoViewModel>());
  }
}
