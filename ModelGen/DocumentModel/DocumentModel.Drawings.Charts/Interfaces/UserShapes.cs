namespace DocumentModel.Drawings.Charts;

/// <summary>
/// User Shapes.
/// </summary>
public interface UserShapes
{
  public DocumentModel.Drawings.Charts.RelativeAnchorSize? RelativeAnchorSize { get ; set; }
  
  public DocumentModel.Drawings.Charts.AbsoluteAnchorSize? AbsoluteAnchorSize { get ; set; }
  
}
