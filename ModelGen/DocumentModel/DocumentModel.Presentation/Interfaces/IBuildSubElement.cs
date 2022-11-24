namespace DocumentModel.Presentation;

/// <summary>
/// Build Sub Elements.
/// </summary>
public interface IBuildSubElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Build Diagram.
  /// </summary>
  public IBuildDiagram? BuildDiagram { get ; set; }
  
  /// <summary>
  /// Build Chart.
  /// </summary>
  public IBuildChart? BuildChart { get ; set; }
  
}
