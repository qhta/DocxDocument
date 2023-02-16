namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public static class Shadow2Converter
{
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetBlurRadius(DXO2010W.Shadow openXmlElement)
  {
    return openXmlElement?.BlurRadius?.Value;
  }
  
  private static bool CmpBlurRadius(DXO2010W.Shadow openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BlurRadius?.Value == value) return true;
    diffs?.Add(objName, "BlurRadius", openXmlElement?.BlurRadius?.Value, value);
    return false;
  }
  
  private static void SetBlurRadius(DXO2010W.Shadow openXmlElement, Int64? value)
  {
    openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetDistanceFromText(DXO2010W.Shadow openXmlElement)
  {
    return openXmlElement?.DistanceFromText?.Value;
  }
  
  private static bool CmpDistanceFromText(DXO2010W.Shadow openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DistanceFromText?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromText", openXmlElement?.DistanceFromText?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromText(DXO2010W.Shadow openXmlElement, Int64? value)
  {
    openXmlElement.DistanceFromText = value;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetDirectionAngle(DXO2010W.Shadow openXmlElement)
  {
    return openXmlElement?.DirectionAngle?.Value;
  }
  
  private static bool CmpDirectionAngle(DXO2010W.Shadow openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DirectionAngle?.Value == value) return true;
    diffs?.Add(objName, "DirectionAngle", openXmlElement?.DirectionAngle?.Value, value);
    return false;
  }
  
  private static void SetDirectionAngle(DXO2010W.Shadow openXmlElement, Int32? value)
  {
    openXmlElement.DirectionAngle = value;
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetHorizontalScalingFactor(DXO2010W.Shadow openXmlElement)
  {
    return openXmlElement?.HorizontalScalingFactor?.Value;
  }
  
  private static bool CmpHorizontalScalingFactor(DXO2010W.Shadow openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalScalingFactor?.Value == value) return true;
    diffs?.Add(objName, "HorizontalScalingFactor", openXmlElement?.HorizontalScalingFactor?.Value, value);
    return false;
  }
  
  private static void SetHorizontalScalingFactor(DXO2010W.Shadow openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalScalingFactor = value;
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetVerticalScalingFactor(DXO2010W.Shadow openXmlElement)
  {
    return openXmlElement?.VerticalScalingFactor?.Value;
  }
  
  private static bool CmpVerticalScalingFactor(DXO2010W.Shadow openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalScalingFactor?.Value == value) return true;
    diffs?.Add(objName, "VerticalScalingFactor", openXmlElement?.VerticalScalingFactor?.Value, value);
    return false;
  }
  
  private static void SetVerticalScalingFactor(DXO2010W.Shadow openXmlElement, Int32? value)
  {
    openXmlElement.VerticalScalingFactor = value;
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetHorizontalSkewAngle(DXO2010W.Shadow openXmlElement)
  {
    return openXmlElement?.HorizontalSkewAngle?.Value;
  }
  
  private static bool CmpHorizontalSkewAngle(DXO2010W.Shadow openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalSkewAngle?.Value == value) return true;
    diffs?.Add(objName, "HorizontalSkewAngle", openXmlElement?.HorizontalSkewAngle?.Value, value);
    return false;
  }
  
  private static void SetHorizontalSkewAngle(DXO2010W.Shadow openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkewAngle = value;
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetVerticalSkewAngle(DXO2010W.Shadow openXmlElement)
  {
    return openXmlElement?.VerticalSkewAngle?.Value;
  }
  
  private static bool CmpVerticalSkewAngle(DXO2010W.Shadow openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalSkewAngle?.Value == value) return true;
    diffs?.Add(objName, "VerticalSkewAngle", openXmlElement?.VerticalSkewAngle?.Value, value);
    return false;
  }
  
  private static void SetVerticalSkewAngle(DXO2010W.Shadow openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkewAngle = value;
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.RectangleAlignmentKind? GetAlignment(DXO2010W.Shadow openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DMW.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXO2010W.Shadow openXmlElement, DMW.RectangleAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DMW.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlignment(DXO2010W.Shadow openXmlElement, DMW.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DMW.RectangleAlignmentKind>(value);
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  private static DMW.RgbColorModelHex? GetRgbColorModelHex(DXO2010W.Shadow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.RgbColorModelHex>();
    if (element != null)
      return DMXW.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXO2010W.Shadow openXmlElement, DMW.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    return DMXW.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RgbColorModelHex>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelHex(DXO2010W.Shadow openXmlElement, DMW.RgbColorModelHex? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.RgbColorModelHex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RgbColorModelHexConverter.CreateOpenXmlElement<DXO2010W.RgbColorModelHex>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  private static DMW.SchemeColor? GetSchemeColor(DXO2010W.Shadow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.SchemeColor>();
    if (element != null)
      return DMXW.SchemeColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemeColor(DXO2010W.Shadow openXmlElement, DMW.SchemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXW.SchemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.SchemeColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSchemeColor(DXO2010W.Shadow openXmlElement, DMW.SchemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.SchemeColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SchemeColorConverter.CreateOpenXmlElement<DXO2010W.SchemeColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Shadow2? CreateModelElement(DXO2010W.Shadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Shadow2();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.DistanceFromText = GetDistanceFromText(openXmlElement);
      value.DirectionAngle = GetDirectionAngle(openXmlElement);
      value.HorizontalScalingFactor = GetHorizontalScalingFactor(openXmlElement);
      value.VerticalScalingFactor = GetVerticalScalingFactor(openXmlElement);
      value.HorizontalSkewAngle = GetHorizontalSkewAngle(openXmlElement);
      value.VerticalSkewAngle = GetVerticalSkewAngle(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.Shadow? openXmlElement, DMW.Shadow2? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlurRadius(openXmlElement, value.BlurRadius, diffs, objName))
        ok = false;
      if (!CmpDistanceFromText(openXmlElement, value.DistanceFromText, diffs, objName))
        ok = false;
      if (!CmpDirectionAngle(openXmlElement, value.DirectionAngle, diffs, objName))
        ok = false;
      if (!CmpHorizontalScalingFactor(openXmlElement, value.HorizontalScalingFactor, diffs, objName))
        ok = false;
      if (!CmpVerticalScalingFactor(openXmlElement, value.VerticalScalingFactor, diffs, objName))
        ok = false;
      if (!CmpHorizontalSkewAngle(openXmlElement, value.HorizontalSkewAngle, diffs, objName))
        ok = false;
      if (!CmpVerticalSkewAngle(openXmlElement, value.VerticalSkewAngle, diffs, objName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      if (!CmpRgbColorModelHex(openXmlElement, value.RgbColorModelHex, diffs, objName))
        ok = false;
      if (!CmpSchemeColor(openXmlElement, value.SchemeColor, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Shadow2? value)
    where OpenXmlElementType: DXO2010W.Shadow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlurRadius(openXmlElement, value?.BlurRadius);
      SetDistanceFromText(openXmlElement, value?.DistanceFromText);
      SetDirectionAngle(openXmlElement, value?.DirectionAngle);
      SetHorizontalScalingFactor(openXmlElement, value?.HorizontalScalingFactor);
      SetVerticalScalingFactor(openXmlElement, value?.VerticalScalingFactor);
      SetHorizontalSkewAngle(openXmlElement, value?.HorizontalSkewAngle);
      SetVerticalSkewAngle(openXmlElement, value?.VerticalSkewAngle);
      SetAlignment(openXmlElement, value?.Alignment);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      return openXmlElement;
    }
    return default;
  }
}
