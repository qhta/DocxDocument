namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleSerExtension Class.
/// </summary>
public static class BubbleSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.BubbleSerExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.BubbleSerExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.BubbleSerExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.InvertSolidFillFormat? GetInvertSolidFillFormat(DXDC.BubbleSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DC.InvertSolidFillFormat>();
    if (element != null)
      return DMXDC.InvertSolidFillFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInvertSolidFillFormat(DXDC.BubbleSerExtension openXmlElement, DMDC.InvertSolidFillFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.InvertSolidFillFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DC.InvertSolidFillFormat>(), value, diffs, objName, propName);
  }
  
  private static void SetInvertSolidFillFormat(DXDC.BubbleSerExtension openXmlElement, DMDC.InvertSolidFillFormat? value)
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
  
  private static DMDC.FilteredCategoryTitle? GetFilteredCategoryTitle(DXDC.BubbleSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredCategoryTitle>();
    if (element != null)
      return DMXDC.FilteredCategoryTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredCategoryTitle(DXDC.BubbleSerExtension openXmlElement, DMDC.FilteredCategoryTitle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredCategoryTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredCategoryTitle>(), value, diffs, objName, propName);
  }
  
  private static void SetFilteredCategoryTitle(DXDC.BubbleSerExtension openXmlElement, DMDC.FilteredCategoryTitle? value)
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
  
  private static DMDC.DataLabelsRange? GetDataLabelsRange(DXDC.BubbleSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.DataLabelsRange>();
    if (element != null)
      return DMXDC.DataLabelsRangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelsRange(DXDC.BubbleSerExtension openXmlElement, DMDC.DataLabelsRange? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsRangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.DataLabelsRange>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabelsRange(DXDC.BubbleSerExtension openXmlElement, DMDC.DataLabelsRange? value)
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
  
  private static DMDC.CategoryFilterExceptions? GetCategoryFilterExceptions(DXDC.BubbleSerExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.CategoryFilterExceptions>();
    if (element != null)
      return DMXDC.CategoryFilterExceptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryFilterExceptions(DXDC.BubbleSerExtension openXmlElement, DMDC.CategoryFilterExceptions? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.CategoryFilterExceptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.CategoryFilterExceptions>(), value, diffs, objName, propName);
  }
  
  private static void SetCategoryFilterExceptions(DXDC.BubbleSerExtension openXmlElement, DMDC.CategoryFilterExceptions? value)
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
  
  public static DMD.Charts.BubbleSerExtension? CreateModelElement(DXDC.BubbleSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.BubbleSerExtension();
      value.Uri = GetUri(openXmlElement);
      value.InvertSolidFillFormat = GetInvertSolidFillFormat(openXmlElement);
      value.FilteredCategoryTitle = GetFilteredCategoryTitle(openXmlElement);
      value.DataLabelsRange = GetDataLabelsRange(openXmlElement);
      value.CategoryFilterExceptions = GetCategoryFilterExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.BubbleSerExtension? openXmlElement, DMDC.BubbleSerExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpInvertSolidFillFormat(openXmlElement, value.InvertSolidFillFormat, diffs, objName, propName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BubbleSerExtension value)
    where OpenXmlElementType: DXDC.BubbleSerExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BubbleSerExtension openXmlElement, DMDC.BubbleSerExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetInvertSolidFillFormat(openXmlElement, value?.InvertSolidFillFormat);
    SetFilteredCategoryTitle(openXmlElement, value?.FilteredCategoryTitle);
    SetDataLabelsRange(openXmlElement, value?.DataLabelsRange);
    SetCategoryFilterExceptions(openXmlElement, value?.CategoryFilterExceptions);
  }
}
