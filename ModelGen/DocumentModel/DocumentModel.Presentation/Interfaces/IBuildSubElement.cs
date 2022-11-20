namespace DocumentModel.Presentation;

/// <summary>
/// Build Sub Elements.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBuildChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBuildDiagram))]
public interface IBuildSubElement // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Build Diagram.
  /// </summary>
  public DocumentModel.Drawing.IBuildDiagram? BuildDiagram { get ; set; }
  
  /// <summary>
  /// Build Chart.
  /// </summary>
  public IBuildChart? BuildChart { get ; set; }
  
}
