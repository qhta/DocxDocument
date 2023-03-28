namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ExtraColorSchemeList Class converter from/to OpenXml.
///</summary>
public static class ExtraColorSchemeListConverter
{
  private static Collection<DMDraws.ExtraColorScheme>? GetExtraColorSchemes(DXDraw.ExtraColorSchemeList openXmlElement)
  {
    var collection = new Collection<DMDraws.ExtraColorScheme>();
    foreach (var item in openXmlElement.Elements<DXDraw.ExtraColorScheme>())
    {
      var newItem = DMXDraws.ExtraColorSchemeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpExtraColorSchemes(DXDraw.ExtraColorSchemeList openXmlElement, Collection<DMDraws.ExtraColorScheme>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDraw.ExtraColorScheme>();
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
        if (!DMXDraws.ExtraColorSchemeConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetExtraColorSchemes(DXDraw.ExtraColorSchemeList openXmlElement, Collection<DMDraws.ExtraColorScheme>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.ExtraColorScheme>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ExtraColorSchemeConverter.CreateOpenXmlElement<DXDraw.ExtraColorScheme>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ExtraColorSchemeList? CreateModelElement(DXDraw.ExtraColorSchemeList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ExtraColorSchemeList();
      value.ExtraColorSchemes = GetExtraColorSchemes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ExtraColorSchemeList? openXmlElement, DMDraws.ExtraColorSchemeList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ExtraColorSchemeList value)
    where OpenXmlElementType: DXDraw.ExtraColorSchemeList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ExtraColorSchemeList openXmlElement, DMDraws.ExtraColorSchemeList value)
  {
    SetExtraColorSchemes(openXmlElement, value?.ExtraColorSchemes);
  }
}
