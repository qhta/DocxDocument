namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public static class BevelTypeConverter
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetWidth(DocumentFormat.OpenXml.Office2010.Word.BevelType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Office2010.Word.BevelType? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// h, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetHeight(DocumentFormat.OpenXml.Office2010.Word.BevelType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Office2010.Word.BevelType? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.BevelPresetKind? GetPresetProfileType(DocumentFormat.OpenXml.Office2010.Word.BevelType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues, DocumentModel.Wordprocessing.BevelPresetKind>(openXmlElement?.PresetProfileType?.Value);
  }
  
  public static void SetPresetProfileType(DocumentFormat.OpenXml.Office2010.Word.BevelType? openXmlElement, DocumentModel.Wordprocessing.BevelPresetKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetProfileType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues, DocumentModel.Wordprocessing.BevelPresetKind>(value);
  }
  
}
