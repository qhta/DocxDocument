namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Extensibility container.
/// </summary>
public static class ChartExtensionListConverter
{
  private static Collection<DMDC.DataDisplayOptions16>? GetDataDisplayOptions16s(DXDC.ChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.DataDisplayOptions16>();
    foreach (var item in openXmlElement.Elements<DXDC.DataDisplayOptions16>())
    {
      var newItem = DMXDC.DataDisplayOptions16Converter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataDisplayOptions16s(DXDC.ChartExtensionList openXmlElement, Collection<DMDC.DataDisplayOptions16>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.DataDisplayOptions16>();
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
        if (!DMXDC.DataDisplayOptions16Converter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataDisplayOptions16s(DXDC.ChartExtensionList openXmlElement, Collection<DMDC.DataDisplayOptions16>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.DataDisplayOptions16>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.DataDisplayOptions16Converter.CreateOpenXmlElement<DXDC.DataDisplayOptions16>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartExtensionList? CreateModelElement(DXDC.ChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartExtensionList();
      value.DataDisplayOptions16s = GetDataDisplayOptions16s(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ChartExtensionList? openXmlElement, DMDC.ChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDataDisplayOptions16s(openXmlElement, value.DataDisplayOptions16s, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ChartExtensionList value)
    where OpenXmlElementType: DXDC.ChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ChartExtensionList openXmlElement, DMDC.ChartExtensionList value)
  {
    SetDataDisplayOptions16s(openXmlElement, value?.DataDisplayOptions16s);
  }
}
