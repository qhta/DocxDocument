namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LineChartExtensionList Class.
/// </summary>
public static class LineChartExtensionListConverter
{
  private static Collection<DMDC.LineChartExtension>? GetLineChartExtensions(DXDC.LineChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.LineChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.LineChartExtension>())
    {
      var newItem = DMXDC.LineChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpLineChartExtensions(DXDC.LineChartExtensionList openXmlElement, Collection<DMDC.LineChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.LineChartExtension>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDC.LineChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLineChartExtensions(DXDC.LineChartExtensionList openXmlElement, Collection<DMDC.LineChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.LineChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.LineChartExtensionConverter.CreateOpenXmlElement<DXDC.LineChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.LineChartExtensionList? CreateModelElement(DXDC.LineChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LineChartExtensionList();
      value.LineChartExtensions = GetLineChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.LineChartExtensionList? openXmlElement, DMDC.LineChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineChartExtensions(openXmlElement, value.LineChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.LineChartExtensionList value)
    where OpenXmlElementType: DXDC.LineChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.LineChartExtensionList openXmlElement, DMDC.LineChartExtensionList value)
  {
    SetLineChartExtensions(openXmlElement, value?.LineChartExtensions);
  }
}
