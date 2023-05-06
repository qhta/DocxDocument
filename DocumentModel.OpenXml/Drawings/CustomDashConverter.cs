namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Custom Dash.
/// </summary>
public static class CustomDashConverter
{
  private static Collection<DMD.DashStop>? GetDashStops(DXD.CustomDash openXmlElement)
  {
    var collection = new Collection<DMD.DashStop>();
    foreach (var item in openXmlElement.Elements<DXD.DashStop>())
    {
      var newItem = DMXD.DashStopConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDashStops(DXD.CustomDash openXmlElement, Collection<DMD.DashStop>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXD.DashStop>();
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
        if (!DMXD.DashStopConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDashStops(DXD.CustomDash openXmlElement, Collection<DMD.DashStop>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.DashStop>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.DashStopConverter.CreateOpenXmlElement<DXD.DashStop>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.CustomDash? CreateModelElement(DXD.CustomDash? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CustomDash();
      value.DashStops = GetDashStops(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.CustomDash? openXmlElement, DMD.CustomDash? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.CustomDash value)
    where OpenXmlElementType: DXD.CustomDash, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.CustomDash openXmlElement, DMD.CustomDash value)
  {
    SetDashStops(openXmlElement, value?.DashStops);
  }
}
