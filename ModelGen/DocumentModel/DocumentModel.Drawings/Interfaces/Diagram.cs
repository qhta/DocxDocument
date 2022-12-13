namespace DocumentModel.Drawings;

/// <summary>
/// Diagram to Animate.
/// </summary>
public interface Diagram
{
  /// <summary>
  /// Identifier
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public DocumentModel.Drawings.DiagramBuildStepKind? BuildStep { get ; set; }
  
}
