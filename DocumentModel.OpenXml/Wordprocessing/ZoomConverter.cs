namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Magnification Setting.
/// </summary>
public static class ZoomConverter
{
  /// <summary>
  /// Zoom Type
  /// </summary>
  private static DocumentModel.Wordprocessing.PresetZoomKind? GetVal(DocumentFormat.OpenXml.Wordprocessing.Zoom openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PresetZoomValues, DocumentModel.Wordprocessing.PresetZoomKind>(openXmlElement?.Val?.Value);
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.Zoom openXmlElement, DocumentModel.Wordprocessing.PresetZoomKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PresetZoomValues, DocumentModel.Wordprocessing.PresetZoomKind>(value);
  }
  
  /// <summary>
  /// Zoom Percentage
  /// </summary>
  private static String? GetPercent(DocumentFormat.OpenXml.Wordprocessing.Zoom openXmlElement)
  {
    return openXmlElement?.Percent?.Value;
  }
  
  private static void SetPercent(DocumentFormat.OpenXml.Wordprocessing.Zoom openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Percent = new StringValue { Value = value };
    else
      openXmlElement.Percent = null;
  }
  
  public static DocumentModel.Wordprocessing.Zoom? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Zoom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Zoom();
      value.Val = GetVal(openXmlElement);
      value.Percent = GetPercent(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Zoom? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Zoom, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetPercent(openXmlElement, value?.Percent);
      return openXmlElement;
    }
    return default;
  }
}
