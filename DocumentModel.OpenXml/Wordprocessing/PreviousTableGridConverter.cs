namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Table Grid converter from/to OpenXml.
///</summary>
public static class PreviousTableGridConverter
{
  private static Collection<DMW.GridColumn>? GetGridColumns(DXW.PreviousTableGrid openXmlElement)
  {
    var collection = new Collection<DMW.GridColumn>();
    foreach (var item in openXmlElement.Elements<DXW.GridColumn>())
    {
      var newItem = DMXW.GridColumnConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpGridColumns(DXW.PreviousTableGrid openXmlElement, Collection<DMW.GridColumn>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.GridColumn>();
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
        if (!DMXW.GridColumnConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetGridColumns(DXW.PreviousTableGrid openXmlElement, Collection<DMW.GridColumn>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.GridColumn>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.GridColumnConverter.CreateOpenXmlElement<DXW.GridColumn>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.PreviousTableGrid? CreateModelElement(DXW.PreviousTableGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousTableGrid();
      value.GridColumns = GetGridColumns(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousTableGrid? openXmlElement, DMW.PreviousTableGrid? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGridColumns(openXmlElement, value.GridColumns, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableGrid value)
    where OpenXmlElementType: DXW.PreviousTableGrid, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousTableGrid openXmlElement, DMW.PreviousTableGrid value)
  {
    SetGridColumns(openXmlElement, value?.GridColumns);
  }
}
