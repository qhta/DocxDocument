namespace DocumentModel.Drawings;

public partial class LineTo
{
  public bool ShouldSerializePoint() => Point is not null;
}
