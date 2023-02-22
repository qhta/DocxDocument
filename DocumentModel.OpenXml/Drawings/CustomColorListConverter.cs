namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CustomColorList Class.
/// </summary>
public static class CustomColorListConverter
{
  private static Collection<DMDraws.CustomColor>? GetCustomColors(DXDraw.CustomColorList openXmlElement)
  {
    var collection = new Collection<DMDraws.CustomColor>();
    foreach (var item in openXmlElement.Elements<DXDraw.CustomColor>())
    {
      var newItem = DMXDraws.CustomColorConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCustomColors(DXDraw.CustomColorList openXmlElement, Collection<DMDraws.CustomColor>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDraw.CustomColor>();
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
        if (!DMXDraws.CustomColorConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCustomColors(DXDraw.CustomColorList openXmlElement, Collection<DMDraws.CustomColor>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.CustomColor>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.CustomColorConverter.CreateOpenXmlElement<DXDraw.CustomColor>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.CustomColorList? CreateModelElement(DXDraw.CustomColorList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CustomColorList();
      value.CustomColors = GetCustomColors(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.CustomColorList? openXmlElement, DMDraws.CustomColorList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CustomColorList value)
    where OpenXmlElementType: DXDraw.CustomColorList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.CustomColorList openXmlElement, DMDraws.CustomColorList value)
  {
    SetCustomColors(openXmlElement, value?.CustomColors);
    }
  }
