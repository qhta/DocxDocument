namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDropDownList Class.
/// </summary>
public static class SdtContentDropDownListConverter
{
  /// <summary>
  /// Drop-down List Last Saved Value
  /// </summary>
  private static String? GetLastValue(DXW.SdtContentDropDownList openXmlElement)
  {
    return openXmlElement?.LastValue?.Value;
  }
  
  private static bool CmpLastValue(DXW.SdtContentDropDownList openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LastValue?.Value == value;
  }
  
  private static void SetLastValue(DXW.SdtContentDropDownList openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LastValue = new StringValue { Value = value };
    else
      openXmlElement.LastValue = null;
  }
  
  private static Collection<DMW.ListItem> GetListItems(DXW.SdtContentDropDownList openXmlElement)
  {
    var collection = new Collection<DMW.ListItem>();
    foreach (var item in openXmlElement.Elements<DXW.ListItem>())
    {
      var newItem = DMXW.ListItemConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpListItems(DXW.SdtContentDropDownList openXmlElement, Collection<DMW.ListItem>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetListItems(DXW.SdtContentDropDownList openXmlElement, Collection<DMW.ListItem>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.ListItem>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.ListItemConverter.CreateOpenXmlElement<DXW.ListItem>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.SdtContentDropDownList? CreateModelElement(DXW.SdtContentDropDownList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtContentDropDownList();
      value.LastValue = GetLastValue(openXmlElement);
      value.ListItems = GetListItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtContentDropDownList? openXmlElement, DMW.SdtContentDropDownList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLastValue(openXmlElement, value.LastValue, diffs, objName))
        ok = false;
      if (!CmpListItems(openXmlElement, value.ListItems, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentDropDownList? value)
    where OpenXmlElementType: DXW.SdtContentDropDownList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLastValue(openXmlElement, value?.LastValue);
      SetListItems(openXmlElement, value?.ListItems);
      return openXmlElement;
    }
    return default;
  }
}
