namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableIndentation
{
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeType() => Type is not null;
}
