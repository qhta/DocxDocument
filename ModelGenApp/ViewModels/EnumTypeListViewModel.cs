namespace ModelGenApp.ViewModels;
public class EnumTypeListViewModel: TypeListViewModel
{
  public EnumTypeListViewModel(NamespaceViewModel owner, string name, NTS nameTypeSelector, TKS typeKindSelector): 
    base(owner, name, nameTypeSelector, typeKindSelector)
  {
  }

  public override IList Items { get; } = new DispatchedCollection<EnumTypeInfoViewModel>();

  protected override TypeInfoViewModel CreateItemViewModel(TypeInfo item)
  {
    return new EnumTypeInfoViewModel(item, NameTypeSelector.HasFlag(NTS.Origin));
  }
}
