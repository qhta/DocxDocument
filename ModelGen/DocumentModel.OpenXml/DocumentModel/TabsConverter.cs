namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public static class TabsConverter
{
  private static Collection<DM.Tab>? GetItems(DXO2010CustUI.Tabs openXmlElement)
  {
    var collection = new Collection<DM.Tab>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.Tab>())
    {
      var newItem = DMX.TabConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO2010CustUI.Tabs openXmlElement, Collection<DM.Tab>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2010CustUI.Tab>();
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
        if (!DMX.TabConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO2010CustUI.Tabs openXmlElement, Collection<DM.Tab>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010CustUI.Tab>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.TabConverter.CreateOpenXmlElement<DXO2010CustUI.Tab>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Tabs? CreateModelElement(DXO2010CustUI.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Tabs();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.Tabs? openXmlElement, DM.Tabs? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Tabs value)
    where OpenXmlElementType: DXO2010CustUI.Tabs, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.Tabs openXmlElement, DM.Tabs value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
