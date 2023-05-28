namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterSerExtension Class.
/// </summary>
public static class ScatterSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.ScatterSerExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.ScatterSerExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.ScatterSerExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredSeriesTitle? GetFilteredSeriesTitle(DXDC.ScatterSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredSeriesTitle>();
    if (element != null)
      return DMXDC.FilteredSeriesTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredSeriesTitle(DXDC.ScatterSerExtension openXmlElement, DMDC.FilteredSeriesTitle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredSeriesTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredSeriesTitle>(), value, diffs, objName, propName);
  }
  
  private static void SetFilteredSeriesTitle(DXDC.ScatterSerExtension openXmlElement, DMDC.FilteredSeriesTitle? value)
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
  
  private static DMDC.FilteredCategoryTitle? GetFilteredCategoryTitle(DXDC.ScatterSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredCategoryTitle>();
    if (element != null)
      return DMXDC.FilteredCategoryTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredCategoryTitle(DXDC.ScatterSerExtension openXmlElement, DMDC.FilteredCategoryTitle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredCategoryTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredCategoryTitle>(), value, diffs, objName, propName);
  }
  
  private static void SetFilteredCategoryTitle(DXDC.ScatterSerExtension openXmlElement, DMDC.FilteredCategoryTitle? value)
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
  
  private static DMDC.DataLabelsRange? GetDataLabelsRange(DXDC.ScatterSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.DataLabelsRange>();
    if (element != null)
      return DMXDC.DataLabelsRangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelsRange(DXDC.ScatterSerExtension openXmlElement, DMDC.DataLabelsRange? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsRangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.DataLabelsRange>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabelsRange(DXDC.ScatterSerExtension openXmlElement, DMDC.DataLabelsRange? value)
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
  
  private static DMDC.CategoryFilterExceptions? GetCategoryFilterExceptions(DXDC.ScatterSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.CategoryFilterExceptions>();
    if (element != null)
      return DMXDC.CategoryFilterExceptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryFilterExceptions(DXDC.ScatterSerExtension openXmlElement, DMDC.CategoryFilterExceptions? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.CategoryFilterExceptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.CategoryFilterExceptions>(), value, diffs, objName, propName);
  }
  
  private static void SetCategoryFilterExceptions(DXDC.ScatterSerExtension openXmlElement, DMDC.CategoryFilterExceptions? value)
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
  
  public static DMD.Charts.ScatterSerExtension? CreateModelElement(DXDC.ScatterSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.ScatterSerExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSeriesTitle = GetFilteredSeriesTitle(openXmlElement);
      value.FilteredCategoryTitle = GetFilteredCategoryTitle(openXmlElement);
      value.DataLabelsRange = GetDataLabelsRange(openXmlElement);
      value.CategoryFilterExceptions = GetCategoryFilterExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ScatterSerExtension? openXmlElement, DMDC.ScatterSerExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ScatterSerExtension value)
    where OpenXmlElementType: DXDC.ScatterSerExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ScatterSerExtension openXmlElement, DMDC.ScatterSerExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredSeriesTitle(openXmlElement, value?.FilteredSeriesTitle);
    SetFilteredCategoryTitle(openXmlElement, value?.FilteredCategoryTitle);
    SetDataLabelsRange(openXmlElement, value?.DataLabelsRange);
    SetCategoryFilterExceptions(openXmlElement, value?.CategoryFilterExceptions);
  }
}
