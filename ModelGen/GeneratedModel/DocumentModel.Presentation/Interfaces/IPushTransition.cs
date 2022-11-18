namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PushTransition Class.
/// </summary>
public interface IPushTransition // : DocumentFormat.OpenXml.Presentation.SideDirectionTransitionType
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionSlideDirection? Direction { get ; set; }
  
}
