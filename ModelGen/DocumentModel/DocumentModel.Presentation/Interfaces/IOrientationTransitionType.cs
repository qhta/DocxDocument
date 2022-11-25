namespace DocumentModel.Presentation;

/// <summary>
/// Defines the OrientationTransitionType Class.
/// </summary>
public interface IOrientationTransitionType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Transition Direction
  /// </summary>
  public DocumentModel.Presentation.DirectionKind? Direction { get ; set; }
  
}
