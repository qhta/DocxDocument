namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Combo Box List Item.
/// </summary>
public static class ListItemConverter
{
  /// <summary>
  /// List Entry Display Text
  /// </summary>
  private static String? GetDisplayText(DXW.ListItem openXmlElement)
  {
    return openXmlElement?.DisplayText?.Value;
  }
  
  private static void SetDisplayText(DXW.ListItem openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DisplayText = new StringValue { Value = value };
    else
      openXmlElement.DisplayText = null;
  }
  
  /// <summary>
  /// List Entry Value
  /// </summary>
  private static String? GetValue(DXW.ListItem openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }
  
  private static void SetValue(DXW.ListItem openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Value = new StringValue { Value = value };
    else
      openXmlElement.Value = null;
  }
  
  public static DMW.ListItem? CreateModelElement(DXW.ListItem? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ListItem();
      value.DisplayText = GetDisplayText(openXmlElement);
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ListItem? value)
    where OpenXmlElementType: DXW.ListItem, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDisplayText(openXmlElement, value?.DisplayText);
      SetValue(openXmlElement, value?.Value);
      return openXmlElement;
    }
    return default;
  }
}
