using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SdtContentDocPartObject Class.
/// </summary>
public static class SdtContentDocPartObjectConverter
{
  public static String? GetDocPartGallery(SdtContentDocPartObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocPartGallery>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDocPartGallery(SdtContentDocPartObject? openXmlElement, String? value)
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

  public static String? GetDocPartCategory(SdtContentDocPartObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocPartCategory>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDocPartCategory(SdtContentDocPartObject? openXmlElement, String? value)
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

  public static Boolean? GetDocPartUnique(SdtContentDocPartObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocPartUnique>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDocPartUnique(SdtContentDocPartObject? openXmlElement, Boolean? value)
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

  public static DocumentModel.Wordprocessing.SdtContentDocPartObject? CreateModelElement(SdtContentDocPartObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentDocPartObject();
      value.DocPartGallery = GetDocPartGallery(openXmlElement);
      value.DocPartCategory = GetDocPartCategory(openXmlElement);
      value.DocPartUnique = GetDocPartUnique(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtContentDocPartObject? value)
    where OpenXmlElementType : SdtContentDocPartObject, new()
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