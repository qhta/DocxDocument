namespace ModelGenApp.ViewModels;
public class TypeInfoViewModel : ViewModel<TypeInfo>
{
  public TypeInfoViewModel(TypeInfo typeInfo, bool original) : base(typeInfo)
  {
    Original = original;
  }

  public TypeKind? TypeKind => Model?.TypeKind;

  public bool Original { get; private set; }

  public new string Name
  {
    get
    {
      var str = Model?.GetFullName(Original);
      if (str!=null)
        return str.Name;
      return string.Empty;
    }
  }

}

