namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public static class DiagramDefinitionExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Diagram1.NumberDiagramInfoList? GetNumberDiagramInfoList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagram1.NumberDiagramInfoListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberDiagramInfoList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension openXmlElement, DocumentModel.Drawings.Diagram1.NumberDiagramInfoList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagram1.NumberDiagramInfoListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Diagram2.TextListStyleType? GetTextListStyleType(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagram2.TextListStyleTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextListStyleType(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension openXmlElement, DocumentModel.Drawings.Diagram2.TextListStyleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagram2.TextListStyleTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberDiagramInfoList = GetNumberDiagramInfoList(openXmlElement);
      value.TextListStyleType = GetTextListStyleType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetNumberDiagramInfoList(openXmlElement, value?.NumberDiagramInfoList);
      SetTextListStyleType(openXmlElement, value?.TextListStyleType);
      return openXmlElement;
    }
    return default;
  }
}
