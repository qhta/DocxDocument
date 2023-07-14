namespace ModelGenApp.ViewModels;
public class ClassListViewModel: TypeListViewModel
{
  public ClassListViewModel(NamespaceViewModel owner, string name, NTS nameTypeSelector, TKS typeKindSelector): 
    base(owner, name, nameTypeSelector, typeKindSelector)
  {
  }

  public override IList Items { get; } = new DispatchedCollection<ClassInfoViewModel>();

  protected override TypeInfoViewModel CreateItemViewModel(TypeInfo item)
  {
    return new ClassInfoViewModel(item, NameTypeSelector.HasFlag(NTS.Origin));
  }
}
