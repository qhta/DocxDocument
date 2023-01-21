namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarSerExtension Class.
/// </summary>
public static class BarSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.BarSerExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.BarSerExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.InvertSolidFillFormat? GetInvertSolidFillFormat(DXDrawCharts.BarSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010DrawCharts.InvertSolidFillFormat>();
    if (itemElement != null)
      return DMXDrawsCharts.InvertSolidFillFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInvertSolidFillFormat(DXDrawCharts.BarSerExtension openXmlElement, DMDrawsCharts.InvertSolidFillFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.InvertSolidFillFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.InvertSolidFillFormatConverter.CreateOpenXmlElement<DXO2010DrawCharts.InvertSolidFillFormat>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.FilteredSeriesTitle? GetFilteredSeriesTitle(DXDrawCharts.BarSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredSeriesTitle>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredSeriesTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredSeriesTitle(DXDrawCharts.BarSerExtension openXmlElement, DMDrawsCharts.FilteredSeriesTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredSeriesTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredSeriesTitleConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredSeriesTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.FilteredCategoryTitle? GetFilteredCategoryTitle(DXDrawCharts.BarSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredCategoryTitle>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredCategoryTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredCategoryTitle(DXDrawCharts.BarSerExtension openXmlElement, DMDrawsCharts.FilteredCategoryTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredCategoryTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredCategoryTitleConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredCategoryTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.DataLabelsRange? GetDataLabelsRange(DXDrawCharts.BarSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelsRange>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsRangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabelsRange(DXDrawCharts.BarSerExtension openXmlElement, DMDrawsCharts.DataLabelsRange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabelsRange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DataLabelsRangeConverter.CreateOpenXmlElement<DXO2013DrawChart.DataLabelsRange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.CategoryFilterExceptions? GetCategoryFilterExceptions(DXDrawCharts.BarSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.CategoryFilterExceptions>();
    if (itemElement != null)
      return DMXDrawsCharts.CategoryFilterExceptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategoryFilterExceptions(DXDrawCharts.BarSerExtension openXmlElement, DMDrawsCharts.CategoryFilterExceptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.CategoryFilterExceptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.CategoryFilterExceptionsConverter.CreateOpenXmlElement<DXO2013DrawChart.CategoryFilterExceptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.BarSerExtension? CreateModelElement(DXDrawCharts.BarSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BarSerExtension();
      value.Uri = GetUri(openXmlElement);
      value.InvertSolidFillFormat = GetInvertSolidFillFormat(openXmlElement);
      value.FilteredSeriesTitle = GetFilteredSeriesTitle(openXmlElement);
      value.FilteredCategoryTitle = GetFilteredCategoryTitle(openXmlElement);
      value.DataLabelsRange = GetDataLabelsRange(openXmlElement);
      value.CategoryFilterExceptions = GetCategoryFilterExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BarSerExtension? value)
    where OpenXmlElementType: DXDrawCharts.BarSerExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetInvertSolidFillFormat(openXmlElement, value?.InvertSolidFillFormat);
      SetFilteredSeriesTitle(openXmlElement, value?.FilteredSeriesTitle);
      SetFilteredCategoryTitle(openXmlElement, value?.FilteredCategoryTitle);
      SetDataLabelsRange(openXmlElement, value?.DataLabelsRange);
      SetCategoryFilterExceptions(openXmlElement, value?.CategoryFilterExceptions);
      return openXmlElement;
    }
    return default;
  }
}
