namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Point List.
/// </summary>
public interface PointList:
{
  public Collection<Point>? Points { get; set; }
}