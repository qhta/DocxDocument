namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtDocPartType Class.
/// </summary>
public static class SdtDocPartTypeConverter
{
  /// <summary>
  /// Document Part Gallery Filter.
  /// </summary>
  public static String? GetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement)
  {
    return openXmlElement?.DocPartGallery?.Val?.Value;
  }
  
  public static void SetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.DocPartGallery = new DocumentFormat.OpenXml.Wordprocessing.DocPartGallery { Val = value };
      else
        openXmlElement.DocPartGallery = null;
    }
  }
  
  /// <summary>
  /// Document Part Category Filter.
  /// </summary>
  public static String? GetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement)
  {
    return openXmlElement?.DocPartCategory?.Val?.Value;
  }
  
  public static void SetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.DocPartCategory = new DocumentFormat.OpenXml.Wordprocessing.DocPartCategory { Val = value };
      else
        openXmlElement.DocPartCategory = null;
    }
  }
  
  /// <summary>
  /// Built-In Document Part.
  /// </summary>
  public static Boolean? GetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartUnique>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartUnique>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DocPartUnique();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtDocPartType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
