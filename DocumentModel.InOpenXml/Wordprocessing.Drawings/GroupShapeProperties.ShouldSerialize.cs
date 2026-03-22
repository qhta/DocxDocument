namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class GroupShapeProperties
{
  public bool ShouldSerializeBlackWhiteMode() => BlackWhiteMode is not null;
  public bool ShouldSerializeTransformGroup() => TransformGroup is not null;
  public bool ShouldSerializeFill() => Fill is not null;
  public bool ShouldSerializeEffectList() => EffectList is not null;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
  public bool ShouldSerializeScene3DType() => Scene3DType is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
