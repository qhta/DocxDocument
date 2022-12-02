namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ZoomTransition Class.
/// </summary>
public interface IZoomTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionInOutDirectionKind? Direction { get ; set; }
  
}
