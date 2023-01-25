namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Custom Split.
/// </summary>
public static class CustomSplitConverter
{
  private static Collection<UInt32> GetSecondPiePoints(DXDrawCharts.CustomSplit openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SecondPiePoint>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    return collection;
  }
  
  private static bool CmpSecondPiePoints(DXDrawCharts.CustomSplit openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.SecondPiePoint>();
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
        if (!UInt32ValueConverter.CmpValue(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSecondPiePoints(DXDrawCharts.CustomSplit openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.SecondPiePoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXDrawCharts.SecondPiePoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.CustomSplit? CreateModelElement(DXDrawCharts.CustomSplit? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.CustomSplit();
      value.SecondPiePoints = GetSecondPiePoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.CustomSplit? openXmlElement, DMDrawsCharts.CustomSplit? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSecondPiePoints(openXmlElement, value.SecondPiePoints, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.CustomSplit? value)
    where OpenXmlElementType: DXDrawCharts.CustomSplit, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSecondPiePoints(openXmlElement, value?.SecondPiePoints);
      return openXmlElement;
    }
    return default;
  }
}
