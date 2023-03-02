namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Point List.
/// </summary>
public record PointList
{
  public Collection<Point>? Points { get; set; }
}