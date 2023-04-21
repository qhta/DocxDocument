namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CustomColorList Class.
/// </summary>
public static class CustomColorListConverter
{
  private static Collection<DMD.CustomColor>? GetCustomColors(DXD.CustomColorList openXmlElement)
  {
    var collection = new Collection<DMD.CustomColor>();
    foreach (var item in openXmlElement.Elements<DXD.CustomColor>())
    {
      var newItem = DMXD.CustomColorConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCustomColors(DXD.CustomColorList openXmlElement, Collection<DMD.CustomColor>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXD.CustomColor>();
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
        if (!DMXD.CustomColorConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCustomColors(DXD.CustomColorList openXmlElement, Collection<DMD.CustomColor>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.CustomColor>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.CustomColorConverter.CreateOpenXmlElement<DXD.CustomColor>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.CustomColorList? CreateModelElement(DXD.CustomColorList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CustomColorList();
      value.CustomColors = GetCustomColors(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.CustomColorList? openXmlElement, DMD.CustomColorList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCustomColors(openXmlElement, value.CustomColors, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.CustomColorList value)
    where OpenXmlElementType: DXD.CustomColorList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.CustomColorList openXmlElement, DMD.CustomColorList value)
  {
    SetCustomColors(openXmlElement, value?.CustomColors);
  }
}
