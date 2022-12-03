namespace DocumentModel.Presentation;

/// <summary>
/// Build Sub Elements.
/// </summary>
public interface BuildSubElement // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Build Diagram.
  /// </summary>
  public DocumentModel.Drawings.BuildDiagram? BuildDiagram { get ; set; }
  
  /// <summary>
  /// Build Chart.
  /// </summary>
  public DocumentModel.Drawings.BuildChart? BuildChart { get ; set; }
  
}
