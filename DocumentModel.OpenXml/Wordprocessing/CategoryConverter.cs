using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Category = DocumentFormat.OpenXml.Wordprocessing.Category;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Entry Categorization.
/// </summary>
public static class CategoryConverter
{
  /// <summary>
  ///   Category Associated With Entry.
  /// </summary>
  public static String? GetName(Category? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Name>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetName(Category? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Name>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Name { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Gallery Associated With Entry.
  /// </summary>
  public static DocPartGalleryKind? GetGallery(Category? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Gallery>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DocPartGalleryValues, DocPartGalleryKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetGallery(Category? openXmlElement, DocPartGalleryKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Gallery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Gallery, DocPartGalleryValues, DocPartGalleryKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Category? CreateModelElement(Category? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Category();
      value.Name = GetName(openXmlElement);
      value.Gallery = GetGallery(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Category? value)
    where OpenXmlElementType : Category, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetGallery(openXmlElement, value?.Gallery);
      return openXmlElement;
    }
    return default;
  }
}