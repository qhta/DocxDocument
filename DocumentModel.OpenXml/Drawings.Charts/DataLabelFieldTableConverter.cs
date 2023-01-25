namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelFieldTable Class.
/// </summary>
public static class DataLabelFieldTableConverter
{
  private static Collection<DMDrawsCharts.DataLabelFieldTableEntry> GetDataLabelFieldTableEntries(DXO2013DrawChart.DataLabelFieldTable openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DataLabelFieldTableEntry>();
    foreach (var item in openXmlElement.Elements<DXO2013DrawChart.DataLabelFieldTableEntry>())
    {
      var newItem = DMXDrawsCharts.DataLabelFieldTableEntryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpDataLabelFieldTableEntries(DXO2013DrawChart.DataLabelFieldTable openXmlElement, Collection<DMDrawsCharts.DataLabelFieldTableEntry>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2013DrawChart.DataLabelFieldTableEntry>();
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
        if (!DMXDrawsCharts.DataLabelFieldTableEntryConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
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
  
  public static DMDrawsCharts.DataLabelFieldTable? CreateModelElement(DXO2013DrawChart.DataLabelFieldTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DataLabelFieldTable();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DataLabelFieldTable? value)
    where OpenXmlElementType: DXO2013DrawChart.DataLabelFieldTable, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDataLabelFieldTableEntries(openXmlElement, value?.DataLabelFieldTableEntries);
      return openXmlElement;
    }
    return default;
  }
}
