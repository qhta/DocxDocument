namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the FontReference Class.
/// </summary>
public static class FontReferenceConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  private static DMDraws.FontCollectionIndexKind? GetIndex(DXO2013DrawChartStyle.FontReference openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues, DMDraws.FontCollectionIndexKind>(openXmlElement?.Index?.Value);
  }
  
  private static void SetIndex(DXO2013DrawChartStyle.FontReference openXmlElement, DMDraws.FontCollectionIndexKind? value)
  {
    openXmlElement.Index = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues, DMDraws.FontCollectionIndexKind>(value);
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  private static DM.ListOf<String>? GetModifiers(DXO2013DrawChartStyle.FontReference openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Modifiers);
  }
  
  private static void SetModifiers(DXO2013DrawChartStyle.FontReference openXmlElement, DM.ListOf<String>? value)
  {
    if (value != null)
      openXmlElement.Modifiers = ListValueConverter.CreateListValue<DX.StringValue>(value);
    else
      openXmlElement.Modifiers = null;
  }
  
  private static DMDraws.RgbColorModelPercentage? GetRgbColorModelPercentage(DXO2013DrawChartStyle.FontReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>();
    if (itemElement != null)
      return DMXDraws.RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelPercentage(DXO2013DrawChartStyle.FontReference openXmlElement, DMDraws.RgbColorModelPercentage? value)
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
  
  private static DMDraws.RgbColorModelHex? GetRgbColorModelHex(DXO2013DrawChartStyle.FontReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>();
    if (itemElement != null)
      return DMXDraws.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelHex(DXO2013DrawChartStyle.FontReference openXmlElement, DMDraws.RgbColorModelHex? value)
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
  
  private static DMDraws.HslColor? GetHslColor(DXO2013DrawChartStyle.FontReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HslColor>();
    if (itemElement != null)
      return DMXDraws.HslColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHslColor(DXO2013DrawChartStyle.FontReference openXmlElement, DMDraws.HslColor? value)
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
  
  private static DMDraws.SystemColor? GetSystemColor(DXO2013DrawChartStyle.FontReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SystemColor>();
    if (itemElement != null)
      return DMXDraws.SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSystemColor(DXO2013DrawChartStyle.FontReference openXmlElement, DMDraws.SystemColor? value)
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
  
  private static DMDraws.SchemeColor? GetSchemeColor(DXO2013DrawChartStyle.FontReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SchemeColor>();
    if (itemElement != null)
      return DMXDraws.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSchemeColor(DXO2013DrawChartStyle.FontReference openXmlElement, DMDraws.SchemeColor? value)
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
  
  private static DMDraws.PresetColor? GetPresetColor(DXO2013DrawChartStyle.FontReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PresetColor>();
    if (itemElement != null)
      return DMXDraws.PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresetColor(DXO2013DrawChartStyle.FontReference openXmlElement, DMDraws.PresetColor? value)
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
  
  private static DMDrawsChartsStyle.StyleColor? GetStyleColor(DXO2013DrawChartStyle.FontReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.StyleColor>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.StyleColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStyleColor(DXO2013DrawChartStyle.FontReference openXmlElement, DMDrawsChartsStyle.StyleColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.StyleColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.StyleColorConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.StyleColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartsStyle.FontReference? CreateModelElement(DXO2013DrawChartStyle.FontReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartsStyle.FontReference();
      value.Index = GetIndex(openXmlElement);
      value.Modifiers = GetModifiers(openXmlElement);
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      value.StyleColor = GetStyleColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartsStyle.FontReference? value)
    where OpenXmlElementType: DXO2013DrawChartStyle.FontReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetModifiers(openXmlElement, value?.Modifiers);
      SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetHslColor(openXmlElement, value?.HslColor);
      SetSystemColor(openXmlElement, value?.SystemColor);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      SetPresetColor(openXmlElement, value?.PresetColor);
      SetStyleColor(openXmlElement, value?.StyleColor);
      return openXmlElement;
    }
    return default;
  }
}
