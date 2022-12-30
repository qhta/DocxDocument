namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public partial class DiagramDefinitionExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Diagram1.NumberDiagramInfoList? NumberDiagramInfoList { get; set; }
  
  public DocumentModel.Drawings.Diagram2.TextListStyleType? TextListStyleType { get; set; }
  
}
