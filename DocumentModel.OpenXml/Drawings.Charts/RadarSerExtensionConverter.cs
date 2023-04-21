namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the RadarSerExtension Class.
/// </summary>
public static class RadarSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.RadarSerExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.RadarSerExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.RadarSerExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredSeriesTitle? GetFilteredSeriesTitle(DXDC.RadarSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredSeriesTitle>();
    if (element != null)
      return DMXDC.FilteredSeriesTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredSeriesTitle(DXDC.RadarSerExtension openXmlElement, DMDC.FilteredSeriesTitle? value, DiffList? diffs, string? objName)
  {
    return DMXDC.FilteredSeriesTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredSeriesTitle>(), value, diffs, objName);
  }
  
  private static void SetFilteredSeriesTitle(DXDC.RadarSerExtension openXmlElement, DMDC.FilteredSeriesTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredSeriesTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredSeriesTitleConverter.CreateOpenXmlElement<DXO13DC.FilteredSeriesTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDC.FilteredCategoryTitle? GetFilteredCategoryTitle(DXDC.RadarSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredCategoryTitle>();
    if (element != null)
      return DMXDC.FilteredCategoryTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredCategoryTitle(DXDC.RadarSerExtension openXmlElement, DMDC.FilteredCategoryTitle? value, DiffList? diffs, string? objName)
  {
    return DMXDC.FilteredCategoryTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredCategoryTitle>(), value, diffs, objName);
  }
  
  private static void SetFilteredCategoryTitle(DXDC.RadarSerExtension openXmlElement, DMDC.FilteredCategoryTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredCategoryTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredCategoryTitleConverter.CreateOpenXmlElement<DXO13DC.FilteredCategoryTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDC.DataLabelsRange? GetDataLabelsRange(DXDC.RadarSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.DataLabelsRange>();
    if (element != null)
      return DMXDC.DataLabelsRangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelsRange(DXDC.RadarSerExtension openXmlElement, DMDC.DataLabelsRange? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DataLabelsRangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.DataLabelsRange>(), value, diffs, objName);
  }
  
  private static void SetDataLabelsRange(DXDC.RadarSerExtension openXmlElement, DMDC.DataLabelsRange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.DataLabelsRange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataLabelsRangeConverter.CreateOpenXmlElement<DXO13DC.DataLabelsRange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDC.CategoryFilterExceptions? GetCategoryFilterExceptions(DXDC.RadarSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.CategoryFilterExceptions>();
    if (element != null)
      return DMXDC.CategoryFilterExceptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryFilterExceptions(DXDC.RadarSerExtension openXmlElement, DMDC.CategoryFilterExceptions? value, DiffList? diffs, string? objName)
  {
    return DMXDC.CategoryFilterExceptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.CategoryFilterExceptions>(), value, diffs, objName);
  }
  
  private static void SetCategoryFilterExceptions(DXDC.RadarSerExtension openXmlElement, DMDC.CategoryFilterExceptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.CategoryFilterExceptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.CategoryFilterExceptionsConverter.CreateOpenXmlElement<DXO13DC.CategoryFilterExceptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.RadarSerExtension? CreateModelElement(DXDC.RadarSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.RadarSerExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSeriesTitle = GetFilteredSeriesTitle(openXmlElement);
      value.FilteredCategoryTitle = GetFilteredCategoryTitle(openXmlElement);
      value.DataLabelsRange = GetDataLabelsRange(openXmlElement);
      value.CategoryFilterExceptions = GetCategoryFilterExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.RadarSerExtension? openXmlElement, DMDC.RadarSerExtension? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.RadarSerExtension value)
    where OpenXmlElementType: DXDC.RadarSerExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.RadarSerExtension openXmlElement, DMDC.RadarSerExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredSeriesTitle(openXmlElement, value?.FilteredSeriesTitle);
    SetFilteredCategoryTitle(openXmlElement, value?.FilteredCategoryTitle);
    SetDataLabelsRange(openXmlElement, value?.DataLabelsRange);
    SetCategoryFilterExceptions(openXmlElement, value?.CategoryFilterExceptions);
  }
}
