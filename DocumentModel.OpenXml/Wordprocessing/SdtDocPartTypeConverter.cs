using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SdtDocPartType Class.
/// </summary>
public static class SdtDocPartTypeConverter
{
  /// <summary>
  ///   Document Part Gallery Filter.
  /// </summary>
  public static String? GetDocPartGallery(SdtDocPartType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocPartGallery>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDocPartGallery(SdtDocPartType? openXmlElement, String? value)
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

  /// <summary>
  ///   Document Part Category Filter.
  /// </summary>
  public static String? GetDocPartCategory(SdtDocPartType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocPartCategory>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDocPartCategory(SdtDocPartType? openXmlElement, String? value)
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

  /// <summary>
  ///   Built-In Document Part.
  /// </summary>
  public static Boolean? GetDocPartUnique(SdtDocPartType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocPartUnique>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDocPartUnique(SdtDocPartType? openXmlElement, Boolean? value)
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

  public static DocumentModel.Wordprocessing.SdtDocPartType? CreateModelElement(SdtDocPartType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtDocPartType();
      value.DocPartGallery = GetDocPartGallery(openXmlElement);
      value.DocPartCategory = GetDocPartCategory(openXmlElement);
      value.DocPartUnique = GetDocPartUnique(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtDocPartType? value)
    where OpenXmlElementType : SdtDocPartType, new()
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