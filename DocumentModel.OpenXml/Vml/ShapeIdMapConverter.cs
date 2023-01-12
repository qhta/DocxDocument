namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape ID Map.
/// </summary>
public static class ShapeIdMapConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.ShapeIdMap? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.ShapeIdMap? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Shape IDs
  /// </summary>
  public static String? GetData(DocumentFormat.OpenXml.Vml.Office.ShapeIdMap? openXmlElement)
  {
    return openXmlElement?.Data?.Value;
  }
  
  public static void SetData(DocumentFormat.OpenXml.Vml.Office.ShapeIdMap? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Data = new StringValue { Value = value };
      else
        openXmlElement.Data = null;
  }
  
  public static DocumentModel.Vml.ShapeIdMap? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.ShapeIdMap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ShapeIdMap();
      value.Extension = GetExtension(openXmlElement);
      value.Data = GetData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ShapeIdMap? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.ShapeIdMap, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetData(openXmlElement, value?.Data);
      return openXmlElement;
    }
    return default;
  }
}
