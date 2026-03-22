namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class LineEndPropertiesType
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeLength() => Length is not null;
}
