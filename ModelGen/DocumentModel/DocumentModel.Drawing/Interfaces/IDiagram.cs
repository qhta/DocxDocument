namespace DocumentModel.Drawing;

/// <summary>
/// Diagram to Animate.
/// </summary>
public interface IDiagram // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Identifier
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public DiagramBuildStepValues? BuildStep { get ; set; }
  
}
