namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the StylisticSets Class converter from/to OpenXml.
///</summary>
public static class StylisticSetsConverter
{
  private static Collection<DMW.StyleSet>? GetStyleSets(DXO2010W.StylisticSets openXmlElement)
  {
    var collection = new Collection<DMW.StyleSet>();
    foreach (var item in openXmlElement.Elements<DXO2010W.StyleSet>())
    {
      var newItem = DMXW.StyleSetConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStyleSets(DXO2010W.StylisticSets openXmlElement, Collection<DMW.StyleSet>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2010W.StyleSet>();
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
        if (!DMXW.StyleSetConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStyleSets(DXO2010W.StylisticSets openXmlElement, Collection<DMW.StyleSet>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010W.StyleSet>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.StyleSetConverter.CreateOpenXmlElement<DXO2010W.StyleSet>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.StylisticSets? CreateModelElement(DXO2010W.StylisticSets? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.StylisticSets();
      value.StyleSets = GetStyleSets(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.StylisticSets? openXmlElement, DMW.StylisticSets? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStyleSets(openXmlElement, value.StyleSets, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.StylisticSets value)
    where OpenXmlElementType: DXO2010W.StylisticSets, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010W.StylisticSets openXmlElement, DMW.StylisticSets value)
  {
    SetStyleSets(openXmlElement, value?.StyleSets);
  }
}
