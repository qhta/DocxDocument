namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SplitTransition Class.
/// </summary>
public interface ISplitTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Orientation
  /// </summary>
  public DirectionValues? Orientation { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionInOutDirectionValues? Direction { get ; set; }
  
}
