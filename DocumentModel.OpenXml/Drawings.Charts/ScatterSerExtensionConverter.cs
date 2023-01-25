namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterSerExtension Class.
/// </summary>
public static class ScatterSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.ScatterSerExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.ScatterSerExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.ScatterSerExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredSeriesTitle? GetFilteredSeriesTitle(DXDrawCharts.ScatterSerExtension openXmlElement)
  {
    return DMXDrawsCharts.FilteredSeriesTitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredSeriesTitle>());
  }
  
  private static bool CmpFilteredSeriesTitle(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.FilteredSeriesTitle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredSeriesTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredSeriesTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredSeriesTitle(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.FilteredSeriesTitle? value)
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
  
  private static DMDrawsCharts.FilteredCategoryTitle? GetFilteredCategoryTitle(DXDrawCharts.ScatterSerExtension openXmlElement)
  {
    return DMXDrawsCharts.FilteredCategoryTitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredCategoryTitle>());
  }
  
  private static bool CmpFilteredCategoryTitle(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.FilteredCategoryTitle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredCategoryTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredCategoryTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredCategoryTitle(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.FilteredCategoryTitle? value)
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
  
  private static DMDrawsCharts.DataLabelsRange? GetDataLabelsRange(DXDrawCharts.ScatterSerExtension openXmlElement)
  {
    return DMXDrawsCharts.DataLabelsRangeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelsRange>());
  }
  
  private static bool CmpDataLabelsRange(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.DataLabelsRange? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsRangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabelsRange>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataLabelsRange(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.DataLabelsRange? value)
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
  
  private static DMDrawsCharts.CategoryFilterExceptions? GetCategoryFilterExceptions(DXDrawCharts.ScatterSerExtension openXmlElement)
  {
    return DMXDrawsCharts.CategoryFilterExceptionsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.CategoryFilterExceptions>());
  }
  
  private static bool CmpCategoryFilterExceptions(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.CategoryFilterExceptions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CategoryFilterExceptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.CategoryFilterExceptions>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCategoryFilterExceptions(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.CategoryFilterExceptions? value)
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
  
  public static DMDrawsCharts.ScatterSerExtension? CreateModelElement(DXDrawCharts.ScatterSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ScatterSerExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSeriesTitle = GetFilteredSeriesTitle(openXmlElement);
      value.FilteredCategoryTitle = GetFilteredCategoryTitle(openXmlElement);
      value.DataLabelsRange = GetDataLabelsRange(openXmlElement);
      value.CategoryFilterExceptions = GetCategoryFilterExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ScatterSerExtension? openXmlElement, DMDrawsCharts.ScatterSerExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredSeriesTitle(openXmlElement, value.FilteredSeriesTitle, diffs, objName))
        ok = false;
      if (!CmpFilteredCategoryTitle(openXmlElement, value.FilteredCategoryTitle, diffs, objName))
        ok = false;
      if (!CmpDataLabelsRange(openXmlElement, value.DataLabelsRange, diffs, objName))
        ok = false;
      if (!CmpCategoryFilterExceptions(openXmlElement, value.CategoryFilterExceptions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ScatterSerExtension? value)
    where OpenXmlElementType: DXDrawCharts.ScatterSerExtension, new()
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
