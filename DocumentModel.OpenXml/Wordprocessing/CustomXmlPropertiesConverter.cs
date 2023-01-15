using DocumentFormat.OpenXml.Wordprocessing;
using CustomXmlAttribute = DocumentModel.Wordprocessing.CustomXmlAttribute;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Custom XML Element Properties.
/// </summary>
public static class CustomXmlPropertiesConverter
{
  /// <summary>
  ///   Custom XML Element Placeholder Text.
  /// </summary>
  public static String? GetCustomXmlPlaceholder(CustomXmlProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlPlaceholder>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCustomXmlPlaceholder(CustomXmlProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlPlaceholder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new CustomXmlPlaceholder { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<CustomXmlAttribute>? GetCustomXmlAttributes(CustomXmlProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<CustomXmlAttribute>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute>())
      {
        var newItem = CustomXmlAttributeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetCustomXmlAttributes(CustomXmlProperties? openXmlElement, Collection<CustomXmlAttribute>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CustomXmlAttributeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.CustomXmlProperties? CreateModelElement(CustomXmlProperties? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CustomXmlProperties? value)
    where OpenXmlElementType : CustomXmlProperties, new()
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