namespace DocumentModel.Drawings.ChartsStyle;

#pragma warning disable CS1591

public partial class StyleEntry
{
  public bool ShouldSerializeModifiers() => Modifiers is not null;
  public bool ShouldSerializeLineReference() => LineReference is not null;
  public bool ShouldSerializeLineWidthScale() => !String.IsNullOrEmpty(LineWidthScale);
  public bool ShouldSerializeFillReference() => FillReference is not null;
  public bool ShouldSerializeEffectReference() => EffectReference is not null;
  public bool ShouldSerializeFontReference() => FontReference is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeTextCharacterPropertiesType() => TextCharacterPropertiesType is not null;
  public bool ShouldSerializeTextBodyProperties() => TextBodyProperties is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
