namespace DocumentModel.Drawings.Pictures;
#pragma warning disable CS1591
public partial class ShapeProperties
{
  public bool ShouldSerializeBlackWhiteMode() => BlackWhiteMode is not null;
  public bool ShouldSerializeTransform2D() => Transform2D is not null;
  public bool ShouldSerializeCustomGeometry() => CustomGeometry is not null;
  public bool ShouldSerializePresetGeometry() => PresetGeometry is not null;
  public bool ShouldSerializeNoFill() => NoFill is not null;
  public bool ShouldSerializeSolidFill() => SolidFill is not null;
  public bool ShouldSerializeGradientFill() => GradientFill is not null;
  public bool ShouldSerializeBlipFill() => BlipFill is not null;
  public bool ShouldSerializePatternFill() => PatternFill is not null;
  public bool ShouldSerializeGroupFill() => GroupFill is not null;
  public bool ShouldSerializeOutline() => Outline is not null;
  public bool ShouldSerializeEffectList() => EffectList is not null;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
  public bool ShouldSerializeScene3DType() => Scene3DType is not null;
  public bool ShouldSerializeShape3DType() => Shape3DType is not null;
  public bool ShouldSerializeShapePropertiesExtensionList() => ShapePropertiesExtensionList is not null;
}
