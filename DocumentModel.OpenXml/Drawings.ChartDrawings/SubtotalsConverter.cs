namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Subtotals Class.
/// </summary>
public static class SubtotalsConverter
{
  private static Collection<UInt32>? GetUnsignedIntegerTypes(DXO16DCD.Subtotals openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.UnsignedIntegerType>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpUnsignedIntegerTypes(DXO16DCD.Subtotals openXmlElement, Collection<UInt32>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.UnsignedIntegerType>();
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
        if (!UInt32ValueConverter.CmpValue(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetUnsignedIntegerTypes(DXO16DCD.Subtotals openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.UnsignedIntegerType>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXO16DCD.UnsignedIntegerType>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMDCDs.Subtotals? CreateModelElement(DXO16DCD.Subtotals? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.Subtotals();
      value.UnsignedIntegerTypes = GetUnsignedIntegerTypes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.Subtotals? openXmlElement, DMDCDs.Subtotals? value, DiffList? diffs, string? objName, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUnsignedIntegerTypes(openXmlElement, value.UnsignedIntegerTypes, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.Subtotals value)
    where OpenXmlElementType: DXO16DCD.Subtotals, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.Subtotals openXmlElement, DMDCDs.Subtotals value)
  {
    SetUnsignedIntegerTypes(openXmlElement, value?.UnsignedIntegerTypes);
  }
}
