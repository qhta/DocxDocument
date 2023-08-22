namespace ModelGenApp.ViewModels;
public class EnumInfoViewModel : ViewModel<EnumInfo>, IAcceptable
{
  public EnumInfoViewModel(PhaseViewModel phase, EnumInfo enumInfo, NKS typeNameSelector) : base(enumInfo)
  {
    Phase = phase;
    NameTypeSelector = typeNameSelector;
  }

  public PhaseViewModel Phase {get; private set; }

  public NKS NameTypeSelector {get; private set; }

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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.EnumValName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.EnumValNameTooltip)
  )]
  public string Name
  {
    get
    {
      if (NameTypeSelector.Target)
        return Model.NewName ?? Model.Name;
      return Model.Name;

    }
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.EnumValue),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.EnumValueTooltip)
  )]
  public int? Value => Model.Value;

}

