namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CombTransition Class.
/// </summary>
public interface ICombTransition // : DocumentFormat.OpenXml.Presentation.OrientationTransitionType
{
  /// <summary>
  /// Transition Direction
  /// </summary>
  public DocumentModel.Presentation.Direction? Direction { get ; set; }
  
}
