namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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