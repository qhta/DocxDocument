using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Combo Box List Item.
/// </summary>
public static class ListItemConverter
{
  /// <summary>
  ///   List Entry Display Text
  /// </summary>
  public static String? GetDisplayText(ListItem? openXmlElement)
  {
    return openXmlElement?.DisplayText?.Value;
  }

  public static void SetDisplayText(ListItem? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DisplayText = new StringValue { Value = value };
      else
        openXmlElement.DisplayText = null;
  }

  /// <summary>
  ///   List Entry Value
  /// </summary>
  public static String? GetValue(ListItem? openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }

  public static void SetValue(ListItem? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Value = new StringValue { Value = value };
      else
        openXmlElement.Value = null;
  }

  public static DocumentModel.Wordprocessing.ListItem? CreateModelElement(ListItem? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ListItem();
      value.DisplayText = GetDisplayText(openXmlElement);
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ListItem? value)
    where OpenXmlElementType : ListItem, new()
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