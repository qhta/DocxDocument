namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class ColorType
{
  public bool ShouldSerializeMethod() => Method is not null;
  public bool ShouldSerializeHueDirection() => HueDirection is not null;
}
