namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the PanTransition Class.
/// </summary>
public interface IPanTransition // : DocumentFormat.OpenXml.Office2010.PowerPoint.SideDirectionTransitionType
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionSlideDirectionValues? Direction { get ; set; }
  
}
