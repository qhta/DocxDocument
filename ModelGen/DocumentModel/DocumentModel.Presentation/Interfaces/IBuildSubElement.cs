namespace DocumentModel.Presentation;

/// <summary>
/// Build Sub Elements.
/// </summary>
public interface IBuildSubElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Build Diagram.
  /// </summary>
  public DocumentModel.Drawing.IBuildDiagram? BuildDiagram { get ; set; }
  
  /// <summary>
  /// Build Chart.
  /// </summary>
  public DocumentModel.Drawing.IBuildChart? BuildChart { get ; set; }
  
}
