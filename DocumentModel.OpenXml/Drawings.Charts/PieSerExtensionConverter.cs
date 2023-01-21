namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PieSerExtension Class.
/// </summary>
public static class PieSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.PieSerExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.PieSerExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredSeriesTitle? GetFilteredSeriesTitle(DXDrawCharts.PieSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredSeriesTitle>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredSeriesTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredSeriesTitle(DXDrawCharts.PieSerExtension openXmlElement, DMDrawsCharts.FilteredSeriesTitle? value)
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
  
  private static DMDrawsCharts.FilteredCategoryTitle? GetFilteredCategoryTitle(DXDrawCharts.PieSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredCategoryTitle>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredCategoryTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredCategoryTitle(DXDrawCharts.PieSerExtension openXmlElement, DMDrawsCharts.FilteredCategoryTitle? value)
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
  
  private static DMDrawsCharts.DataLabelsRange? GetDataLabelsRange(DXDrawCharts.PieSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelsRange>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsRangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabelsRange(DXDrawCharts.PieSerExtension openXmlElement, DMDrawsCharts.DataLabelsRange? value)
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
  
  private static DMDrawsCharts.CategoryFilterExceptions? GetCategoryFilterExceptions(DXDrawCharts.PieSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.CategoryFilterExceptions>();
    if (itemElement != null)
      return DMXDrawsCharts.CategoryFilterExceptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategoryFilterExceptions(DXDrawCharts.PieSerExtension openXmlElement, DMDrawsCharts.CategoryFilterExceptions? value)
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
  
  public static DMDrawsCharts.PieSerExtension? CreateModelElement(DXDrawCharts.PieSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PieSerExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSeriesTitle = GetFilteredSeriesTitle(openXmlElement);
      value.FilteredCategoryTitle = GetFilteredCategoryTitle(openXmlElement);
      value.DataLabelsRange = GetDataLabelsRange(openXmlElement);
      value.CategoryFilterExceptions = GetCategoryFilterExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PieSerExtension? value)
    where OpenXmlElementType: DXDrawCharts.PieSerExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredSeriesTitle(openXmlElement, value?.FilteredSeriesTitle);
      SetFilteredCategoryTitle(openXmlElement, value?.FilteredCategoryTitle);
      SetDataLabelsRange(openXmlElement, value?.DataLabelsRange);
      SetCategoryFilterExceptions(openXmlElement, value?.CategoryFilterExceptions);
      return openXmlElement;
    }
    return default;
  }
}
