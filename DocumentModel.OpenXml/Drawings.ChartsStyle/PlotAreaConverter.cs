namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
public static class PlotAreaConverter
{
  private static DMDrawsChartsStyle.LineReference? GetLineReference(DXO2013DrawChartStyle.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.LineReference>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.LineReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineReference(DXO2013DrawChartStyle.PlotArea openXmlElement, DMDrawsChartsStyle.LineReference? value)
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
  
  private static String? GetLineWidthScale(DXO2013DrawChartStyle.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.LineWidthScale>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetLineWidthScale(DXO2013DrawChartStyle.PlotArea openXmlElement, String? value)
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
  
  private static DMDrawsChartsStyle.FillReference? GetFillReference(DXO2013DrawChartStyle.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.FillReference>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.FillReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillReference(DXO2013DrawChartStyle.PlotArea openXmlElement, DMDrawsChartsStyle.FillReference? value)
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
  
  private static DMDrawsChartsStyle.EffectReference? GetEffectReference(DXO2013DrawChartStyle.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.EffectReference>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.EffectReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectReference(DXO2013DrawChartStyle.PlotArea openXmlElement, DMDrawsChartsStyle.EffectReference? value)
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
  
  private static DMDrawsChartsStyle.FontReference? GetFontReference(DXO2013DrawChartStyle.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.FontReference>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.FontReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFontReference(DXO2013DrawChartStyle.PlotArea openXmlElement, DMDrawsChartsStyle.FontReference? value)
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
  
  private static DMDrawsChartsStyle.ShapeProperties? GetShapeProperties(DXO2013DrawChartStyle.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXO2013DrawChartStyle.PlotArea openXmlElement, DMDrawsChartsStyle.ShapeProperties? value)
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
  
  private static DMDrawsChartsStyle.TextCharacterPropertiesType? GetTextCharacterPropertiesType(DXO2013DrawChartStyle.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TextCharacterPropertiesType>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.TextCharacterPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextCharacterPropertiesType(DXO2013DrawChartStyle.PlotArea openXmlElement, DMDrawsChartsStyle.TextCharacterPropertiesType? value)
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
  
  private static DMDrawsChartsStyle.TextBodyProperties? GetTextBodyProperties(DXO2013DrawChartStyle.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TextBodyProperties>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.TextBodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextBodyProperties(DXO2013DrawChartStyle.PlotArea openXmlElement, DMDrawsChartsStyle.TextBodyProperties? value)
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
  
  private static DMDrawsChartsStyle.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013DrawChartStyle.PlotArea openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DXO2013DrawChartStyle.PlotArea openXmlElement, DMDrawsChartsStyle.OfficeArtExtensionList? value)
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
  
  public static DMDrawsChartsStyle.PlotArea? CreateModelElement(DXO2013DrawChartStyle.PlotArea? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartsStyle.PlotArea();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartsStyle.PlotArea? value)
    where OpenXmlElementType: DXO2013DrawChartStyle.PlotArea, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
