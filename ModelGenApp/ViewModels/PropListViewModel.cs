namespace ModelGenApp.ViewModels;
public class PropListViewModel : MemberListViewModel<PropInfoViewModel>
{
  public PropListViewModel(ClassInfoViewModel owner, string name, NKS typeNameSelector): base(owner, name)
  {
    ShowDisplayOptions = true;
  }

}
