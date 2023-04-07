namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Grid.
/// </summary>
public static class TableGridConverter
{
  private static Collection<DMW.GridColumn>? GetGridColumns(DXW.TableGrid openXmlElement)
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
  
  private static bool CmpGridColumns(DXW.TableGrid openXmlElement, Collection<DMW.GridColumn>? value, DiffList? diffs, string? objName)
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
  
  private static void SetGridColumns(DXW.TableGrid openXmlElement, Collection<DMW.GridColumn>? value)
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
  
  private static DMW.TableGridChange? GetTableGridChange(DXW.TableGrid openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableGridChange>();
    if (element != null)
      return DMXW.TableGridChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableGridChange(DXW.TableGrid openXmlElement, DMW.TableGridChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableGridChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableGridChange>(), value, diffs, objName);
  }
  
  private static void SetTableGridChange(DXW.TableGrid openXmlElement, DMW.TableGridChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableGridChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableGridChangeConverter.CreateOpenXmlElement<DXW.TableGridChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableGrid? CreateModelElement(DXW.TableGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableGrid();
      value.GridColumns = GetGridColumns(openXmlElement);
      value.TableGridChange = GetTableGridChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableGrid? openXmlElement, DMW.TableGrid? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGridColumns(openXmlElement, value.GridColumns, diffs, objName))
        ok = false;
      if (!CmpTableGridChange(openXmlElement, value.TableGridChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableGrid value)
    where OpenXmlElementType: DXW.TableGrid, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableGrid openXmlElement, DMW.TableGrid value)
  {
    SetGridColumns(openXmlElement, value?.GridColumns);
    SetTableGridChange(openXmlElement, value?.TableGridChange);
  }
}
