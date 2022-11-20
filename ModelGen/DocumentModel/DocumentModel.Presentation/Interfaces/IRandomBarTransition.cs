namespace DocumentModel.Presentation;

/// <summary>
/// Defines the RandomBarTransition Class.
/// </summary>
public interface IRandomBarTransition // : DocumentFormat.OpenXml.Presentation.OrientationTransitionType
{
  /// <summary>
  /// Transition Direction
  /// </summary>
  public DocumentModel.Presentation.DirectionValues? Direction { get ; set; }
  
}
