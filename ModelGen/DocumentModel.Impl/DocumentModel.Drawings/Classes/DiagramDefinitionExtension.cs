namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public class DiagramDefinitionExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>, DiagramDefinitionExtension
{
  public NumberDiagramInfoList? NumberDiagramInfoList
  {
    get;
    set;
  }
  
  public TextListStyleType? TextListStyleType
  {
    get;
    set;
  }
  
}
