namespace DocumentModel.Drawings;

public partial class LineProperties
{
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeCapType() => CapType is not null;
  public bool ShouldSerializeCompoundLineType() => CompoundLineType is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
  public bool ShouldSerializeFill() => Fill is not null;
  public bool ShouldSerializePresetDash() => PresetDash is not null;
  public bool ShouldSerializeCustomDash() => CustomDash is not null;
  public bool ShouldSerializeMiter() => Miter is not null;
  public bool ShouldSerializeHeadEnd() => HeadEnd is not null;
  public bool ShouldSerializeTailEnd() => TailEnd is not null;
  public bool ShouldSerializeLinePropertiesExtensionList() => LinePropertiesExtensionList is not null;
}
