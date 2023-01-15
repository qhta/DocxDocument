using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SdtPlaceholder Class.
/// </summary>
public static class SdtPlaceholderConverter
{
  /// <summary>
  ///   Document Part Reference.
  /// </summary>
  public static String? GetDocPartReference(SdtPlaceholder? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocPartReference>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDocPartReference(SdtPlaceholder? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocPartReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocPartReference { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.SdtPlaceholder? CreateModelElement(SdtPlaceholder? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtPlaceholder();
      value.DocPartReference = GetDocPartReference(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtPlaceholder? value)
    where OpenXmlElementType : SdtPlaceholder, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocPartReference(openXmlElement, value?.DocPartReference);
      return openXmlElement;
    }
    return default;
  }
}