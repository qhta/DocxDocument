namespace DocumentModel.Drawings;

public partial class ShapeStyle
{
  public bool ShouldSerializeLineReference() => LineReference is not null;
  public bool ShouldSerializeFillReference() => FillReference is not null;
  public bool ShouldSerializeEffectReference() => EffectReference is not null;
  public bool ShouldSerializeFontReference() => FontReference is not null;
}
