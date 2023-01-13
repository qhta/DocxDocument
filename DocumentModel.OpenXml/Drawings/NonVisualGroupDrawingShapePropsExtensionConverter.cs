namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropsExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.NonVisualGroupProperties? GetNonVisualGroupProperties(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.NonVisualGroupPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualGroupProperties(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension? openXmlElement, DocumentModel.Drawings.NonVisualGroupProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.NonVisualGroupPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension();
      value.Uri = GetUri(openXmlElement);
      value.NonVisualGroupProperties = GetNonVisualGroupProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetNonVisualGroupProperties(openXmlElement, value?.NonVisualGroupProperties);
      return openXmlElement;
    }
    return default;
  }
}
