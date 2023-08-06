namespace ModelGenApp.ViewModels;
public class PropListViewModel : MemberListViewModel<PropInfoViewModel>
{
  public PropListViewModel(ClassInfoViewModel owner, string name): base(owner, name)
  {
    ShowAcceptedOnlyVisible = true;
    ShowDeclaringTypeVisible = true;
  }

}
