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
      return openXmlElement.GetFirstChild<DXW.CustomXmlPlaceholder>()?.Val?.Value == value;
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
  
  private static Collection<DMW.CustomXmlAttribute> GetCustomXmlAttributes(DXW.CustomXmlProperties openXmlElement)
  {
    var collection = new Collection<DMW.CustomXmlAttribute>();
    foreach (var item in openXmlElement.Elements<DXW.CustomXmlAttribute>())
    {
      var newItem = DMXW.CustomXmlAttributeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpCustomXmlAttributes(DXW.CustomXmlProperties openXmlElement, Collection<DMW.CustomXmlAttribute>? value, DiffList? diffs, string? objName)
  {
    return true;
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
  
  public static DMW.CustomXmlProperties? CreateModelElement(DXW.CustomXmlProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CustomXmlProperties();
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
    return openXmlElement == null && value == null;
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
