namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Fill Extended Properties.
/// </summary>
public static class FillExtendedPropertiesConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  private static DocumentModel.Vml.FillKind? GetType(DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.FillValues, DocumentModel.Vml.FillKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties openXmlElement, DocumentModel.Vml.FillKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.FillValues, DocumentModel.Vml.FillKind>(value);
  }
  
  public static DocumentModel.Vml.FillExtendedProperties? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.FillExtendedProperties();
      value.Extension = GetExtension(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.FillExtendedProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetType(openXmlElement, value?.Type);
      return openXmlElement;
    }
    return default;
  }
}
