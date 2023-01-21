namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the GradientStop Class.
/// </summary>
public static class GradientStopConverter
{
  /// <summary>
  /// pos, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetStopPosition(DXO2010W.GradientStop openXmlElement)
  {
    return openXmlElement.StopPosition?.Value;
  }
  
  private static void SetStopPosition(DXO2010W.GradientStop openXmlElement, Int32? value)
  {
    openXmlElement.StopPosition = value;
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  private static DMW.RgbColorModelHex? GetRgbColorModelHex(DXO2010W.GradientStop openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.RgbColorModelHex>();
    if (itemElement != null)
      return DMXW.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelHex(DXO2010W.GradientStop openXmlElement, DMW.RgbColorModelHex? value)
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
  private static DMW.SchemeColor? GetSchemeColor(DXO2010W.GradientStop openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.SchemeColor>();
    if (itemElement != null)
      return DMXW.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSchemeColor(DXO2010W.GradientStop openXmlElement, DMW.SchemeColor? value)
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
  
  public static DMW.GradientStop? CreateModelElement(DXO2010W.GradientStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.GradientStop();
      value.StopPosition = GetStopPosition(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.GradientStop? value)
    where OpenXmlElementType: DXO2010W.GradientStop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStopPosition(openXmlElement, value?.StopPosition);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      return openXmlElement;
    }
    return default;
  }
}
