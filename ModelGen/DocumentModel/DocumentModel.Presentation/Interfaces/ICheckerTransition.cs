namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CheckerTransition Class.
/// </summary>
public interface ICheckerTransition // : DocumentFormat.OpenXml.Presentation.OrientationTransitionType
{
  /// <summary>
  /// Transition Direction
  /// </summary>
  public DocumentModel.Presentation.DirectionValues? Direction { get ; set; }
  
}
