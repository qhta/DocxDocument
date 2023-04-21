namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Grouping History.
/// </summary>
public static class RegroupTableConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMV.ExtensionHandlingBehaviorKind? GetExtension(DXVO.RegroupTable openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVO.RegroupTable openXmlElement, DMV.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName);
  }
  
  private static void SetExtension(DXVO.RegroupTable openXmlElement, DMV.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(value);
  }
  
  private static Collection<DMV.Entry>? GetEntries(DXVO.RegroupTable openXmlElement)
  {
    var collection = new Collection<DMV.Entry>();
    foreach (var item in openXmlElement.Elements<DXVO.Entry>())
    {
      var newItem = DMXV.EntryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpEntries(DXVO.RegroupTable openXmlElement, Collection<DMV.Entry>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXVO.Entry>();
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
        if (!DMXV.EntryConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetEntries(DXVO.RegroupTable openXmlElement, Collection<DMV.Entry>? value)
  {
    openXmlElement.RemoveAllChildren<DXVO.Entry>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXV.EntryConverter.CreateOpenXmlElement<DXVO.Entry>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Vml.RegroupTable? CreateModelElement(DXVO.RegroupTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.RegroupTable();
      value.Extension = GetExtension(openXmlElement);
      value.Entries = GetEntries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVO.RegroupTable? openXmlElement, DMV.RegroupTable? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpEntries(openXmlElement, value.Entries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.RegroupTable value)
    where OpenXmlElementType: DXVO.RegroupTable, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.RegroupTable openXmlElement, DMV.RegroupTable value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetEntries(openXmlElement, value?.Entries);
  }
}
