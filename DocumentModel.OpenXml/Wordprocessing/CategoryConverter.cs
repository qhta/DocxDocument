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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
  
}
