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
    return openXmlElement.BlurRadius?.Value;
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
    return openXmlElement.DistanceFromText?.Value;
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
    return openXmlElement.DirectionAngle?.Value;
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
    return openXmlElement.HorizontalScalingFactor?.Value;
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
    return openXmlElement.VerticalScalingFactor?.Value;
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
    return openXmlElement.HorizontalSkewAngle?.Value;
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
    return openXmlElement.VerticalSkewAngle?.Value;
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
  
  private static void SetAlignment(DXO2010W.Shadow openXmlElement, DMW.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DMW.RectangleAlignmentKind>(value);
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  private static DMW.RgbColorModelHex? GetRgbColorModelHex(DXO2010W.Shadow openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.RgbColorModelHex>();
    if (itemElement != null)
      return DMXW.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.SchemeColor>();
    if (itemElement != null)
      return DMXW.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.Shadow2? CreateModelElement(DXO2010W.Shadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Shadow2();
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
