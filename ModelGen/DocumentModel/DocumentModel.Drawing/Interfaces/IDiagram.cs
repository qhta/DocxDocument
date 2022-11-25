namespace DocumentModel.Drawing;

/// <summary>
/// Diagram to Animate.
/// </summary>
public interface IDiagram // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public DocumentModel.Drawing.DiagramBuildStepKind? BuildStep { get ; set; }
  
}
