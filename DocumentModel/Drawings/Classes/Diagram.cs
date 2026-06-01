namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IDiagram Ito Animate.
/// </summary>
public class IDiagram: ModelElement
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
