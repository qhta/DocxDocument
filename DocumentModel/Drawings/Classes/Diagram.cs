namespace DocumentModel.Drawings;

/// <summary>
///   Diagram to Animate.
/// </summary>
public class Diagram: ModelElement
{
  /// <summary>
  ///   Identifier
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Animation Build Step
  /// </summary>
  public DiagramBuildStepKind? BuildStep { get; set; }
}