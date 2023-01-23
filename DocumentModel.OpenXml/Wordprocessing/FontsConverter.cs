namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
public static class FontsConverter
{
  private static Collection<DMW.Font> GetItems(DXW.Fonts openXmlElement)
  {
    var collection = new Collection<DMW.Font>();
    foreach (var item in openXmlElement.Elements<DXW.Font>())
    {
      var newItem = DMXW.FontConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXW.Fonts openXmlElement, Collection<DMW.Font>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetItems(DXW.Fonts openXmlElement, Collection<DMW.Font>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Font>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.FontConverter.CreateOpenXmlElement<DXW.Font>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.Fonts? CreateModelElement(DXW.Fonts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Fonts();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Fonts? openXmlElement, DMW.Fonts? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Fonts? value)
    where OpenXmlElementType: DXW.Fonts, new()
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
