using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SdtContentDocPartList Class.
/// </summary>
public static class SdtContentDocPartListConverter
{
  public static String? GetDocPartGallery(SdtContentDocPartList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocPartGallery>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDocPartGallery(SdtContentDocPartList? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocPartGallery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocPartGallery { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetDocPartCategory(SdtContentDocPartList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocPartCategory>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDocPartCategory(SdtContentDocPartList? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocPartCategory>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocPartCategory { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDocPartUnique(SdtContentDocPartList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocPartUnique>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDocPartUnique(SdtContentDocPartList? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocPartUnique>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocPartUnique();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.SdtContentDocPartList? CreateModelElement(SdtContentDocPartList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentDocPartList();
      value.DocPartGallery = GetDocPartGallery(openXmlElement);
      value.DocPartCategory = GetDocPartCategory(openXmlElement);
      value.DocPartUnique = GetDocPartUnique(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtContentDocPartList? value)
    where OpenXmlElementType : SdtContentDocPartList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocPartGallery(openXmlElement, value?.DocPartGallery);
      SetDocPartCategory(openXmlElement, value?.DocPartCategory);
      SetDocPartUnique(openXmlElement, value?.DocPartUnique);
      return openXmlElement;
    }
    return default;
  }
}