namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SplitTransition Class.
/// </summary>
public interface ISplitTransition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Orientation
  /// </summary>
  public DocumentModel.Presentation.Direction? Orientation { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionInOutDirection? Direction { get ; set; }
  
}
