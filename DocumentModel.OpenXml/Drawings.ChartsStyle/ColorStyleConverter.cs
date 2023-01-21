namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the ColorStyle Class.
/// </summary>
public static class ColorStyleConverter
{
  /// <summary>
  /// meth, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetMethod(DXO2013DrawChartStyle.ColorStyle openXmlElement)
  {
    return openXmlElement?.Method?.Value;
  }
  
  private static void SetMethod(DXO2013DrawChartStyle.ColorStyle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Method = new StringValue { Value = value };
    else
      openXmlElement.Method = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetId(DXO2013DrawChartStyle.ColorStyle openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DXO2013DrawChartStyle.ColorStyle openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  private static DMDraws.RgbColorModelPercentage? GetRgbColorModelPercentage(DXO2013DrawChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>();
    if (itemElement != null)
      return DMXDraws.RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelPercentage(DXO2013DrawChartStyle.ColorStyle openXmlElement, DMDraws.RgbColorModelPercentage? value)
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
  
  private static DMDraws.RgbColorModelHex? GetRgbColorModelHex(DXO2013DrawChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>();
    if (itemElement != null)
      return DMXDraws.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelHex(DXO2013DrawChartStyle.ColorStyle openXmlElement, DMDraws.RgbColorModelHex? value)
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
  
  private static DMDraws.HslColor? GetHslColor(DXO2013DrawChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HslColor>();
    if (itemElement != null)
      return DMXDraws.HslColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHslColor(DXO2013DrawChartStyle.ColorStyle openXmlElement, DMDraws.HslColor? value)
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
  
  private static DMDraws.SystemColor? GetSystemColor(DXO2013DrawChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SystemColor>();
    if (itemElement != null)
      return DMXDraws.SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSystemColor(DXO2013DrawChartStyle.ColorStyle openXmlElement, DMDraws.SystemColor? value)
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
  
  private static DMDraws.SchemeColor? GetSchemeColor(DXO2013DrawChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SchemeColor>();
    if (itemElement != null)
      return DMXDraws.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSchemeColor(DXO2013DrawChartStyle.ColorStyle openXmlElement, DMDraws.SchemeColor? value)
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
  
  private static DMDraws.PresetColor? GetPresetColor(DXO2013DrawChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PresetColor>();
    if (itemElement != null)
      return DMXDraws.PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresetColor(DXO2013DrawChartStyle.ColorStyle openXmlElement, DMDraws.PresetColor? value)
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
  
  private static Collection<DMDrawsChartsStyle.ColorStyleVariation> GetColorStyleVariations(DXO2013DrawChartStyle.ColorStyle openXmlElement)
  {
    var collection = new Collection<DMDrawsChartsStyle.ColorStyleVariation>();
    foreach (var item in openXmlElement.Elements<DXO2013DrawChartStyle.ColorStyleVariation>())
    {
      var newItem = DMXDrawsChartsStyle.ColorStyleVariationConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetColorStyleVariations(DXO2013DrawChartStyle.ColorStyle openXmlElement, Collection<DMDrawsChartsStyle.ColorStyleVariation>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2013DrawChartStyle.ColorStyleVariation>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartsStyle.ColorStyleVariationConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.ColorStyleVariation>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsChartsStyle.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013DrawChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DXO2013DrawChartStyle.ColorStyle openXmlElement, DMDrawsChartsStyle.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartsStyle.ColorStyle? CreateModelElement(DXO2013DrawChartStyle.ColorStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartsStyle.ColorStyle();
      value.Method = GetMethod(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      value.ColorStyleVariations = GetColorStyleVariations(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartsStyle.ColorStyle? value)
    where OpenXmlElementType: DXO2013DrawChartStyle.ColorStyle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMethod(openXmlElement, value?.Method);
      SetId(openXmlElement, value?.Id);
      SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetHslColor(openXmlElement, value?.HslColor);
      SetSystemColor(openXmlElement, value?.SystemColor);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      SetPresetColor(openXmlElement, value?.PresetColor);
      SetColorStyleVariations(openXmlElement, value?.ColorStyleVariations);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
