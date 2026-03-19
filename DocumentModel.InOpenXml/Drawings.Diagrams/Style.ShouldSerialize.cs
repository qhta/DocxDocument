namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class Style
{
  public bool ShouldSerializeLineReference() => LineReference is not null;
  public bool ShouldSerializeFillReference() => FillReference is not null;
  public bool ShouldSerializeEffectReference() => EffectReference is not null;
  public bool ShouldSerializeFontReference() => FontReference is not null;
}
