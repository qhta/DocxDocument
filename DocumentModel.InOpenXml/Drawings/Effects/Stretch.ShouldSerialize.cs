namespace DocumentModel.Drawings;

public partial class Stretch
{
  public bool ShouldSerializeFillRectangle() => FillRectangle is not null;
}
