namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Categorization.
/// </summary>
public static class CategoryConverter
{
  /// <summary>
  /// Category Associated With Entry.
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Wordprocessing.Category? openXmlElement)
  {
    return openXmlElement?.Name?.Val?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Wordprocessing.Category? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Name = new DocumentFormat.OpenXml.Wordprocessing.Name { Val = value };
      else
        openXmlElement.Name = null;
    }
  }
  
  /// <summary>
  /// Gallery Associated With Entry.
  /// </summary>
  public static DocumentModel.Wordprocessing.DocPartGalleryKind? GetGallery(DocumentFormat.OpenXml.Wordprocessing.Category? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Gallery>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues, DocumentModel.Wordprocessing.DocPartGalleryKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetGallery(DocumentFormat.OpenXml.Wordprocessing.Category? openXmlElement, DocumentModel.Wordprocessing.DocPartGalleryKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Gallery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Gallery, DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues, DocumentModel.Wordprocessing.DocPartGalleryKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Category? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Category? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Category, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
