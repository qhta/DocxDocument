namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SideDirectionTransitionType Class.
/// </summary>
public interface ISideDirectionTransitionType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionSlideDirectionValues? Direction { get ; set; }
  
}
