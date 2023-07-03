namespace ModelGenApp.ViewModels;
public class TypeInfoViewModel : ViewModel<TypeInfo>
{
  public TypeInfoViewModel(TypeInfo typeInfo, bool original) : base(typeInfo)
  {
    Original = original;
  }

  public TypeKind? TypeKind => Model?.TypeKind;

  public bool Original { get; private set; }

  public string Name
  {
    get
    {
      var name = Model?.GetFullName(Original);
      if (name!=null)
      {
        var str= name.ToString();
        var k = str.IndexOf('.');
        if (k!=-1)
          str = str.Substring(k+1);
        return str;
      }
      return string.Empty;
    }
  }

}

