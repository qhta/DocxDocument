namespace ModelGenApp.ViewModels;
public class EnumTypeListViewModel: TypeListViewModel<EnumTypeInfoViewModel>
{
  public EnumTypeListViewModel(PhaseResultsViewModel phase, NamespaceViewModel nspace, string name, 
    TNS typeNameSelector, TKS typeKindSelector, TypeInfoViewModelFilter? filter, TypeListViewModel<TypeInfoViewModel> source): 
    base(phase, nspace, name, typeNameSelector, typeKindSelector, filter, source)
  {
  }

  protected override TypeInfoViewModel CreateItemViewModel(TypeInfo item, PhaseResultsViewModel phase)
  {
    return new EnumTypeInfoViewModel(phase, item, TypeNameSelector);
  }

  protected override void AddRange(IEnumerable<TypeInfoViewModel> list)
  {
     (Items as ObservableList<EnumTypeInfoViewModel>)?.AddRange(list.Cast<EnumTypeInfoViewModel>());
  }
}
