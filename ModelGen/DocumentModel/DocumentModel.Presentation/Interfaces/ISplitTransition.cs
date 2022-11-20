namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SplitTransition Class.
/// </summary>
public interface ISplitTransition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Orientation
  /// </summary>
  public DocumentModel.Presentation.DirectionValues? Orientation { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionInOutDirectionValues? Direction { get ; set; }
  
}
