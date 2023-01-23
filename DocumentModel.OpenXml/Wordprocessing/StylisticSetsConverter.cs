namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the StylisticSets Class.
/// </summary>
public static class StylisticSetsConverter
{
  private static Collection<DMW.StyleSet> GetStyleSets(DXO2010W.StylisticSets openXmlElement)
  {
    var collection = new Collection<DMW.StyleSet>();
    foreach (var item in openXmlElement.Elements<DXO2010W.StyleSet>())
    {
      var newItem = DMXW.StyleSetConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpStyleSets(DXO2010W.StylisticSets openXmlElement, Collection<DMW.StyleSet>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2010W.StyleSet>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.StylisticSets? value)
    where OpenXmlElementType: DXO2010W.StylisticSets, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStyleSets(openXmlElement, value?.StyleSets);
      return openXmlElement;
    }
    return default;
  }
}
