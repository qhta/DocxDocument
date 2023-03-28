namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterSerExtension Class converter from/to OpenXml.
///</summary>
public static class ScatterSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.ScatterSerExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDrawCharts.ScatterSerExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDrawCharts.ScatterSerExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsCharts.FilteredSeriesTitle? GetFilteredSeriesTitle(DXDrawCharts.ScatterSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredSeriesTitle>();
    if (element != null)
      return DMXDrawsCharts.FilteredSeriesTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredSeriesTitle(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.FilteredSeriesTitle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredSeriesTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredSeriesTitle>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredCategoryTitle>();
    if (element != null)
      return DMXDrawsCharts.FilteredCategoryTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredCategoryTitle(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.FilteredCategoryTitle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredCategoryTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredCategoryTitle>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelsRange>();
    if (element != null)
      return DMXDrawsCharts.DataLabelsRangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelsRange(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.DataLabelsRange? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsRangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabelsRange>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.CategoryFilterExceptions>();
    if (element != null)
      return DMXDrawsCharts.CategoryFilterExceptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryFilterExceptions(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.CategoryFilterExceptions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CategoryFilterExceptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.CategoryFilterExceptions>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.Charts.ScatterSerExtension? CreateModelElement(DXDrawCharts.ScatterSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterSerExtension();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ScatterSerExtension value)
    where OpenXmlElementType: DXDrawCharts.ScatterSerExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ScatterSerExtension openXmlElement, DMDrawsCharts.ScatterSerExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredSeriesTitle(openXmlElement, value?.FilteredSeriesTitle);
    SetFilteredCategoryTitle(openXmlElement, value?.FilteredCategoryTitle);
    SetDataLabelsRange(openXmlElement, value?.DataLabelsRange);
    SetCategoryFilterExceptions(openXmlElement, value?.CategoryFilterExceptions);
  }
}
