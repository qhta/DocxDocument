namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ContourColor Class.
/// </summary>
public static class ContourColorConverter
{
  private static DMW.RgbColorModelHex? GetRgbColorModelHex(DXO2010W.ContourColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.RgbColorModelHex>();
    if (itemElement != null)
      return DMXW.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelHex(DXO2010W.ContourColor openXmlElement, DMW.RgbColorModelHex? value)
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
  
  private static DMW.SchemeColor? GetSchemeColor(DXO2010W.ContourColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.SchemeColor>();
    if (itemElement != null)
      return DMXW.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSchemeColor(DXO2010W.ContourColor openXmlElement, DMW.SchemeColor? value)
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
  
  public static DMW.ContourColor? CreateModelElement(DXO2010W.ContourColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ContourColor();
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ContourColor? value)
    where OpenXmlElementType: DXO2010W.ContourColor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      return openXmlElement;
    }
    return default;
  }
}
