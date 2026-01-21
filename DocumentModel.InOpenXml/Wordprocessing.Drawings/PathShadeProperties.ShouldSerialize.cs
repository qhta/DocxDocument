namespace DocumentModel.Wordprocessing.Drawings;

public partial class PathShadeProperties
{
  public bool ShouldSerializePath() => Path is not null;
  public bool ShouldSerializeFillToRectangle() => FillToRectangle is not null;
}
