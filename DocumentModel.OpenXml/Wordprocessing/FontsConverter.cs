using DocumentModel.Wordprocessing;
using Fonts = DocumentFormat.OpenXml.Wordprocessing.Fonts;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Font Table Root Element.
/// </summary>
public static class FontsConverter
{
  public static Collection<Font>? GetItems(Fonts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Font>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Font>())
      {
        var newItem = FontConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(Fonts? openXmlElement, Collection<Font>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Font>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = FontConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Font>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Fonts? CreateModelElement(Fonts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Fonts();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Fonts? value)
    where OpenXmlElementType : Fonts, new()
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