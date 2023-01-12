namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtPlaceholder Class.
/// </summary>
public static class SdtPlaceholderConverter
{
  /// <summary>
  /// Document Part Reference.
  /// </summary>
  public static String? GetDocPartReference(DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartReference>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDocPartReference(DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.DocPartReference { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtPlaceholder? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder, new()
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
