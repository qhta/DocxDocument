namespace DocumentModel.OpenXml.Wordprocessing.Vml;

/// <summary>
/// Text Wrapping converter from/to OpenXml.
///</summary>
public static class TextWrapConverter
{
  /// <summary>
  /// Wrapping type
  /// </summary>
  private static DMWVml.WrapKind? GetType(DXVmlW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues, DMWVml.WrapKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXVmlW.TextWrap openXmlElement, DMWVml.WrapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues, DMWVml.WrapKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXVmlW.TextWrap openXmlElement, DMWVml.WrapKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues, DMWVml.WrapKind>(value);
  }
  
  /// <summary>
  /// Wrapping side
  /// </summary>
  private static DMWVml.WrapSideKind? GetSide(DXVmlW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues, DMWVml.WrapSideKind>(openXmlElement?.Side?.Value);
  }
  
  private static bool CmpSide(DXVmlW.TextWrap openXmlElement, DMWVml.WrapSideKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues, DMWVml.WrapSideKind>(openXmlElement?.Side?.Value, value, diffs, objName);
  }
  
  private static void SetSide(DXVmlW.TextWrap openXmlElement, DMWVml.WrapSideKind? value)
  {
    openXmlElement.Side = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues, DMWVml.WrapSideKind>(value);
  }
  
  /// <summary>
  /// Horizontal Positioning Base
  /// </summary>
  private static DMWVml.HorizontalAnchorKind? GetAnchorX(DXVmlW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues, DMWVml.HorizontalAnchorKind>(openXmlElement?.AnchorX?.Value);
  }
  
  private static bool CmpAnchorX(DXVmlW.TextWrap openXmlElement, DMWVml.HorizontalAnchorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues, DMWVml.HorizontalAnchorKind>(openXmlElement?.AnchorX?.Value, value, diffs, objName);
  }
  
  private static void SetAnchorX(DXVmlW.TextWrap openXmlElement, DMWVml.HorizontalAnchorKind? value)
  {
    openXmlElement.AnchorX = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues, DMWVml.HorizontalAnchorKind>(value);
  }
  
  /// <summary>
  /// Vertical Positioning Base
  /// </summary>
  private static DMWVml.VerticalAnchorKind? GetAnchorY(DXVmlW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues, DMWVml.VerticalAnchorKind>(openXmlElement?.AnchorY?.Value);
  }
  
  private static bool CmpAnchorY(DXVmlW.TextWrap openXmlElement, DMWVml.VerticalAnchorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues, DMWVml.VerticalAnchorKind>(openXmlElement?.AnchorY?.Value, value, diffs, objName);
  }
  
  private static void SetAnchorY(DXVmlW.TextWrap openXmlElement, DMWVml.VerticalAnchorKind? value)
  {
    openXmlElement.AnchorY = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues, DMWVml.VerticalAnchorKind>(value);
  }
  
  public static DMW.Vml.TextWrap? CreateModelElement(DXVmlW.TextWrap? openXmlElement)
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
  
  public static bool CompareModelElement(DXVmlW.TextWrap? openXmlElement, DMWVml.TextWrap? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpSide(openXmlElement, value.Side, diffs, objName))
        ok = false;
      if (!CmpAnchorX(openXmlElement, value.AnchorX, diffs, objName))
        ok = false;
      if (!CmpAnchorY(openXmlElement, value.AnchorY, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWVml.TextWrap value)
    where OpenXmlElementType: DXVmlW.TextWrap, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlW.TextWrap openXmlElement, DMWVml.TextWrap value)
  {
    SetType(openXmlElement, value?.Type);
    SetSide(openXmlElement, value?.Side);
    SetAnchorX(openXmlElement, value?.AnchorX);
    SetAnchorY(openXmlElement, value?.AnchorY);
  }
}
