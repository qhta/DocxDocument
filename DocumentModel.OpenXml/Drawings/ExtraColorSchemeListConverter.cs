namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ExtraColorSchemeList Class.
/// </summary>
public static class ExtraColorSchemeListConverter
{
  private static Collection<DMD.ExtraColorScheme>? GetExtraColorSchemes(DXD.ExtraColorSchemeList openXmlElement)
  {
    var collection = new Collection<DMD.ExtraColorScheme>();
    foreach (var item in openXmlElement.Elements<DXD.ExtraColorScheme>())
    {
      var newItem = DMXD.ExtraColorSchemeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpExtraColorSchemes(DXD.ExtraColorSchemeList openXmlElement, Collection<DMD.ExtraColorScheme>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXD.ExtraColorScheme>();
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
        if (!DMXD.ExtraColorSchemeConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetExtraColorSchemes(DXD.ExtraColorSchemeList openXmlElement, Collection<DMD.ExtraColorScheme>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.ExtraColorScheme>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.ExtraColorSchemeConverter.CreateOpenXmlElement<DXD.ExtraColorScheme>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ExtraColorSchemeList? CreateModelElement(DXD.ExtraColorSchemeList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ExtraColorSchemeList();
      value.ExtraColorSchemes = GetExtraColorSchemes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ExtraColorSchemeList? openXmlElement, DMD.ExtraColorSchemeList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtraColorSchemes(openXmlElement, value.ExtraColorSchemes, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ExtraColorSchemeList value)
    where OpenXmlElementType: DXD.ExtraColorSchemeList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ExtraColorSchemeList openXmlElement, DMD.ExtraColorSchemeList value)
  {
    SetExtraColorSchemes(openXmlElement, value?.ExtraColorSchemes);
  }
}
