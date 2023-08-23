namespace ModelGenApp.ViewModels;
public class PropInfoViewModel : ViewModel<PropInfo>, IAcceptable
{
  public PropInfoViewModel(PhaseViewModel phase, ClassInfoViewModel? ownerViewModel, PropInfo propInfo, NKS nameKindSelector) : base(propInfo)
  {
    OwnerType = ownerViewModel;
    NameKindSelector = nameKindSelector;
    Phase = phase;
    if (ownerViewModel?.Properties?.ShowDeclaringType == true && propInfo.DeclaringType != null)
      DeclaringType = TypeInfoViewModel.Create(phase, propInfo.DeclaringType, nameKindSelector);
  }

  public TypeInfoViewModel? OwnerType { get; private set; }

  public NKS NameKindSelector { get; private set; }

  public PhaseViewModel Phase { get; private set; }

  public bool IsAccepted => Model.IsAcceptedAfter(Phase.PhaseNum);

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Acceptance),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.AcceptanceTooltip)
    )]
  public Acceptance Acceptance
  {
    get
    {
      Acceptance result = 0;
      if (Model.IsAcceptedAfter(Phase.PhaseNum))
        result |= Acceptance.accepted;
      if (Model.IsRejectedAfter(Phase.PhaseNum))
        result |= Acceptance.rejected;
      return result;
    }
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.DeclaringType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.DeclaringTypeTooltip),
    DataTemplateResourceKey = "TypeInfoLinkTemplate",
    SortMemberPath = "DeclaringType.FullName", 
    ClipboardContentPath = "DeclaringType.FullName")]
  public TypeInfoViewModel? DeclaringType
  {
    get; set;
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.PropertyName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.PropertyNameTooltip)
    )]
  public string Name
  {
    get
    {
      if (NameKindSelector.Target)
        return Model.GetTargetName();
      return Model.Name;
    }
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ValueType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ValueTypeTooltip),
    DataTemplateResourceKey = "TypeInfoLinkTemplate",
    SortMemberPath = "Type.FullName", 
    ClipboardContentPath = "Type.FullName")]
  public TypeInfoViewModel? ValueType
  {
    get
    {
      var propType = Model.PropertyType;
      if (propType!=null)
      {
        if (propType.TypeKind == TypeKind.@enum)
          return new EnumTypeInfoViewModel(Phase, propType, NameKindSelector);
        if (propType.TypeKind == TypeKind.type)
          return TypeInfoViewModel.Create(Phase, propType, NameKindSelector);
        return new ClassInfoViewModel(Phase, propType, NameKindSelector);
      }
      return null;
    }
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Description),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.DescriptionTooltip)
    )]
  public string? Description => Model.Description;
}

