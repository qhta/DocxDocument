namespace DocumentModel.Drawings;

public partial class EffectStyle
{
  public bool ShouldSerializeEffectList() => EffectList is not null;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
  public bool ShouldSerializeScene3DType() => Scene3DType is not null;
  public bool ShouldSerializeShape3DType() => Shape3DType is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
