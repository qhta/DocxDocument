namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelFieldTable Class.
/// </summary>
public static class DataLabelFieldTableConverter
{
  private static Collection<DMDC.DataLabelFieldTableEntry>? GetDataLabelFieldTableEntries(DXO13DC.DataLabelFieldTable openXmlElement)
  {
    var collection = new Collection<DMDC.DataLabelFieldTableEntry>();
    foreach (var item in openXmlElement.Elements<DXO13DC.DataLabelFieldTableEntry>())
    {
      var newItem = DMXDC.DataLabelFieldTableEntryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataLabelFieldTableEntries(DXO13DC.DataLabelFieldTable openXmlElement, Collection<DMDC.DataLabelFieldTableEntry>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO13DC.DataLabelFieldTableEntry>();
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
        if (!DMXDC.DataLabelFieldTableEntryConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataLabelFieldTableEntries(DXO13DC.DataLabelFieldTable openXmlElement, Collection<DMDC.DataLabelFieldTableEntry>? value)
  {
    openXmlElement.RemoveAllChildren<DXO13DC.DataLabelFieldTableEntry>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.DataLabelFieldTableEntryConverter.CreateOpenXmlElement<DXO13DC.DataLabelFieldTableEntry>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelFieldTable? CreateModelElement(DXO13DC.DataLabelFieldTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabelFieldTable();
      value.DataLabelFieldTableEntries = GetDataLabelFieldTableEntries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.DataLabelFieldTable? openXmlElement, DMDC.DataLabelFieldTable? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDataLabelFieldTableEntries(openXmlElement, value.DataLabelFieldTableEntries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DataLabelFieldTable value)
    where OpenXmlElementType: DXO13DC.DataLabelFieldTable, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.DataLabelFieldTable openXmlElement, DMDC.DataLabelFieldTable value)
  {
    SetDataLabelFieldTableEntries(openXmlElement, value?.DataLabelFieldTableEntries);
  }
}
