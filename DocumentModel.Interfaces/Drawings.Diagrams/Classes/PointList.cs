namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Point List.
/// </summary>
public interface PointList: IModelElement
{
  public Collection<Point>? Points { get; set; }
}