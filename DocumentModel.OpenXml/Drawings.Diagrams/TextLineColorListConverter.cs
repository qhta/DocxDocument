namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Text Line Color List.
/// </summary>
public static class TextLineColorListConverter
{
  private static DMDraws.RgbColorModelPercentage? GetRgbColorModelPercentage(DXDrawDgms.TextLineColorList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>();
    if (itemElement != null)
      return DMXDraws.RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelPercentage(DXDrawDgms.TextLineColorList openXmlElement, DMDraws.RgbColorModelPercentage? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RgbColorModelPercentage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RgbColorModelPercentageConverter.CreateOpenXmlElement<DXDraw.RgbColorModelPercentage>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.RgbColorModelHex? GetRgbColorModelHex(DXDrawDgms.TextLineColorList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>();
    if (itemElement != null)
      return DMXDraws.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelHex(DXDrawDgms.TextLineColorList openXmlElement, DMDraws.RgbColorModelHex? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RgbColorModelHex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RgbColorModelHexConverter.CreateOpenXmlElement<DXDraw.RgbColorModelHex>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HslColor? GetHslColor(DXDrawDgms.TextLineColorList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HslColor>();
    if (itemElement != null)
      return DMXDraws.HslColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHslColor(DXDrawDgms.TextLineColorList openXmlElement, DMDraws.HslColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HslColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HslColorConverter.CreateOpenXmlElement<DXDraw.HslColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.SystemColor? GetSystemColor(DXDrawDgms.TextLineColorList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SystemColor>();
    if (itemElement != null)
      return DMXDraws.SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSystemColor(DXDrawDgms.TextLineColorList openXmlElement, DMDraws.SystemColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SystemColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SystemColorConverter.CreateOpenXmlElement<DXDraw.SystemColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.SchemeColor? GetSchemeColor(DXDrawDgms.TextLineColorList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SchemeColor>();
    if (itemElement != null)
      return DMXDraws.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSchemeColor(DXDrawDgms.TextLineColorList openXmlElement, DMDraws.SchemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SchemeColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SchemeColorConverter.CreateOpenXmlElement<DXDraw.SchemeColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PresetColor? GetPresetColor(DXDrawDgms.TextLineColorList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PresetColor>();
    if (itemElement != null)
      return DMXDraws.PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresetColor(DXDrawDgms.TextLineColorList openXmlElement, DMDraws.PresetColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PresetColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PresetColorConverter.CreateOpenXmlElement<DXDraw.PresetColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.TextLineColorList? CreateModelElement(DXDrawDgms.TextLineColorList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.TextLineColorList();
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.TextLineColorList? value)
    where OpenXmlElementType: DXDrawDgms.TextLineColorList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetHslColor(openXmlElement, value?.HslColor);
      SetSystemColor(openXmlElement, value?.SystemColor);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      SetPresetColor(openXmlElement, value?.PresetColor);
      return openXmlElement;
    }
    return default;
  }
}
