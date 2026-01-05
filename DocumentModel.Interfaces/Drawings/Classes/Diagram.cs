namespace DocumentModel.Drawings;

/// <summary>
///   Diagram to Animate.
/// </summary>
public interface Diagram:
{
  /// <summary>
  ///   Identifier
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   Animation Build Step
  /// </summary>
  public DiagramBuildStepKind? BuildStep { get; set; }
}