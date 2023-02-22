namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the FormatOverrides Class.
/// </summary>
public static class FormatOverridesConverter
{
  private static Collection<DMDrawsChartDraws.FormatOverride>? GetItems(DXO2016DrawChartDraw.FormatOverrides openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.FormatOverride>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.FormatOverride>())
    {
      var newItem = DMXDrawsChartDraws.FormatOverrideConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO2016DrawChartDraw.FormatOverrides openXmlElement, Collection<DMDrawsChartDraws.FormatOverride>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.FormatOverride>();
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
        if (!DMXDrawsChartDraws.FormatOverrideConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
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
  
  public static DocumentModel.Drawings.ChartDrawings.FormatOverrides? CreateModelElement(DXO2016DrawChartDraw.FormatOverrides? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.FormatOverrides();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.FormatOverrides value)
    where OpenXmlElementType: DXO2016DrawChartDraw.FormatOverrides, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.FormatOverrides openXmlElement, DMDrawsChartDraws.FormatOverrides value)
  {
    SetItems(openXmlElement, value?.Items);
    }
  }
