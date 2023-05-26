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
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DropDownListSelection>()?.Val);
  }
  
  private static bool CmpDropDownListSelection(DXW.DropDownListFormField openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DropDownListSelection>()?.Val, value, diffs, objName, "DropDownListSelection");
  }
  
  private static void SetDropDownListSelection(DXW.DropDownListFormField openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.DropDownListSelection,System.Int32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Default Drop-Down List Item Index.
  /// </summary>
  private static Int32? GetDefaultDropDownListItemIndex(DXW.DropDownListFormField openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DefaultDropDownListItemIndex>()?.Val);
  }
  
  private static bool CmpDefaultDropDownListItemIndex(DXW.DropDownListFormField openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DefaultDropDownListItemIndex>()?.Val, value, diffs, objName, "DefaultDropDownListItemIndex");
  }
  
  private static void SetDefaultDropDownListItemIndex(DXW.DropDownListFormField openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.DefaultDropDownListItemIndex,System.Int32>(openXmlElement, value);
  }
  
  private static Collection<String>? GetListEntryFormFields(DXW.DropDownListFormField openXmlElement)
  {
    var collection = new Collection<String>();
    foreach (var item in openXmlElement.Elements<DXW.ListEntryFormField>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpListEntryFormFields(DXW.DropDownListFormField openXmlElement, Collection<String>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXW.ListEntryFormField>();
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
        if (!StringValueConverter.CmpValue(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
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
          openXmlElement.AppendChild(newItem);
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
  
  public static bool CompareModelElement(DXW.DropDownListFormField? openXmlElement, DMW.DropDownListFormField? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDropDownListSelection(openXmlElement, value.DropDownListSelection, diffs, objName, propName))
        ok = false;
      if (!CmpDefaultDropDownListItemIndex(openXmlElement, value.DefaultDropDownListItemIndex, diffs, objName, propName))
        ok = false;
      if (!CmpListEntryFormFields(openXmlElement, value.ListEntryFormFields, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DropDownListFormField value)
    where OpenXmlElementType: DXW.DropDownListFormField, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DropDownListFormField openXmlElement, DMW.DropDownListFormField value)
  {
    SetDropDownListSelection(openXmlElement, value?.DropDownListSelection);
    SetDefaultDropDownListItemIndex(openXmlElement, value?.DefaultDropDownListItemIndex);
    SetListEntryFormFields(openXmlElement, value?.ListEntryFormFields);
  }
}
