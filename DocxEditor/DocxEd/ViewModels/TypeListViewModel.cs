namespace DocxEd.ViewModels;

public class TypeListViewModel: TypeListViewModel<TypeInfoViewModel>
{
  public TypeListViewModel(PhaseResultsViewModel phase, NamespaceViewModel? nspace, string name,
    TNS typeNameSelector, TKS typeKindSelector, TypeInfoViewModelFilter? filter, TypeListViewModel<TypeInfoViewModel>? source = null):
    base(phase, nspace, name, typeNameSelector, typeKindSelector, filter, source)
  {
  }

}
