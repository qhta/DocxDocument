namespace DocumentModel.Drawings;

/// <summary>
/// Diagram to Animate.
/// </summary>
public interface Diagram
{
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public DiagramBuildStepKind? BuildStep { get ; set; }
  
}
