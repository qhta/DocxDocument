namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Most Recently Used Colors.
/// </summary>
public static class ColorMostRecentlyUsedConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Recent colors
  /// </summary>
  public static String? GetColors(DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed? openXmlElement)
  {
    return openXmlElement?.Colors?.Value;
  }
  
  public static void SetColors(DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Colors = new StringValue { Value = value };
      else
        openXmlElement.Colors = null;
  }
  
  public static DocumentModel.Vml.ColorMostRecentlyUsed? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ColorMostRecentlyUsed();
      value.Extension = GetExtension(openXmlElement);
      value.Colors = GetColors(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ColorMostRecentlyUsed? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
