namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
public static class PtExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.PtExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.PtExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Diagrams.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DocumentFormat.OpenXml.Drawing.PtExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualDrawingProperties(DocumentFormat.OpenXml.Drawing.PtExtension? openXmlElement, DocumentModel.Drawings.Diagrams.NonVisualDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.PtExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.PtExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PtExtension();
      value.Uri = GetUri(openXmlElement);
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PtExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.PtExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      return openXmlElement;
    }
    return default;
  }
}
