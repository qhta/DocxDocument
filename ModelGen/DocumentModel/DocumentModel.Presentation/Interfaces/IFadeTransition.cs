namespace DocumentModel.Presentation;

/// <summary>
/// Defines the FadeTransition Class.
/// </summary>
public interface IFadeTransition // : DocumentFormat.OpenXml.Presentation.OptionalBlackTransitionType
{
  /// <summary>
  /// Transition Through Black
  /// </summary>
  public bool? ThroughBlack { get ; set; }
  
}
