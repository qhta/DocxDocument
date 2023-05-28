namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  private static Collection<DMDCDs.Extension2>? GetExtension2s(DXO16DCD.ExtensionList openXmlElement)
  {
    var collection = new Collection<DMDCDs.Extension2>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.Extension2>())
    {
      var newItem = DMXDCDs.Extension2Converter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpExtension2s(DXO16DCD.ExtensionList openXmlElement, Collection<DMDCDs.Extension2>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.Extension2>();
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
        if (!DMXDCDs.Extension2Converter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetExtension2s(DXO16DCD.ExtensionList openXmlElement, Collection<DMDCDs.Extension2>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.Extension2>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.Extension2Converter.CreateOpenXmlElement<DXO16DCD.Extension2>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMDCDs.ExtensionList? CreateModelElement(DXO16DCD.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.ExtensionList();
      value.Extension2s = GetExtension2s(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.ExtensionList? openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension2s(openXmlElement, value.Extension2s, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ExtensionList value)
    where OpenXmlElementType: DXO16DCD.ExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ExtensionList openXmlElement, DMDCDs.ExtensionList value)
  {
    SetExtension2s(openXmlElement, value?.Extension2s);
  }
}
