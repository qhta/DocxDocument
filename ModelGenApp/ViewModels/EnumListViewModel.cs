namespace ModelGenApp.ViewModels;
public class EnumListViewModel: MemberListViewModel<EnumInfoViewModel>
{
  public EnumListViewModel(EnumTypeInfoViewModel owner, string name): base(owner, name)
  {
  }

}
