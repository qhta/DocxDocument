namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PullTransition Class.
/// </summary>
public interface IPullTransition // : DocumentFormat.OpenXml.Presentation.EightDirectionTransitionType
{
  /// <summary>
  /// Direction
  /// </summary>
  public string? Direction { get ; set; }
  
}
