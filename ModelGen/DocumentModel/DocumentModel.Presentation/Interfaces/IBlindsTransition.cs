namespace DocumentModel.Presentation;

/// <summary>
/// Defines the BlindsTransition Class.
/// </summary>
public interface IBlindsTransition // : DocumentFormat.OpenXml.Presentation.OrientationTransitionType
{
  /// <summary>
  /// Transition Direction
  /// </summary>
  public DocumentModel.Presentation.DirectionValues? Direction { get ; set; }
  
}
