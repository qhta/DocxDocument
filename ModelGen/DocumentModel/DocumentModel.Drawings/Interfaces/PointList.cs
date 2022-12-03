namespace DocumentModel.Drawings;

/// <summary>
/// Point List.
/// </summary>
public interface PointList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Point>? Points { get ; set; }
  
}
