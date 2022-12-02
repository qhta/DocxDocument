namespace DocumentModel.Drawing;

/// <summary>
/// Diagram to Animate.
/// </summary>
public interface IDiagram // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Identifier
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public DiagramBuildStepKind? BuildStep { get ; set; }
  
}
