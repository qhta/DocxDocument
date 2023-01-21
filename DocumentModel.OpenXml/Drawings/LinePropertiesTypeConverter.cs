namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LinePropertiesType Class.
/// </summary>
public static class LinePropertiesTypeConverter
{
  /// <summary>
  /// line width
  /// </summary>
  private static Int32? GetWidth(DXDraw.LinePropertiesType openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DXDraw.LinePropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// line cap
  /// </summary>
  private static DMDraws.LineCapKind? GetCapType(DXDraw.LinePropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DMDraws.LineCapKind>(openXmlElement?.CapType?.Value);
  }
  
  private static void SetCapType(DXDraw.LinePropertiesType openXmlElement, DMDraws.LineCapKind? value)
  {
    openXmlElement.CapType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DMDraws.LineCapKind>(value);
  }
  
  /// <summary>
  /// compound line type
  /// </summary>
  private static DMDraws.CompoundLineKind? GetCompoundLineType(DXDraw.LinePropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DMDraws.CompoundLineKind>(openXmlElement?.CompoundLineType?.Value);
  }
  
  private static void SetCompoundLineType(DXDraw.LinePropertiesType openXmlElement, DMDraws.CompoundLineKind? value)
  {
    openXmlElement.CompoundLineType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DMDraws.CompoundLineKind>(value);
  }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  private static DMDraws.PenAlignmentKind? GetAlignment(DXDraw.LinePropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DMDraws.PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static void SetAlignment(DXDraw.LinePropertiesType openXmlElement, DMDraws.PenAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DMDraws.PenAlignmentKind>(value);
  }
  
  public static DMDraws.LinePropertiesType? CreateModelElement(DXDraw.LinePropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LinePropertiesType();
      value.Width = GetWidth(openXmlElement);
      value.CapType = GetCapType(openXmlElement);
      value.CompoundLineType = GetCompoundLineType(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LinePropertiesType? value)
    where OpenXmlElementType: DXDraw.LinePropertiesType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetCapType(openXmlElement, value?.CapType);
      SetCompoundLineType(openXmlElement, value?.CompoundLineType);
      SetAlignment(openXmlElement, value?.Alignment);
      return openXmlElement;
    }
    return default;
  }
}
