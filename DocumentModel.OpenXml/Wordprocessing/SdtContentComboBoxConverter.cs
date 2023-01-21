namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentComboBox Class.
/// </summary>
public static class SdtContentComboBoxConverter
{
  /// <summary>
  /// Combo Box Last Saved Value
  /// </summary>
  private static String? GetLastValue(DXW.SdtContentComboBox openXmlElement)
  {
    return openXmlElement?.LastValue?.Value;
  }
  
  private static void SetLastValue(DXW.SdtContentComboBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LastValue = new StringValue { Value = value };
    else
      openXmlElement.LastValue = null;
  }
  
  private static Collection<DMW.ListItem> GetListItems(DXW.SdtContentComboBox openXmlElement)
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
  
  private static void SetListItems(DXW.SdtContentComboBox openXmlElement, Collection<DMW.ListItem>? value)
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
  
  public static DMW.SdtContentComboBox? CreateModelElement(DXW.SdtContentComboBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtContentComboBox();
      value.LastValue = GetLastValue(openXmlElement);
      value.ListItems = GetListItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentComboBox? value)
    where OpenXmlElementType: DXW.SdtContentComboBox, new()
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
