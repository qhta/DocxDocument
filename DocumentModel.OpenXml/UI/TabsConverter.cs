namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public static class TabsConverter
{
  private static Collection<DMUI.Tab>? GetItems(DXOCustUI.Tabs openXmlElement)
  {
    var collection = new Collection<DMUI.Tab>();
    foreach (var item in openXmlElement.Elements<DXOCustUI.Tab>())
    {
      var newItem = DMXUI.TabConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXOCustUI.Tabs openXmlElement, Collection<DMUI.Tab>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOCustUI.Tab>();
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
        if (!DMXUI.TabConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXOCustUI.Tabs openXmlElement, Collection<DMUI.Tab>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCustUI.Tab>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.TabConverter.CreateOpenXmlElement<DXOCustUI.Tab>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.UI.Tabs? CreateModelElement(DXOCustUI.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.Tabs();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.Tabs? openXmlElement, DMUI.Tabs? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.Tabs value)
    where OpenXmlElementType: DXOCustUI.Tabs, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.Tabs openXmlElement, DMUI.Tabs value)
  {
    SetItems(openXmlElement, value?.Items);
    }
  }
