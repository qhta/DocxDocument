namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CutTransition Class.
/// </summary>
public interface ICutTransition // : DocumentFormat.OpenXml.Presentation.OptionalBlackTransitionType
{
  /// <summary>
  /// Transition Through Black
  /// </summary>
  public bool? ThroughBlack { get ; set; }
  
}
