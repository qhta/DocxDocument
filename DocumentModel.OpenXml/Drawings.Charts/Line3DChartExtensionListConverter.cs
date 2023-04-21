namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Line3DChartExtensionList Class.
/// </summary>
public static class Line3DChartExtensionListConverter
{
  private static Collection<DMDC.Line3DChartExtension>? GetLine3DChartExtensions(DXDC.Line3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.Line3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.Line3DChartExtension>())
    {
      var newItem = DMXDC.Line3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpLine3DChartExtensions(DXDC.Line3DChartExtensionList openXmlElement, Collection<DMDC.Line3DChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.Line3DChartExtension>();
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
        if (!DMXDC.Line3DChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLine3DChartExtensions(DXDC.Line3DChartExtensionList openXmlElement, Collection<DMDC.Line3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.Line3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.Line3DChartExtensionConverter.CreateOpenXmlElement<DXDC.Line3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Line3DChartExtensionList? CreateModelElement(DXDC.Line3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Line3DChartExtensionList();
      value.Line3DChartExtensions = GetLine3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Line3DChartExtensionList? openXmlElement, DMDC.Line3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLine3DChartExtensions(openXmlElement, value.Line3DChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Line3DChartExtensionList value)
    where OpenXmlElementType: DXDC.Line3DChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Line3DChartExtensionList openXmlElement, DMDC.Line3DChartExtensionList value)
  {
    SetLine3DChartExtensions(openXmlElement, value?.Line3DChartExtensions);
  }
}
