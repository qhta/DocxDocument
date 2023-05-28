namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the NumberDiagramInfoList Class.
/// </summary>
public static class NumberDiagramInfoListConverter
{
  private static Collection<DMDD1.NumberDiagramInfo>? GetNumberDiagramInfos(DXO19DD11.NumberDiagramInfoList openXmlElement)
  {
    var collection = new Collection<DMDD1.NumberDiagramInfo>();
    foreach (var item in openXmlElement.Elements<DXO19DD11.NumberDiagramInfo>())
    {
      var newItem = DMXDD1.NumberDiagramInfoConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNumberDiagramInfos(DXO19DD11.NumberDiagramInfoList openXmlElement, Collection<DMDD1.NumberDiagramInfo>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO19DD11.NumberDiagramInfo>();
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
        if (!DMXDD1.NumberDiagramInfoConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNumberDiagramInfos(DXO19DD11.NumberDiagramInfoList openXmlElement, Collection<DMDD1.NumberDiagramInfo>? value)
  {
    openXmlElement.RemoveAllChildren<DXO19DD11.NumberDiagramInfo>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD1.NumberDiagramInfoConverter.CreateOpenXmlElement<DXO19DD11.NumberDiagramInfo>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMDD1.NumberDiagramInfoList? CreateModelElement(DXO19DD11.NumberDiagramInfoList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD1.NumberDiagramInfoList();
      value.NumberDiagramInfos = GetNumberDiagramInfos(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO19DD11.NumberDiagramInfoList? openXmlElement, DMDD1.NumberDiagramInfoList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberDiagramInfos(openXmlElement, value.NumberDiagramInfos, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD1.NumberDiagramInfoList value)
    where OpenXmlElementType: DXO19DD11.NumberDiagramInfoList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO19DD11.NumberDiagramInfoList openXmlElement, DMDD1.NumberDiagramInfoList value)
  {
    SetNumberDiagramInfos(openXmlElement, value?.NumberDiagramInfos);
  }
}
