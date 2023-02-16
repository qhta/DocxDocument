namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentComboBox Class.
/// </summary>
public static class SdtContentComboBoxConverter
{
  /// <summary>
  /// Combo Box Last Saved Value
  /// </summary>
  private static String? GetLastValue(DXW.SdtContentComboBox openXmlElement)
  {
    return openXmlElement?.LastValue?.Value;
  }
  
  private static bool CmpLastValue(DXW.SdtContentComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LastValue?.Value == value) return true;
    diffs?.Add(objName, "LastValue", openXmlElement?.LastValue?.Value, value);
    return false;
  }
  
  private static void SetLastValue(DXW.SdtContentComboBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LastValue = new StringValue { Value = value };
    else
      openXmlElement.LastValue = null;
  }
  
  private static Collection<DMW.ListItem>? GetListItems(DXW.SdtContentComboBox openXmlElement)
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
  
  private static bool CmpListItems(DXW.SdtContentComboBox openXmlElement, Collection<DMW.ListItem>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.ListItem>();
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
        if (!DMXW.ListItemConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetListItems(DXW.SdtContentComboBox openXmlElement, Collection<DMW.ListItem>? value)
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
  
  public static DocumentModel.Wordprocessing.SdtContentComboBox? CreateModelElement(DXW.SdtContentComboBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentComboBox();
      value.LastValue = GetLastValue(openXmlElement);
      value.ListItems = GetListItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtContentComboBox? openXmlElement, DMW.SdtContentComboBox? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentComboBox? value)
    where OpenXmlElementType: DXW.SdtContentComboBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLastValue(openXmlElement, value?.LastValue);
      SetListItems(openXmlElement, value?.ListItems);
      return openXmlElement;
    }
    return default;
  }
}
