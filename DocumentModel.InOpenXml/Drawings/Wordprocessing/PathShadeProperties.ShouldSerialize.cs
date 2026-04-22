namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class PathShadeProperties
{
  public bool ShouldSerializePath() => Path is not null;
  public bool ShouldSerializeFillToRectangle() => FillToRectangle is not null;
}
