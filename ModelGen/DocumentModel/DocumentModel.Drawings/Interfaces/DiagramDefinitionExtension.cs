namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public interface DiagramDefinitionExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings.NumberDiagramInfoList? NumberDiagramInfoList { get ; set; }
  
  public DocumentModel.Drawings.TextListStyleType? TextListStyleType { get ; set; }
  
}
