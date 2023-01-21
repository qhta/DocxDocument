namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Hyperlink.
/// </summary>
public static class HyperlinkConverter
{
  private static DMDraws.RgbColorModelPercentage? GetRgbColorModelPercentage(DXDraw.Hyperlink openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>();
    if (itemElement != null)
      return DMXDraws.RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelPercentage(DXDraw.Hyperlink openXmlElement, DMDraws.RgbColorModelPercentage? value)
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
  
  private static DMDraws.RgbColorModelHex? GetRgbColorModelHex(DXDraw.Hyperlink openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>();
    if (itemElement != null)
      return DMXDraws.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelHex(DXDraw.Hyperlink openXmlElement, DMDraws.RgbColorModelHex? value)
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
  
  private static DMDraws.HslColor? GetHslColor(DXDraw.Hyperlink openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HslColor>();
    if (itemElement != null)
      return DMXDraws.HslColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHslColor(DXDraw.Hyperlink openXmlElement, DMDraws.HslColor? value)
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
  
  private static DMDraws.SystemColor? GetSystemColor(DXDraw.Hyperlink openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SystemColor>();
    if (itemElement != null)
      return DMXDraws.SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSystemColor(DXDraw.Hyperlink openXmlElement, DMDraws.SystemColor? value)
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
  
  private static DMDraws.PresetColor? GetPresetColor(DXDraw.Hyperlink openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PresetColor>();
    if (itemElement != null)
      return DMXDraws.PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresetColor(DXDraw.Hyperlink openXmlElement, DMDraws.PresetColor? value)
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
  
  public static DMDraws.Hyperlink? CreateModelElement(DXDraw.Hyperlink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Hyperlink();
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Hyperlink? value)
    where OpenXmlElementType: DXDraw.Hyperlink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetHslColor(openXmlElement, value?.HslColor);
      SetSystemColor(openXmlElement, value?.SystemColor);
      SetPresetColor(openXmlElement, value?.PresetColor);
      return openXmlElement;
    }
    return default;
  }
}
