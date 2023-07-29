namespace ModelGenApp.ViewModels;
public class PropInfoViewModel : ViewModel<PropInfo>
{
  public PropInfoViewModel(PhaseViewModel phase, TypeInfoViewModel ownerType, PropInfo propInfo, TNS typeNameSelector) : base(propInfo)
  {
    OwnerType = ownerType;
    TypeNameSelector = typeNameSelector;
    Phase = phase;
  }

  public TypeInfoViewModel OwnerType { get; private set; }

  public TNS TypeNameSelector { get; private set; }

  public PhaseViewModel Phase { get; private set; }

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
      if (TypeNameSelector.Target)
        return Model.GetTargetName();
      return Model.Name;
    }
  }

  [DataGridColumn(ResourceDataTemplateKey = "TypeInfoLinkTemplate",
    SortMemberPath = "Type.FullName", ClipboardContentPath = "Type.FullName")]
  public TypeInfoViewModel? Type
  {
    get
    {
      var propType = Model.PropertyType;
      if (propType!=null)
      {
        if (propType.TypeKind == TypeKind.Enum)
          return new EnumTypeInfoViewModel(Phase, propType, TypeNameSelector);
        if (propType.TypeKind == TypeKind.Type)
          return new TypeInfoViewModel(Phase, propType, TypeNameSelector);
        return new ClassInfoViewModel(Phase, propType, TypeNameSelector);
      }
      return null;
    }
  }

}

