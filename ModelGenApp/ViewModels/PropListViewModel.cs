namespace ModelGenApp.ViewModels;
public class PropListViewModel : MemberListViewModel<PropInfoViewModel>
{
  public PropListViewModel(ClassInfoViewModel owner, string name, NKS typeNameSelector): base(owner, name)
  {
    ShowDisplayOptions = true;
    TypeNameSelector = typeNameSelector; 
  }

  public NKS TypeNameSelector { get; private set; }

  public bool ShowFullTypeName
  {
    get => TypeNameSelector.Namespace;
    set
    {
      if (TypeNameSelector.Namespace != value)
      {
        TypeNameSelector.Namespace = value;
        foreach (var prop in this)
          prop.ShowFullTypeName = this.ShowFullTypeName;
      }
    }
  }
}
