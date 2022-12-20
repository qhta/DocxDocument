namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public partial class DiagramDefinitionExtensionImpl: ModelElementImpl, DiagramDefinitionExtension
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramDefinitionExtensionImpl(): base() {}
  
  public DiagramDefinitionExtensionImpl(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Diagram1.NumberDiagramInfoList? NumberDiagramInfoList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagram1.NumberDiagramInfoListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagram1.NumberDiagramInfoListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagram2.TextListStyleType? TextListStyleType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType>();
        if (item != null)
          return new DocumentModel.Drawings.Diagram2.TextListStyleTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagram2.TextListStyleTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
