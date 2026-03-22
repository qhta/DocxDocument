namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class LinePropertiesExtension
{
  public bool ShouldSerializeLineSketchStyleProperties() => LineSketchStyleProperties is not null;
  public bool ShouldSerializeUri() => Uri is not null;
}
