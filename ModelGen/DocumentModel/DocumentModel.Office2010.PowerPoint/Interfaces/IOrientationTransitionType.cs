namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the OrientationTransitionType Class.
/// </summary>
public interface IOrientationTransitionType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Transition Direction
  /// </summary>
  public DirectionValues? Direction { get ; set; }
  
}
