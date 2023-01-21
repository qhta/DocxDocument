namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineEndPropertiesType Class.
/// </summary>
public static class LineEndPropertiesTypeConverter
{
  /// <summary>
  /// Line Head/End Type
  /// </summary>
  private static DMDraws.LineEndKind? GetType(DXDraw.LineEndPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndValues, DMDraws.LineEndKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXDraw.LineEndPropertiesType openXmlElement, DMDraws.LineEndKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndValues, DMDraws.LineEndKind>(value);
  }
  
  /// <summary>
  /// Width of Head/End
  /// </summary>
  private static DMDraws.LineEndWidthKind? GetWidth(DXDraw.LineEndPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndWidthValues, DMDraws.LineEndWidthKind>(openXmlElement?.Width?.Value);
  }
  
  private static void SetWidth(DXDraw.LineEndPropertiesType openXmlElement, DMDraws.LineEndWidthKind? value)
  {
    openXmlElement.Width = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndWidthValues, DMDraws.LineEndWidthKind>(value);
  }
  
  /// <summary>
  /// Length of Head/End
  /// </summary>
  private static DMDraws.LineEndLengthKind? GetLength(DXDraw.LineEndPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndLengthValues, DMDraws.LineEndLengthKind>(openXmlElement?.Length?.Value);
  }
  
  private static void SetLength(DXDraw.LineEndPropertiesType openXmlElement, DMDraws.LineEndLengthKind? value)
  {
    openXmlElement.Length = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndLengthValues, DMDraws.LineEndLengthKind>(value);
  }
  
  public static DMDraws.LineEndPropertiesType? CreateModelElement(DXDraw.LineEndPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LineEndPropertiesType();
      value.Type = GetType(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Length = GetLength(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LineEndPropertiesType? value)
    where OpenXmlElementType: DXDraw.LineEndPropertiesType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetWidth(openXmlElement, value?.Width);
      SetLength(openXmlElement, value?.Length);
      return openXmlElement;
    }
    return default;
  }
}
