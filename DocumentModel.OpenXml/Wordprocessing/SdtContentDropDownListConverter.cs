using DocumentFormat.OpenXml.Wordprocessing;
using ListItem = DocumentModel.Wordprocessing.ListItem;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SdtContentDropDownList Class.
/// </summary>
public static class SdtContentDropDownListConverter
{
  /// <summary>
  ///   Drop-down List Last Saved Value
  /// </summary>
  public static String? GetLastValue(SdtContentDropDownList? openXmlElement)
  {
    return openXmlElement?.LastValue?.Value;
  }

  public static void SetLastValue(SdtContentDropDownList? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LastValue = new StringValue { Value = value };
      else
        openXmlElement.LastValue = null;
  }

  public static Collection<ListItem>? GetListItems(SdtContentDropDownList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ListItem>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.ListItem>())
      {
        var newItem = ListItemConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetListItems(SdtContentDropDownList? openXmlElement, Collection<ListItem>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.ListItem>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ListItemConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ListItem>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.SdtContentDropDownList? CreateModelElement(SdtContentDropDownList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentDropDownList();
      value.LastValue = GetLastValue(openXmlElement);
      value.ListItems = GetListItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtContentDropDownList? value)
    where OpenXmlElementType : SdtContentDropDownList, new()
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