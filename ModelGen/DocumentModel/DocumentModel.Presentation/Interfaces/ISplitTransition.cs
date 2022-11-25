namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SplitTransition Class.
/// </summary>
public interface ISplitTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Orientation
  /// </summary>
  public DocumentModel.Presentation.DirectionKind? Orientation { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public DocumentModel.Presentation.TransitionInOutDirectionKind? Direction { get ; set; }
  
}
