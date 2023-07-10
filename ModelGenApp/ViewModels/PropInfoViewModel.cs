namespace ModelGenApp.ViewModels;
public class PropInfoViewModel : ViewModel<PropInfo>
{
  public PropInfoViewModel(PropInfo propInfo, bool isOriginal) : base(propInfo)
  {
    IsOriginal = isOriginal;
  }

  public bool IsOriginal { get; set; }

  [DataGridColumn]
  public string? Acceptance
  {
    get
    {
      if (Model.IsAccepted)
        return "accepted";
      if (Model.IsRejected)
        return "rejected";
      return null;
    }
  }

  [DataGridColumn]
  public string Name
  {
    get
    {
      if (IsOriginal)
        return Model.Name;
      return Model.GetTargetName();
    }
  }

  [DataGridColumn(ResourceDataTemplateKey = "TypeInfoColumnTemplate",
    SortMemberPath = "Type.FullName", ClipboardContentPath = "Type.FullName")]
  public TypeInfoViewModel? Type
  {
    get
    {
      var propType = Model.PropertyType;
      if (propType!=null)
      {
        if (propType.TypeKind == TypeKind.Enum)
          return new EnumTypeInfoViewModel(propType, IsOriginal);
        if (propType.TypeKind == TypeKind.Type)
          return new TypeInfoViewModel(propType, IsOriginal);
        return new ClassInfoViewModel(propType, IsOriginal);
      }
      return null;
    }
  }

}

