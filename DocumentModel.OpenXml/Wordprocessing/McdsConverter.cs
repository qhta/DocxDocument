namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Mcds Class.
/// </summary>
public static class McdsConverter
{
  private static Collection<DMW.Mcd> GetItems(DXOW.Mcds openXmlElement)
  {
    var collection = new Collection<DMW.Mcd>();
    foreach (var item in openXmlElement.Elements<DXOW.Mcd>())
    {
      var newItem = DMXW.McdConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXOW.Mcds openXmlElement, Collection<DMW.Mcd>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXOW.Mcd>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
        if (!DMXW.McdConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXOW.Mcds openXmlElement, Collection<DMW.Mcd>? value)
  {
    openXmlElement.RemoveAllChildren<DXOW.Mcd>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.McdConverter.CreateOpenXmlElement<DXOW.Mcd>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.Mcds? CreateModelElement(DXOW.Mcds? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Mcds();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.Mcds? openXmlElement, DMW.Mcds? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Mcds? value)
    where OpenXmlElementType: DXOW.Mcds, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
