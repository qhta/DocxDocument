namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Pie3DChartExtensionList Class.
/// </summary>
public static class Pie3DChartExtensionListConverter
{
  private static Collection<DMDC.Pie3DChartExtension>? GetPie3DChartExtensions(DXDC.Pie3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.Pie3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.Pie3DChartExtension>())
    {
      var newItem = DMXDC.Pie3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPie3DChartExtensions(DXDC.Pie3DChartExtensionList openXmlElement, Collection<DMDC.Pie3DChartExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.Pie3DChartExtension>();
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
        if (!DMXDC.Pie3DChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPie3DChartExtensions(DXDC.Pie3DChartExtensionList openXmlElement, Collection<DMDC.Pie3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.Pie3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.Pie3DChartExtensionConverter.CreateOpenXmlElement<DXDC.Pie3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.Charts.Pie3DChartExtensionList? CreateModelElement(DXDC.Pie3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.Pie3DChartExtensionList();
      value.Pie3DChartExtensions = GetPie3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Pie3DChartExtensionList? openXmlElement, DMDC.Pie3DChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPie3DChartExtensions(openXmlElement, value.Pie3DChartExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Pie3DChartExtensionList value)
    where OpenXmlElementType: DXDC.Pie3DChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Pie3DChartExtensionList openXmlElement, DMDC.Pie3DChartExtensionList value)
  {
    SetPie3DChartExtensions(openXmlElement, value?.Pie3DChartExtensions);
  }
}
