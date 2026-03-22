namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class MoveTo
{
  public bool ShouldSerializePoint() => Point is not null;
}
