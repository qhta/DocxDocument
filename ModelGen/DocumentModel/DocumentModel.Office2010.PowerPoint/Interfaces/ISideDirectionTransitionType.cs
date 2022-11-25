namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the SideDirectionTransitionType Class.
/// </summary>
public interface ISideDirectionTransitionType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Direction
  /// </summary>
  public DocumentModel.Presentation.TransitionSlideDirectionKind? Direction { get ; set; }
  
}
