namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Custom Dash.
/// </summary>
public static class CustomDashConverter
{
  private static Collection<DMDraws.DashStop>? GetDashStops(DXDraw.CustomDash openXmlElement)
  {
    var collection = new Collection<DMDraws.DashStop>();
    foreach (var item in openXmlElement.Elements<DXDraw.DashStop>())
    {
      var newItem = DMXDraws.DashStopConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDashStops(DXDraw.CustomDash openXmlElement, Collection<DMDraws.DashStop>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDraw.DashStop>();
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
        if (!DMXDraws.DashStopConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDashStops(DXDraw.CustomDash openXmlElement, Collection<DMDraws.DashStop>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.DashStop>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.DashStopConverter.CreateOpenXmlElement<DXDraw.DashStop>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.CustomDash? CreateModelElement(DXDraw.CustomDash? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CustomDash();
      value.DashStops = GetDashStops(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.CustomDash? openXmlElement, DMDraws.CustomDash? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDashStops(openXmlElement, value.DashStops, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CustomDash value)
    where OpenXmlElementType: DXDraw.CustomDash, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.CustomDash openXmlElement, DMDraws.CustomDash value)
  {
    SetDashStops(openXmlElement, value?.DashStops);
    }
  }
