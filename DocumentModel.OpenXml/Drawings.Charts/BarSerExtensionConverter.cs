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
  
  private static bool CmpUri(DXDrawCharts.BarSerExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
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
    return DMXDrawsCharts.InvertSolidFillFormatConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010DrawCharts.InvertSolidFillFormat>());
  }
  
  private static bool CmpInvertSolidFillFormat(DXDrawCharts.BarSerExtension openXmlElement, DMDrawsCharts.InvertSolidFillFormat? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.InvertSolidFillFormatConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010DrawCharts.InvertSolidFillFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.FilteredSeriesTitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredSeriesTitle>());
  }
  
  private static bool CmpFilteredSeriesTitle(DXDrawCharts.BarSerExtension openXmlElement, DMDrawsCharts.FilteredSeriesTitle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredSeriesTitleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredSeriesTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.FilteredCategoryTitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredCategoryTitle>());
  }
  
  private static bool CmpFilteredCategoryTitle(DXDrawCharts.BarSerExtension openXmlElement, DMDrawsCharts.FilteredCategoryTitle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredCategoryTitleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredCategoryTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.DataLabelsRangeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelsRange>());
  }
  
  private static bool CmpDataLabelsRange(DXDrawCharts.BarSerExtension openXmlElement, DMDrawsCharts.DataLabelsRange? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsRangeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelsRange>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.CategoryFilterExceptionsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.CategoryFilterExceptions>());
  }
  
  private static bool CmpCategoryFilterExceptions(DXDrawCharts.BarSerExtension openXmlElement, DMDrawsCharts.CategoryFilterExceptions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CategoryFilterExceptionsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.CategoryFilterExceptions>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDrawCharts.BarSerExtension? openXmlElement, DMDrawsCharts.BarSerExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpInvertSolidFillFormat(openXmlElement, value.InvertSolidFillFormat, diffs, objName))
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
    return openXmlElement == null && value == null;
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
