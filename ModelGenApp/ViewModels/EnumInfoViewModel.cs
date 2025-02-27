﻿namespace ModelGenApp.ViewModels;
public class EnumInfoViewModel : ViewModel<EnumInfo>, IAcceptable
{
  public EnumInfoViewModel(PhaseResultsViewModel phase, EnumTypeInfoViewModel? owner, EnumInfo enumInfo, TNS nameKindSelector) : base(enumInfo)
  {
    Owner = owner;
    Phase = phase;
    NameKindSelector = nameKindSelector;
  }

  public PhaseResultsViewModel Phase {get; private set; }

  public EnumTypeInfoViewModel? Owner { [DebuggerStepThrough] get; private set; }

  public TNS NameKindSelector {get; private set; }

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
      if (NameKindSelector.NTS == NTS.Target)
        return Model.NewName ?? Model.Name;
      return Model.Name;
    }
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.EnumValue),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.EnumValueTooltip)
  )]
  public int? Value => Model.Value;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Description),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.DescriptionTooltip)
    )]
  public string? Description => Model.Description;
}

