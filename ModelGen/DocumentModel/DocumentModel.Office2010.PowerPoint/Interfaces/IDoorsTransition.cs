namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the DoorsTransition Class.
/// </summary>
public interface IDoorsTransition // : DocumentFormat.OpenXml.Office2010.PowerPoint.OrientationTransitionType
{
  /// <summary>
  /// Transition Direction
  /// </summary>
  public DocumentModel.Presentation.DirectionValues? Direction { get ; set; }
  
}
