namespace ModelGenApp.ViewModels;
public class EnumTypeListViewModel: TypeListViewModel
{
  public EnumTypeListViewModel(PhaseViewModel phase, NamespaceViewModel nspace, string name, NKS typeNameSelector, TKS typeKindSelector): 
    base(phase, nspace, name, typeNameSelector, typeKindSelector)
  {
  }

  public override IList Items { get; } = new DispatchedCollection<EnumTypeInfoViewModel>();

  protected override TypeInfoViewModel CreateItemViewModel(TypeInfo item, PhaseViewModel phase)
  {
    return new EnumTypeInfoViewModel(phase, item, TypeNameSelector);
  }
}
