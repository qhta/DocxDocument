namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarSerExtension Class.
/// </summary>
public static class BarSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.BarSerExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.BarSerExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.BarSerExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.InvertSolidFillFormat? GetInvertSolidFillFormat(DXDC.BarSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DC.InvertSolidFillFormat>();
    if (element != null)
      return DMXDC.InvertSolidFillFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInvertSolidFillFormat(DXDC.BarSerExtension openXmlElement, DMDC.InvertSolidFillFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.InvertSolidFillFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DC.InvertSolidFillFormat>(), value, diffs, objName, propName);
  }
  
  private static void SetInvertSolidFillFormat(DXDC.BarSerExtension openXmlElement, DMDC.InvertSolidFillFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10DC.InvertSolidFillFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.InvertSolidFillFormatConverter.CreateOpenXmlElement<DXO10DC.InvertSolidFillFormat>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.FilteredSeriesTitle? GetFilteredSeriesTitle(DXDC.BarSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredSeriesTitle>();
    if (element != null)
      return DMXDC.FilteredSeriesTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredSeriesTitle(DXDC.BarSerExtension openXmlElement, DMDC.FilteredSeriesTitle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredSeriesTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredSeriesTitle>(), value, diffs, objName, propName);
  }
  
  private static void SetFilteredSeriesTitle(DXDC.BarSerExtension openXmlElement, DMDC.FilteredSeriesTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredSeriesTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredSeriesTitleConverter.CreateOpenXmlElement<DXO13DC.FilteredSeriesTitle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.FilteredCategoryTitle? GetFilteredCategoryTitle(DXDC.BarSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredCategoryTitle>();
    if (element != null)
      return DMXDC.FilteredCategoryTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredCategoryTitle(DXDC.BarSerExtension openXmlElement, DMDC.FilteredCategoryTitle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredCategoryTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredCategoryTitle>(), value, diffs, objName, propName);
  }
  
  private static void SetFilteredCategoryTitle(DXDC.BarSerExtension openXmlElement, DMDC.FilteredCategoryTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredCategoryTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredCategoryTitleConverter.CreateOpenXmlElement<DXO13DC.FilteredCategoryTitle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.DataLabelsRange? GetDataLabelsRange(DXDC.BarSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.DataLabelsRange>();
    if (element != null)
      return DMXDC.DataLabelsRangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelsRange(DXDC.BarSerExtension openXmlElement, DMDC.DataLabelsRange? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsRangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.DataLabelsRange>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabelsRange(DXDC.BarSerExtension openXmlElement, DMDC.DataLabelsRange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.DataLabelsRange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataLabelsRangeConverter.CreateOpenXmlElement<DXO13DC.DataLabelsRange>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.CategoryFilterExceptions? GetCategoryFilterExceptions(DXDC.BarSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.CategoryFilterExceptions>();
    if (element != null)
      return DMXDC.CategoryFilterExceptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryFilterExceptions(DXDC.BarSerExtension openXmlElement, DMDC.CategoryFilterExceptions? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.CategoryFilterExceptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.CategoryFilterExceptions>(), value, diffs, objName, propName);
  }
  
  private static void SetCategoryFilterExceptions(DXDC.BarSerExtension openXmlElement, DMDC.CategoryFilterExceptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.CategoryFilterExceptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.CategoryFilterExceptionsConverter.CreateOpenXmlElement<DXO13DC.CategoryFilterExceptions>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarSerExtension? CreateModelElement(DXDC.BarSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarSerExtension();
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
  
  public static bool CompareModelElement(DXDC.BarSerExtension? openXmlElement, DMDC.BarSerExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpInvertSolidFillFormat(openXmlElement, value.InvertSolidFillFormat, diffs, objName, propName))
        ok = false;
      if (!CmpFilteredSeriesTitle(openXmlElement, value.FilteredSeriesTitle, diffs, objName, propName))
        ok = false;
      if (!CmpFilteredCategoryTitle(openXmlElement, value.FilteredCategoryTitle, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabelsRange(openXmlElement, value.DataLabelsRange, diffs, objName, propName))
        ok = false;
      if (!CmpCategoryFilterExceptions(openXmlElement, value.CategoryFilterExceptions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BarSerExtension value)
    where OpenXmlElementType: DXDC.BarSerExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BarSerExtension openXmlElement, DMDC.BarSerExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetInvertSolidFillFormat(openXmlElement, value?.InvertSolidFillFormat);
    SetFilteredSeriesTitle(openXmlElement, value?.FilteredSeriesTitle);
    SetFilteredCategoryTitle(openXmlElement, value?.FilteredCategoryTitle);
    SetDataLabelsRange(openXmlElement, value?.DataLabelsRange);
    SetCategoryFilterExceptions(openXmlElement, value?.CategoryFilterExceptions);
  }
}
