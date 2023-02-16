namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the NumberDiagramInfoList Class.
/// </summary>
public static class NumberDiagramInfoListConverter
{
  private static Collection<DMDrawsDgm1.NumberDiagramInfo>? GetNumberDiagramInfos(DXO2019DrawDgm11.NumberDiagramInfoList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgm1.NumberDiagramInfo>();
    foreach (var item in openXmlElement.Elements<DXO2019DrawDgm11.NumberDiagramInfo>())
    {
      var newItem = DMXDrawsDgm1.NumberDiagramInfoConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNumberDiagramInfos(DXO2019DrawDgm11.NumberDiagramInfoList openXmlElement, Collection<DMDrawsDgm1.NumberDiagramInfo>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2019DrawDgm11.NumberDiagramInfo>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
        if (!DMXDrawsDgm1.NumberDiagramInfoConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNumberDiagramInfos(DXO2019DrawDgm11.NumberDiagramInfoList openXmlElement, Collection<DMDrawsDgm1.NumberDiagramInfo>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2019DrawDgm11.NumberDiagramInfo>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgm1.NumberDiagramInfoConverter.CreateOpenXmlElement<DXO2019DrawDgm11.NumberDiagramInfo>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagram1.NumberDiagramInfoList? CreateModelElement(DXO2019DrawDgm11.NumberDiagramInfoList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagram1.NumberDiagramInfoList();
      value.NumberDiagramInfos = GetNumberDiagramInfos(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2019DrawDgm11.NumberDiagramInfoList? openXmlElement, DMDrawsDgm1.NumberDiagramInfoList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberDiagramInfos(openXmlElement, value.NumberDiagramInfos, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgm1.NumberDiagramInfoList? value)
    where OpenXmlElementType: DXO2019DrawDgm11.NumberDiagramInfoList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberDiagramInfos(openXmlElement, value?.NumberDiagramInfos);
      return openXmlElement;
    }
    return default;
  }
}
