namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the WindowTransition Class.
/// </summary>
public interface IWindowTransition // : DocumentFormat.OpenXml.Office2010.PowerPoint.OrientationTransitionType
{
  /// <summary>
  /// Transition Direction
  /// </summary>
  public DocumentModel.Presentation.DirectionValues? Direction { get ; set; }
  
}
