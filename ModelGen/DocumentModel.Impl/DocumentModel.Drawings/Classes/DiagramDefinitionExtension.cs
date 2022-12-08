namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public class DiagramDefinitionExtensionImpl: ModelElementImpl, DiagramDefinitionExtension
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
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
