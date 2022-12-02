namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SplitTransition Class.
/// </summary>
public interface ISplitTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Orientation
  /// </summary>
  public DirectionKind? Orientation { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionInOutDirectionKind? Direction { get ; set; }
  
}
