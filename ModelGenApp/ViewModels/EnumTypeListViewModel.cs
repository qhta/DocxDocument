namespace ModelGenApp.ViewModels;
public class EnumTypeListViewModel: TypeListViewModel
{
  public EnumTypeListViewModel(PhaseViewModel phase, NamespaceViewModel nspace, string name, 
    NKS typeNameSelector, TKS typeKindSelector, SummaryInfoKind? filter, TypeListViewModel source): 
    base(phase, nspace, name, typeNameSelector, typeKindSelector, filter, source)
  {
  }

  public override IList Items { get; } = new ObservableList<EnumTypeInfoViewModel>();

  protected override TypeInfoViewModel CreateItemViewModel(TypeInfo item, PhaseViewModel phase)
  {
    return new EnumTypeInfoViewModel(phase, item, TypeNameSelector);
  }

  protected override void AddRange(IEnumerable<TypeInfoViewModel> list)
  {
     (Items as ObservableList<EnumTypeInfoViewModel>)?.AddRange(list.Cast<EnumTypeInfoViewModel>());
  }
}
