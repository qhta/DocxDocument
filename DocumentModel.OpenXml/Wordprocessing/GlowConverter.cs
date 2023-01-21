namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Glow Class.
/// </summary>
public static class GlowConverter
{
  /// <summary>
  /// rad, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetGlowRadius(DXO2010W.Glow openXmlElement)
  {
    return openXmlElement.GlowRadius?.Value;
  }
  
  private static void SetGlowRadius(DXO2010W.Glow openXmlElement, Int64? value)
  {
    openXmlElement.GlowRadius = value;
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  private static DMW.RgbColorModelHex? GetRgbColorModelHex(DXO2010W.Glow openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.RgbColorModelHex>();
    if (itemElement != null)
      return DMXW.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelHex(DXO2010W.Glow openXmlElement, DMW.RgbColorModelHex? value)
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
  private static DMW.SchemeColor? GetSchemeColor(DXO2010W.Glow openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.SchemeColor>();
    if (itemElement != null)
      return DMXW.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSchemeColor(DXO2010W.Glow openXmlElement, DMW.SchemeColor? value)
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
  
  public static DMW.Glow? CreateModelElement(DXO2010W.Glow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Glow();
      value.GlowRadius = GetGlowRadius(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Glow? value)
    where OpenXmlElementType: DXO2010W.Glow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGlowRadius(openXmlElement, value?.GlowRadius);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      return openXmlElement;
    }
    return default;
  }
}
