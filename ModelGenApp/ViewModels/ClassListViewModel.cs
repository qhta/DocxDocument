namespace ModelGenApp.ViewModels;
public class ClassListViewModel: TypeListViewModel
{
  public ClassListViewModel(PhaseViewModel phase, NamespaceViewModel nspace, string name, TNS typeNameSelector, TKS typeKindSelector): 
    base(phase, nspace, name, typeNameSelector, typeKindSelector)
  {
  }

  public override IList Items { get; } = new DispatchedCollection<ClassInfoViewModel>();

  protected override TypeInfoViewModel CreateItemViewModel(TypeInfo item, PhaseViewModel phase)
  {
    return new ClassInfoViewModel(phase, item, TypeNameSelector);
  }
}
