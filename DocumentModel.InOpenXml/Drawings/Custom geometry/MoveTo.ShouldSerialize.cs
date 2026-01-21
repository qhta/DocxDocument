namespace DocumentModel.Drawings;

public partial class MoveTo
{
  public bool ShouldSerializePoint() => Point is not null;
}
