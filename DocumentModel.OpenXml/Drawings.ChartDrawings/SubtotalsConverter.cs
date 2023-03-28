namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Subtotals Class converter from/to OpenXml.
///</summary>
public static class SubtotalsConverter
{
  private static Collection<UInt32>? GetUnsignedIntegerTypes(DXO2016DrawChartDraw.Subtotals openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.UnsignedIntegerType>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpUnsignedIntegerTypes(DXO2016DrawChartDraw.Subtotals openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.UnsignedIntegerType>();
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
        if (!UInt32ValueConverter.CmpValue(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetUnsignedIntegerTypes(DXO2016DrawChartDraw.Subtotals openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.UnsignedIntegerType>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.UnsignedIntegerType>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Subtotals? CreateModelElement(DXO2016DrawChartDraw.Subtotals? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Subtotals();
      value.UnsignedIntegerTypes = GetUnsignedIntegerTypes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Subtotals? openXmlElement, DMDrawsChartDraws.Subtotals? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUnsignedIntegerTypes(openXmlElement, value.UnsignedIntegerTypes, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Subtotals value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Subtotals, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.Subtotals openXmlElement, DMDrawsChartDraws.Subtotals value)
  {
    SetUnsignedIntegerTypes(openXmlElement, value?.UnsignedIntegerTypes);
  }
}
