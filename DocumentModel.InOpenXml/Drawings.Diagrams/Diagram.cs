namespace DocumentModel.Drawings;

/// <summary>
///   Diagram to Animate.
/// </summary>
public class Diagram
{
  /// <summary>
  ///   Identifier
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   Animation Build Step
  /// </summary>
  public DiagramBuildStep? BuildStep { get; set; }
}