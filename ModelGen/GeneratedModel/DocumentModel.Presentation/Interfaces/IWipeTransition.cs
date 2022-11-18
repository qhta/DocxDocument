namespace DocumentModel.Presentation;

/// <summary>
/// Defines the WipeTransition Class.
/// </summary>
public interface IWipeTransition // : DocumentFormat.OpenXml.Presentation.SideDirectionTransitionType
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionSlideDirection? Direction { get ; set; }
  
}
