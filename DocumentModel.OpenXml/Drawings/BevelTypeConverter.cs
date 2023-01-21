namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public static class BevelTypeConverter
{
  /// <summary>
  /// Width
  /// </summary>
  private static Int64? GetWidth(DXDraw.BevelType openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DXDraw.BevelType openXmlElement, Int64? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Height
  /// </summary>
  private static Int64? GetHeight(DXDraw.BevelType openXmlElement)
  {
    return openXmlElement.Height?.Value;
  }
  
  private static void SetHeight(DXDraw.BevelType openXmlElement, Int64? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Preset Bevel
  /// </summary>
  private static DMDraws.BevelPresetKind? GetPreset(DXDraw.BevelType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BevelPresetValues, DMDraws.BevelPresetKind>(openXmlElement?.Preset?.Value);
  }
  
  private static void SetPreset(DXDraw.BevelType openXmlElement, DMDraws.BevelPresetKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BevelPresetValues, DMDraws.BevelPresetKind>(value);
  }
  
  public static DMDraws.BevelType? CreateModelElement(DXDraw.BevelType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BevelType();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Preset = GetPreset(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BevelType? value)
    where OpenXmlElementType: DXDraw.BevelType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetPreset(openXmlElement, value?.Preset);
      return openXmlElement;
    }
    return default;
  }
}
