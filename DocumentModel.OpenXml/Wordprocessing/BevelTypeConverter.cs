namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public static class BevelTypeConverter
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetWidth(DocumentFormat.OpenXml.Office2010.Word.BevelType openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Office2010.Word.BevelType openXmlElement, Int64? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// h, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetHeight(DocumentFormat.OpenXml.Office2010.Word.BevelType openXmlElement)
  {
    return openXmlElement.Height?.Value;
  }
  
  private static void SetHeight(DocumentFormat.OpenXml.Office2010.Word.BevelType openXmlElement, Int64? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.Wordprocessing.BevelPresetKind? GetPresetProfileType(DocumentFormat.OpenXml.Office2010.Word.BevelType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues, DocumentModel.Wordprocessing.BevelPresetKind>(openXmlElement?.PresetProfileType?.Value);
  }
  
  private static void SetPresetProfileType(DocumentFormat.OpenXml.Office2010.Word.BevelType openXmlElement, DocumentModel.Wordprocessing.BevelPresetKind? value)
  {
    openXmlElement.PresetProfileType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues, DocumentModel.Wordprocessing.BevelPresetKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.BevelType? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.BevelType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.BevelType();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.PresetProfileType = GetPresetProfileType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.BevelType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.BevelType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetPresetProfileType(openXmlElement, value?.PresetProfileType);
      return openXmlElement;
    }
    return default;
  }
}
