namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the VortexTransition Class.
/// </summary>
public interface IVortexTransition // : DocumentFormat.OpenXml.Office2010.PowerPoint.SideDirectionTransitionType
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionSlideDirection? Direction { get ; set; }
  
}
