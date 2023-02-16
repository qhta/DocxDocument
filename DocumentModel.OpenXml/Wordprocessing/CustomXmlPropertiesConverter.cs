namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom XML Element Properties.
/// </summary>
public static class CustomXmlPropertiesConverter
{
  /// <summary>
  /// Custom XML Element Placeholder Text.
  /// </summary>
  private static String? GetCustomXmlPlaceholder(DXW.CustomXmlProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.CustomXmlPlaceholder>()?.Val?.Value;
  }
  
  private static bool CmpCustomXmlPlaceholder(DXW.CustomXmlProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlPlaceholder>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "CustomXmlPlaceholder", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetCustomXmlPlaceholder(DXW.CustomXmlProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlPlaceholder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.CustomXmlPlaceholder { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.CustomXmlAttribute>? GetCustomXmlAttributes(DXW.CustomXmlProperties openXmlElement)
  {
    var collection = new Collection<DMW.CustomXmlAttribute>();
    foreach (var item in openXmlElement.Elements<DXW.CustomXmlAttribute>())
    {
      var newItem = DMXW.CustomXmlAttributeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCustomXmlAttributes(DXW.CustomXmlProperties openXmlElement, Collection<DMW.CustomXmlAttribute>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.CustomXmlAttribute>();
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
        if (!DMXW.CustomXmlAttributeConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCustomXmlAttributes(DXW.CustomXmlProperties openXmlElement, Collection<DMW.CustomXmlAttribute>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.CustomXmlAttribute>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.CustomXmlAttributeConverter.CreateOpenXmlElement<DXW.CustomXmlAttribute>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.CustomXmlProperties? CreateModelElement(DXW.CustomXmlProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CustomXmlProperties();
      value.CustomXmlPlaceholder = GetCustomXmlPlaceholder(openXmlElement);
      value.CustomXmlAttributes = GetCustomXmlAttributes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.CustomXmlProperties? openXmlElement, DMW.CustomXmlProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCustomXmlPlaceholder(openXmlElement, value.CustomXmlPlaceholder, diffs, objName))
        ok = false;
      if (!CmpCustomXmlAttributes(openXmlElement, value.CustomXmlAttributes, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CustomXmlProperties? value)
    where OpenXmlElementType: DXW.CustomXmlProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomXmlPlaceholder(openXmlElement, value?.CustomXmlPlaceholder);
      SetCustomXmlAttributes(openXmlElement, value?.CustomXmlAttributes);
      return openXmlElement;
    }
    return default;
  }
}
