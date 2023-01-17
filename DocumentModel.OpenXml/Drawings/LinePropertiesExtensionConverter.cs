namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LinePropertiesExtension Class.
/// </summary>
public static class LinePropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.LinePropertiesExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.LinePropertiesExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.LineSketchStyleProperties? GetLineSketchStyleProperties(DocumentFormat.OpenXml.Drawing.LinePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineSketchStylePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineSketchStyleProperties(DocumentFormat.OpenXml.Drawing.LinePropertiesExtension openXmlElement, DocumentModel.Drawings.LineSketchStyleProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.LineSketchStylePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LinePropertiesExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.LinePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinePropertiesExtension();
      value.Uri = GetUri(openXmlElement);
      value.LineSketchStyleProperties = GetLineSketchStyleProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LinePropertiesExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.LinePropertiesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetLineSketchStyleProperties(openXmlElement, value?.LineSketchStyleProperties);
      return openXmlElement;
    }
    return default;
  }
}
