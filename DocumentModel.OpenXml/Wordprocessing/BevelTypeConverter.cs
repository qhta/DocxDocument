namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public static class BevelTypeConverter
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetWidth(DXO2010W.BevelType openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DXO2010W.BevelType openXmlElement, Int64? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// h, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetHeight(DXO2010W.BevelType openXmlElement)
  {
    return openXmlElement.Height?.Value;
  }
  
  private static void SetHeight(DXO2010W.BevelType openXmlElement, Int64? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.BevelPresetKind? GetPresetProfileType(DXO2010W.BevelType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues, DMW.BevelPresetKind>(openXmlElement?.PresetProfileType?.Value);
  }
  
  private static void SetPresetProfileType(DXO2010W.BevelType openXmlElement, DMW.BevelPresetKind? value)
  {
    openXmlElement.PresetProfileType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues, DMW.BevelPresetKind>(value);
  }
  
  public static DMW.BevelType? CreateModelElement(DXO2010W.BevelType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.BevelType();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.PresetProfileType = GetPresetProfileType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.BevelType? value)
    where OpenXmlElementType: DXO2010W.BevelType, new()
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
