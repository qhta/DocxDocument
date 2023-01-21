namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleEntry Class.
/// </summary>
public static class StyleEntryConverter
{
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  private static DM.ListOf<String>? GetModifiers(DXO2013DrawChartStyle.StyleEntry openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Modifiers);
  }
  
  private static void SetModifiers(DXO2013DrawChartStyle.StyleEntry openXmlElement, DM.ListOf<String>? value)
  {
    if (value != null)
      openXmlElement.Modifiers = ListValueConverter.CreateListValue<DX.StringValue>(value);
    else
      openXmlElement.Modifiers = null;
  }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  private static DMDrawsChartsStyle.LineReference? GetLineReference(DXO2013DrawChartStyle.StyleEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.LineReference>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.LineReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineReference(DXO2013DrawChartStyle.StyleEntry openXmlElement, DMDrawsChartsStyle.LineReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.LineReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.LineReferenceConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.LineReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LineWidthScale.
  /// </summary>
  private static String? GetLineWidthScale(DXO2013DrawChartStyle.StyleEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.LineWidthScale>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetLineWidthScale(DXO2013DrawChartStyle.StyleEntry openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.LineWidthScale>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2013DrawChartStyle.LineWidthScale { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  private static DMDrawsChartsStyle.FillReference? GetFillReference(DXO2013DrawChartStyle.StyleEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.FillReference>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.FillReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillReference(DXO2013DrawChartStyle.StyleEntry openXmlElement, DMDrawsChartsStyle.FillReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.FillReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.FillReferenceConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.FillReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  private static DMDrawsChartsStyle.EffectReference? GetEffectReference(DXO2013DrawChartStyle.StyleEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.EffectReference>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.EffectReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectReference(DXO2013DrawChartStyle.StyleEntry openXmlElement, DMDrawsChartsStyle.EffectReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.EffectReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.EffectReferenceConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.EffectReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  private static DMDrawsChartsStyle.FontReference? GetFontReference(DXO2013DrawChartStyle.StyleEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.FontReference>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.FontReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFontReference(DXO2013DrawChartStyle.StyleEntry openXmlElement, DMDrawsChartsStyle.FontReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.FontReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.FontReferenceConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.FontReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsChartsStyle.ShapeProperties? GetShapeProperties(DXO2013DrawChartStyle.StyleEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXO2013DrawChartStyle.StyleEntry openXmlElement, DMDrawsChartsStyle.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.ShapePropertiesConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  private static DMDrawsChartsStyle.TextCharacterPropertiesType? GetTextCharacterPropertiesType(DXO2013DrawChartStyle.StyleEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TextCharacterPropertiesType>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.TextCharacterPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextCharacterPropertiesType(DXO2013DrawChartStyle.StyleEntry openXmlElement, DMDrawsChartsStyle.TextCharacterPropertiesType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TextCharacterPropertiesType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.TextCharacterPropertiesTypeConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.TextCharacterPropertiesType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  private static DMDrawsChartsStyle.TextBodyProperties? GetTextBodyProperties(DXO2013DrawChartStyle.StyleEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TextBodyProperties>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.TextBodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextBodyProperties(DXO2013DrawChartStyle.StyleEntry openXmlElement, DMDrawsChartsStyle.TextBodyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TextBodyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.TextBodyPropertiesConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.TextBodyProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDrawsChartsStyle.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013DrawChartStyle.StyleEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DXO2013DrawChartStyle.StyleEntry openXmlElement, DMDrawsChartsStyle.OfficeArtExtensionList? value)
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
  
  public static DMDrawsChartsStyle.StyleEntry? CreateModelElement(DXO2013DrawChartStyle.StyleEntry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartsStyle.StyleEntry();
      value.Modifiers = GetModifiers(openXmlElement);
      value.LineReference = GetLineReference(openXmlElement);
      value.LineWidthScale = GetLineWidthScale(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TextCharacterPropertiesType = GetTextCharacterPropertiesType(openXmlElement);
      value.TextBodyProperties = GetTextBodyProperties(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartsStyle.StyleEntry? value)
    where OpenXmlElementType: DXO2013DrawChartStyle.StyleEntry, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetModifiers(openXmlElement, value?.Modifiers);
      SetLineReference(openXmlElement, value?.LineReference);
      SetLineWidthScale(openXmlElement, value?.LineWidthScale);
      SetFillReference(openXmlElement, value?.FillReference);
      SetEffectReference(openXmlElement, value?.EffectReference);
      SetFontReference(openXmlElement, value?.FontReference);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTextCharacterPropertiesType(openXmlElement, value?.TextCharacterPropertiesType);
      SetTextBodyProperties(openXmlElement, value?.TextBodyProperties);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
