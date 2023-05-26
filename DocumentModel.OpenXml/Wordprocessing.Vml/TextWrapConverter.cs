namespace DocumentModel.OpenXml.Wordprocessing.Vml;

/// <summary>
/// Text Wrapping.
/// </summary>
public static class TextWrapConverter
{
  /// <summary>
  /// Wrapping type
  /// </summary>
  private static DMWV.WrapKind? GetType(DXVW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues, DMWV.WrapKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXVW.TextWrap openXmlElement, DMWV.WrapKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues, DMWV.WrapKind>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXVW.TextWrap openXmlElement, DMWV.WrapKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues, DMWV.WrapKind>(value);
  }
  
  /// <summary>
  /// Wrapping side
  /// </summary>
  private static DMWV.WrapSideKind? GetSide(DXVW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues, DMWV.WrapSideKind>(openXmlElement?.Side?.Value);
  }
  
  private static bool CmpSide(DXVW.TextWrap openXmlElement, DMWV.WrapSideKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues, DMWV.WrapSideKind>(openXmlElement?.Side?.Value, value, diffs, objName, propName);
  }
  
  private static void SetSide(DXVW.TextWrap openXmlElement, DMWV.WrapSideKind? value)
  {
    openXmlElement.Side = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues, DMWV.WrapSideKind>(value);
  }
  
  /// <summary>
  /// Horizontal Positioning Base
  /// </summary>
  private static DMWV.HorizontalAnchorKind? GetAnchorX(DXVW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues, DMWV.HorizontalAnchorKind>(openXmlElement?.AnchorX?.Value);
  }
  
  private static bool CmpAnchorX(DXVW.TextWrap openXmlElement, DMWV.HorizontalAnchorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues, DMWV.HorizontalAnchorKind>(openXmlElement?.AnchorX?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAnchorX(DXVW.TextWrap openXmlElement, DMWV.HorizontalAnchorKind? value)
  {
    openXmlElement.AnchorX = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues, DMWV.HorizontalAnchorKind>(value);
  }
  
  /// <summary>
  /// Vertical Positioning Base
  /// </summary>
  private static DMWV.VerticalAnchorKind? GetAnchorY(DXVW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues, DMWV.VerticalAnchorKind>(openXmlElement?.AnchorY?.Value);
  }
  
  private static bool CmpAnchorY(DXVW.TextWrap openXmlElement, DMWV.VerticalAnchorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues, DMWV.VerticalAnchorKind>(openXmlElement?.AnchorY?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAnchorY(DXVW.TextWrap openXmlElement, DMWV.VerticalAnchorKind? value)
  {
    openXmlElement.AnchorY = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues, DMWV.VerticalAnchorKind>(value);
  }
  
  public static DMW.Vml.TextWrap? CreateModelElement(DXVW.TextWrap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Vml.TextWrap();
      value.Type = GetType(openXmlElement);
      value.Side = GetSide(openXmlElement);
      value.AnchorX = GetAnchorX(openXmlElement);
      value.AnchorY = GetAnchorY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVW.TextWrap? openXmlElement, DMWV.TextWrap? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpSide(openXmlElement, value.Side, diffs, objName, propName))
        ok = false;
      if (!CmpAnchorX(openXmlElement, value.AnchorX, diffs, objName, propName))
        ok = false;
      if (!CmpAnchorY(openXmlElement, value.AnchorY, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWV.TextWrap value)
    where OpenXmlElementType: DXVW.TextWrap, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVW.TextWrap openXmlElement, DMWV.TextWrap value)
  {
    SetType(openXmlElement, value?.Type);
    SetSide(openXmlElement, value?.Side);
    SetAnchorX(openXmlElement, value?.AnchorX);
    SetAnchorY(openXmlElement, value?.AnchorY);
  }
}
