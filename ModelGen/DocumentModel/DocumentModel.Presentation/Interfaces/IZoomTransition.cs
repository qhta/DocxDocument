namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ZoomTransition Class.
/// </summary>
public interface IZoomTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Direction
  /// </summary>
  public DocumentModel.Presentation.TransitionInOutDirectionKind? Direction { get ; set; }
  
}
