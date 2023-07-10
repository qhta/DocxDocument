namespace ModelGenApp.ViewModels;
public class ClassListViewModel: TypeListViewModel
{
  public ClassListViewModel(NamespaceViewModel owner, string name): base(owner, name)
  {
  }

  public override IList Items { get; } = new DispatchedCollection<ClassInfoViewModel>();
}
