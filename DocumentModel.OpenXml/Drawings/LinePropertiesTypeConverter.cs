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
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXDraw.LinePropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Width", openXmlElement?.Width?.Value, value);
    return false;
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
  
  private static bool CmpCapType(DXDraw.LinePropertiesType openXmlElement, DMDraws.LineCapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DMDraws.LineCapKind>(openXmlElement?.CapType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpCompoundLineType(DXDraw.LinePropertiesType openXmlElement, DMDraws.CompoundLineKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DMDraws.CompoundLineKind>(openXmlElement?.CompoundLineType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpAlignment(DXDraw.LinePropertiesType openXmlElement, DMDraws.PenAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DMDraws.PenAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlignment(DXDraw.LinePropertiesType openXmlElement, DMDraws.PenAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DMDraws.PenAlignmentKind>(value);
  }
  
  public static DocumentModel.Drawings.LinePropertiesType? CreateModelElement(DXDraw.LinePropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinePropertiesType();
      value.Width = GetWidth(openXmlElement);
      value.CapType = GetCapType(openXmlElement);
      value.CompoundLineType = GetCompoundLineType(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.LinePropertiesType? openXmlElement, DMDraws.LinePropertiesType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpCapType(openXmlElement, value.CapType, diffs, objName))
        ok = false;
      if (!CmpCompoundLineType(openXmlElement, value.CompoundLineType, diffs, objName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LinePropertiesType value)
    where OpenXmlElementType: DXDraw.LinePropertiesType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.LinePropertiesType openXmlElement, DMDraws.LinePropertiesType value)
  {
    SetWidth(openXmlElement, value?.Width);
    SetCapType(openXmlElement, value?.CapType);
    SetCompoundLineType(openXmlElement, value?.CompoundLineType);
    SetAlignment(openXmlElement, value?.Alignment);
  }
}
