namespace DocumentModel.Drawings;

public partial class PathGradientFill
{
  public bool ShouldSerializePath() => Path is not null;
  public bool ShouldSerializeFillToRectangle() => FillToRectangle is not null;
}
