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
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public NumberDiagramInfoList? NumberDiagramInfoList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TextListStyleType? TextListStyleType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
