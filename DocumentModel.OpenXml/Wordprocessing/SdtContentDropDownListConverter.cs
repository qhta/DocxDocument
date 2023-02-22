namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDropDownList Class.
/// </summary>
public static class SdtContentDropDownListConverter
{
  /// <summary>
  /// Drop-down List Last Saved Value
  /// </summary>
  private static String? GetLastValue(DXW.SdtContentDropDownList openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LastValue);
  }
  
  private static bool CmpLastValue(DXW.SdtContentDropDownList openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LastValue, value, diffs, objName, "LastValue");
  }
  
  private static void SetLastValue(DXW.SdtContentDropDownList openXmlElement, String? value)
  {
    openXmlElement.LastValue = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMW.ListItem>? GetListItems(DXW.SdtContentDropDownList openXmlElement)
  {
    var collection = new Collection<DMW.ListItem>();
    foreach (var item in openXmlElement.Elements<DXW.ListItem>())
    {
      var newItem = DMXW.ListItemConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpListItems(DXW.SdtContentDropDownList openXmlElement, Collection<DMW.ListItem>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.ListItem>();
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
        if (!DMXW.ListItemConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetListItems(DXW.SdtContentDropDownList openXmlElement, Collection<DMW.ListItem>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.ListItem>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.ListItemConverter.CreateOpenXmlElement<DXW.ListItem>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtContentDropDownList? CreateModelElement(DXW.SdtContentDropDownList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentDropDownList();
      value.LastValue = GetLastValue(openXmlElement);
      value.ListItems = GetListItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtContentDropDownList? openXmlElement, DMW.SdtContentDropDownList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLastValue(openXmlElement, value.LastValue, diffs, objName))
        ok = false;
      if (!CmpListItems(openXmlElement, value.ListItems, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentDropDownList value)
    where OpenXmlElementType: DXW.SdtContentDropDownList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SdtContentDropDownList openXmlElement, DMW.SdtContentDropDownList value)
  {
    SetLastValue(openXmlElement, value?.LastValue);
    SetListItems(openXmlElement, value?.ListItems);
  }
}
