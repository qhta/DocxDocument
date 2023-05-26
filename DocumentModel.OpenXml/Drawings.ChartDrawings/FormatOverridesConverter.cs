namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the FormatOverrides Class.
/// </summary>
public static class FormatOverridesConverter
{
  private static Collection<DMDCDs.FormatOverride>? GetItems(DXO16DCD.FormatOverrides openXmlElement)
  {
    var collection = new Collection<DMDCDs.FormatOverride>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.FormatOverride>())
    {
      var newItem = DMXDCDs.FormatOverrideConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO16DCD.FormatOverrides openXmlElement, Collection<DMDCDs.FormatOverride>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.FormatOverride>();
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
        if (!DMXDCDs.FormatOverrideConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO16DCD.FormatOverrides openXmlElement, Collection<DMDCDs.FormatOverride>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.FormatOverride>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.FormatOverrideConverter.CreateOpenXmlElement<DXO16DCD.FormatOverride>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.FormatOverrides? CreateModelElement(DXO16DCD.FormatOverrides? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.FormatOverrides();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.FormatOverrides? openXmlElement, DMDCDs.FormatOverrides? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.FormatOverrides value)
    where OpenXmlElementType: DXO16DCD.FormatOverrides, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.FormatOverrides openXmlElement, DMDCDs.FormatOverrides value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
