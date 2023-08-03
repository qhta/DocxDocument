namespace ModelGenApp.ViewModels;
public class PropInfoViewModel : ViewModel<PropInfo>
{
  public PropInfoViewModel(PhaseViewModel phase, TypeInfoViewModel? ownerViewModel, PropInfo propInfo, NKS nameKindSelector) : base(propInfo)
  {
    OwnerType = ownerViewModel;
    NameKindSelector = nameKindSelector;
    Phase = phase;
    if (propInfo.DeclaringType!= null && propInfo.DeclaringType != ownerViewModel?.Model)
      DeclaringType = TypeInfoViewModel.Create(phase, propInfo.DeclaringType, nameKindSelector);
  }

  public TypeInfoViewModel? OwnerType { get; private set; }

  public NKS NameKindSelector { get; private set; }

  public PhaseViewModel Phase { get; private set; }

  [DataGridColumn]
  public string Acceptance
  {
    get
    {
      if (Model.IsAcceptedAfter(Phase.PhaseNum))
        return "accepted";
      else return "rejected";
    }
  }

  [DataGridColumn(ResourceDataTemplateKey = "TypeInfoLinkTemplate",
    SortMemberPath = "DeclaringType.FullName", ClipboardContentPath = "DeclaringType.FullName")]
  public TypeInfoViewModel? DeclaringType
  {
    get; set;
  }

  [DataGridColumn]
  public string Name
  {
    get
    {
      if (NameKindSelector.Target)
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
          return new EnumTypeInfoViewModel(Phase, propType, NameKindSelector);
        if (propType.TypeKind == TypeKind.Type)
          return TypeInfoViewModel.Create(Phase, propType, NameKindSelector);
        return new ClassInfoViewModel(Phase, propType, NameKindSelector);
      }
      return null;
    }
  }

}

