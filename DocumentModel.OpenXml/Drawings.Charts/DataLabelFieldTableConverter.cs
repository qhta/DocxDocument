namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelFieldTable Class.
/// </summary>
public static class DataLabelFieldTableConverter
{
  private static Collection<DMDrawsCharts.DataLabelFieldTableEntry>? GetDataLabelFieldTableEntries(DXO2013DrawChart.DataLabelFieldTable openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DataLabelFieldTableEntry>();
    foreach (var item in openXmlElement.Elements<DXO2013DrawChart.DataLabelFieldTableEntry>())
    {
      var newItem = DMXDrawsCharts.DataLabelFieldTableEntryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataLabelFieldTableEntries(DXO2013DrawChart.DataLabelFieldTable openXmlElement, Collection<DMDrawsCharts.DataLabelFieldTableEntry>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2013DrawChart.DataLabelFieldTableEntry>();
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
        if (!DMXDrawsCharts.DataLabelFieldTableEntryConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataLabelFieldTableEntries(DXO2013DrawChart.DataLabelFieldTable openXmlElement, Collection<DMDrawsCharts.DataLabelFieldTableEntry>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2013DrawChart.DataLabelFieldTableEntry>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.DataLabelFieldTableEntryConverter.CreateOpenXmlElement<DXO2013DrawChart.DataLabelFieldTableEntry>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelFieldTable? CreateModelElement(DXO2013DrawChart.DataLabelFieldTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabelFieldTable();
      value.DataLabelFieldTableEntries = GetDataLabelFieldTableEntries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.DataLabelFieldTable? openXmlElement, DMDrawsCharts.DataLabelFieldTable? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDataLabelFieldTableEntries(openXmlElement, value.DataLabelFieldTableEntries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DataLabelFieldTable value)
    where OpenXmlElementType: DXO2013DrawChart.DataLabelFieldTable, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.DataLabelFieldTable openXmlElement, DMDrawsCharts.DataLabelFieldTable value)
  {
    SetDataLabelFieldTableEntries(openXmlElement, value?.DataLabelFieldTableEntries);
  }
}
