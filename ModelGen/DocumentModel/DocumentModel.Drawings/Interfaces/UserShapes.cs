namespace DocumentModel.Drawings;

/// <summary>
/// User Shapes.
/// </summary>
public interface UserShapes // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<RelativeAnchorSize>? RelativeAnchorSizes { get ; set; }
  
  public Collection<AbsoluteAnchorSize>? AbsoluteAnchorSizes { get ; set; }
  
}
