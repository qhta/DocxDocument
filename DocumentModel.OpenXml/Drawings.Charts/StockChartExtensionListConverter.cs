namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StockChartExtensionList Class.
/// </summary>
public static class StockChartExtensionListConverter
{
  private static Collection<DMDC.StockChartExtension>? GetStockChartExtensions(DXDC.StockChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.StockChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.StockChartExtension>())
    {
      var newItem = DMXDC.StockChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStockChartExtensions(DXDC.StockChartExtensionList openXmlElement, Collection<DMDC.StockChartExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.StockChartExtension>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDC.StockChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStockChartExtensions(DXDC.StockChartExtensionList openXmlElement, Collection<DMDC.StockChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.StockChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.StockChartExtensionConverter.CreateOpenXmlElement<DXDC.StockChartExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StockChartExtensionList? CreateModelElement(DXDC.StockChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StockChartExtensionList();
      value.StockChartExtensions = GetStockChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.StockChartExtensionList? openXmlElement, DMDC.StockChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStockChartExtensions(openXmlElement, value.StockChartExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StockChartExtensionList value)
    where OpenXmlElementType: DXDC.StockChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.StockChartExtensionList openXmlElement, DMDC.StockChartExtensionList value)
  {
    SetStockChartExtensions(openXmlElement, value?.StockChartExtensions);
  }
}
