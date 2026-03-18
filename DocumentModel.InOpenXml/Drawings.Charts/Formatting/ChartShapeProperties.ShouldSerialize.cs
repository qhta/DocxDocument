namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class ChartShapeProperties
{
  public bool ShouldSerializeBlackWhiteMode() => BlackWhiteMode is not null;
  public bool ShouldSerializeTransform2D() => Transform2D is not null;
  public bool ShouldSerializeCustomGeometry() => CustomGeometry is not null;
  public bool ShouldSerializePresetGeometry() => PresetGeometry is not null;
  public bool ShouldSerializeFill() => Fill is not null;
  public bool ShouldSerializeOutline() => Outline is not null;
  public bool ShouldSerializeEffectList() => EffectList is not null && EffectList.Count > 0;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
  public bool ShouldSerializeScene3DType() => Scene3DType is not null;
  public bool ShouldSerializeShape3DType() => Shape3DType is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
