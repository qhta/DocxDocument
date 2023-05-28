namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the RadarSerExtensionList Class.
/// </summary>
public static class RadarSerExtensionListConverter
{
  private static Collection<DMDC.RadarSerExtension>? GetRadarSerExtensions(DXDC.RadarSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.RadarSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.RadarSerExtension>())
    {
      var newItem = DMXDC.RadarSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpRadarSerExtensions(DXDC.RadarSerExtensionList openXmlElement, Collection<DMDC.RadarSerExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.RadarSerExtension>();
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
        if (!DMXDC.RadarSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetRadarSerExtensions(DXDC.RadarSerExtensionList openXmlElement, Collection<DMDC.RadarSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.RadarSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.RadarSerExtensionConverter.CreateOpenXmlElement<DXDC.RadarSerExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.Charts.RadarSerExtensionList? CreateModelElement(DXDC.RadarSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.RadarSerExtensionList();
      value.RadarSerExtensions = GetRadarSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.RadarSerExtensionList? openXmlElement, DMDC.RadarSerExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadarSerExtensions(openXmlElement, value.RadarSerExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.RadarSerExtensionList value)
    where OpenXmlElementType: DXDC.RadarSerExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.RadarSerExtensionList openXmlElement, DMDC.RadarSerExtensionList value)
  {
    SetRadarSerExtensions(openXmlElement, value?.RadarSerExtensions);
  }
}
