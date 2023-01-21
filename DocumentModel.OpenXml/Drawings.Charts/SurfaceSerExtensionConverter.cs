namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceSerExtension Class.
/// </summary>
public static class SurfaceSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.SurfaceSerExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.SurfaceSerExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredSeriesTitle? GetFilteredSeriesTitle(DXDrawCharts.SurfaceSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredSeriesTitle>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredSeriesTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredSeriesTitle(DXDrawCharts.SurfaceSerExtension openXmlElement, DMDrawsCharts.FilteredSeriesTitle? value)
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
  
  private static DMDrawsCharts.FilteredCategoryTitle? GetFilteredCategoryTitle(DXDrawCharts.SurfaceSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredCategoryTitle>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredCategoryTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredCategoryTitle(DXDrawCharts.SurfaceSerExtension openXmlElement, DMDrawsCharts.FilteredCategoryTitle? value)
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
  
  private static DMDrawsCharts.CategoryFilterExceptions? GetCategoryFilterExceptions(DXDrawCharts.SurfaceSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.CategoryFilterExceptions>();
    if (itemElement != null)
      return DMXDrawsCharts.CategoryFilterExceptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategoryFilterExceptions(DXDrawCharts.SurfaceSerExtension openXmlElement, DMDrawsCharts.CategoryFilterExceptions? value)
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
  
  public static DMDrawsCharts.SurfaceSerExtension? CreateModelElement(DXDrawCharts.SurfaceSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SurfaceSerExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSeriesTitle = GetFilteredSeriesTitle(openXmlElement);
      value.FilteredCategoryTitle = GetFilteredCategoryTitle(openXmlElement);
      value.CategoryFilterExceptions = GetCategoryFilterExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceSerExtension? value)
    where OpenXmlElementType: DXDrawCharts.SurfaceSerExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredSeriesTitle(openXmlElement, value?.FilteredSeriesTitle);
      SetFilteredCategoryTitle(openXmlElement, value?.FilteredCategoryTitle);
      SetCategoryFilterExceptions(openXmlElement, value?.CategoryFilterExceptions);
      return openXmlElement;
    }
    return default;
  }
}
