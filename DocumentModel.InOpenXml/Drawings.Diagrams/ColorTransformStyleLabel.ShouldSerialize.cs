namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class ColorTransformStyleLabel
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeFillColorList() => FillColorList is not null;
  public bool ShouldSerializeLineColorList() => LineColorList is not null;
  public bool ShouldSerializeEffectColorList() => EffectColorList is not null;
  public bool ShouldSerializeTextLineColorList() => TextLineColorList is not null;
  public bool ShouldSerializeTextFillColorList() => TextFillColorList is not null;
  public bool ShouldSerializeTextEffectColorList() => TextEffectColorList is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
