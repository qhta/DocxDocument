namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class TextOutlineEffect
{
  public bool ShouldSerializeLineWidth() => LineWidth is not null;
  public bool ShouldSerializeCapType() => CapType is not null;
  public bool ShouldSerializeCompound() => Compound is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
  public bool ShouldSerializeNoFillEmpty() => NoFillEmpty is not null;
  public bool ShouldSerializeSolidColorFillProperties() => SolidColorFillProperties is not null;
  public bool ShouldSerializeGradientFillProperties() => GradientFillProperties is not null;
  public bool ShouldSerializePresetLineDashProperties() => PresetLineDashProperties is not null;
  public bool ShouldSerializeRoundEmpty() => RoundEmpty is not null;
  public bool ShouldSerializeBevelEmpty() => BevelEmpty is not null;
  public bool ShouldSerializeLineJoinMiterProperties() => LineJoinMiterProperties is not null;
}
