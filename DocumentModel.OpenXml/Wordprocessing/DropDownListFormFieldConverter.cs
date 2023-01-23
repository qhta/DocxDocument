namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Drop-Down List Form Field Properties.
/// </summary>
public static class DropDownListFormFieldConverter
{
  /// <summary>
  /// Drop-Down List Selection.
  /// </summary>
  private static Int32? GetDropDownListSelection(DXW.DropDownListFormField openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.DropDownListSelection>()?.Val?.Value;
  }
  
  private static bool CmpDropDownListSelection(DXW.DropDownListFormField openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXW.DropDownListSelection>()?.Val?.Value == value;
  }
  
  private static void SetDropDownListSelection(DXW.DropDownListFormField openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DropDownListSelection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DropDownListSelection{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Default Drop-Down List Item Index.
  /// </summary>
  private static Int32? GetDefaultDropDownListItemIndex(DXW.DropDownListFormField openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.DefaultDropDownListItemIndex>()?.Val?.Value;
  }
  
  private static bool CmpDefaultDropDownListItemIndex(DXW.DropDownListFormField openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXW.DefaultDropDownListItemIndex>()?.Val?.Value == value;
  }
  
  private static void SetDefaultDropDownListItemIndex(DXW.DropDownListFormField openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DefaultDropDownListItemIndex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DefaultDropDownListItemIndex{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<String> GetListEntryFormFields(DXW.DropDownListFormField openXmlElement)
  {
    var collection = new Collection<String>();
    foreach (var item in openXmlElement.Elements<DXW.ListEntryFormField>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((string)newItem);
    }
    return collection;
  }
  
  private static bool CmpListEntryFormFields(DXW.DropDownListFormField openXmlElement, Collection<String>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.ListEntryFormField>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!StringValueConverter.CmpValue(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetListEntryFormFields(DXW.DropDownListFormField openXmlElement, Collection<String>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.ListEntryFormField>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = StringValueConverter.CreateOpenXmlElement<DXW.ListEntryFormField>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.DropDownListFormField? CreateModelElement(DXW.DropDownListFormField? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DropDownListFormField();
      value.DropDownListSelection = GetDropDownListSelection(openXmlElement);
      value.DefaultDropDownListItemIndex = GetDefaultDropDownListItemIndex(openXmlElement);
      value.ListEntryFormFields = GetListEntryFormFields(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DropDownListFormField? openXmlElement, DMW.DropDownListFormField? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDropDownListSelection(openXmlElement, value.DropDownListSelection, diffs, objName))
        ok = false;
      if (!CmpDefaultDropDownListItemIndex(openXmlElement, value.DefaultDropDownListItemIndex, diffs, objName))
        ok = false;
      if (!CmpListEntryFormFields(openXmlElement, value.ListEntryFormFields, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DropDownListFormField? value)
    where OpenXmlElementType: DXW.DropDownListFormField, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDropDownListSelection(openXmlElement, value?.DropDownListSelection);
      SetDefaultDropDownListItemIndex(openXmlElement, value?.DefaultDropDownListItemIndex);
      SetListEntryFormFields(openXmlElement, value?.ListEntryFormFields);
      return openXmlElement;
    }
    return default;
  }
}
