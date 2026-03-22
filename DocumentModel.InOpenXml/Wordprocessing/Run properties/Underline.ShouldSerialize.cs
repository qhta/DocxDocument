namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Underline
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeColor() => Color is not null;
}
