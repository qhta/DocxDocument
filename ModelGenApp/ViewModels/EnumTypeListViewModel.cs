namespace ModelGenApp.ViewModels;
public class EnumTypeListViewModel: TypeListViewModel
{
  public EnumTypeListViewModel(NamespaceViewModel owner, string name): base(owner, name)
  {
  }

  public override IList Items { get; } = new DispatchedCollection<EnumTypeInfoViewModel>();
}
