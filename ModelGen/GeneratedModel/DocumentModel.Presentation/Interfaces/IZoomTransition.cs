namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ZoomTransition Class.
/// </summary>
public interface IZoomTransition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionInOutDirection? Direction { get ; set; }
  
}
