namespace DocumentModel.Drawings.ChartsStyle;

#pragma warning disable CS1591

public partial class ColorStyle
{
  public bool ShouldSerializeMethod() => !String.IsNullOrEmpty(Method);
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeColor() => Color is not null;
  public bool ShouldSerializeColorStyleVariations() => ColorStyleVariations is not null;
}
