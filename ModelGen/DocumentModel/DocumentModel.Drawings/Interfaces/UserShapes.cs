namespace DocumentModel.Drawings;

/// <summary>
/// User Shapes.
/// </summary>
public interface UserShapes
{
  public RelativeAnchorSize? RelativeAnchorSize { get ; set; }
  
  public AbsoluteAnchorSize? AbsoluteAnchorSize { get ; set; }
  
}
