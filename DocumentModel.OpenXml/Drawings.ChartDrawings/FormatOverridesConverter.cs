namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the FormatOverrides Class.
/// </summary>
public static class FormatOverridesConverter
{
  private static Collection<DMDrawsChartDraws.FormatOverride> GetItems(DXO2016DrawChartDraw.FormatOverrides openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.FormatOverride>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.FormatOverride>())
    {
      var newItem = DMXDrawsChartDraws.FormatOverrideConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXO2016DrawChartDraw.FormatOverrides openXmlElement, Collection<DMDrawsChartDraws.FormatOverride>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.FormatOverride>();
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
        if (!DMXDrawsChartDraws.FormatOverrideConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO2016DrawChartDraw.FormatOverrides openXmlElement, Collection<DMDrawsChartDraws.FormatOverride>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.FormatOverride>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.FormatOverrideConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.FormatOverride>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.FormatOverrides? CreateModelElement(DXO2016DrawChartDraw.FormatOverrides? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.FormatOverrides();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.FormatOverrides? openXmlElement, DMDrawsChartDraws.FormatOverrides? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.FormatOverrides? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.FormatOverrides, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
