namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the GradientStopList Class converter from/to OpenXml.
///</summary>
public static class GradientStopListConverter
{
  private static Collection<DMW.GradientStop>? GetGradientStops(DXO2010W.GradientStopList openXmlElement)
  {
    var collection = new Collection<DMW.GradientStop>();
    foreach (var item in openXmlElement.Elements<DXO2010W.GradientStop>())
    {
      var newItem = DMXW.GradientStopConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpGradientStops(DXO2010W.GradientStopList openXmlElement, Collection<DMW.GradientStop>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2010W.GradientStop>();
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
        if (!DMXW.GradientStopConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetGradientStops(DXO2010W.GradientStopList openXmlElement, Collection<DMW.GradientStop>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010W.GradientStop>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.GradientStopConverter.CreateOpenXmlElement<DXO2010W.GradientStop>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.GradientStopList? CreateModelElement(DXO2010W.GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.GradientStopList();
      value.GradientStops = GetGradientStops(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.GradientStopList? openXmlElement, DMW.GradientStopList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGradientStops(openXmlElement, value.GradientStops, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.GradientStopList value)
    where OpenXmlElementType: DXO2010W.GradientStopList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010W.GradientStopList openXmlElement, DMW.GradientStopList value)
  {
    SetGradientStops(openXmlElement, value?.GradientStops);
  }
}
