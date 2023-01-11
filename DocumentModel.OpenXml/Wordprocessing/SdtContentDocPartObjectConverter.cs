namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartObject Class.
/// </summary>
public static class SdtContentDocPartObjectConverter
{
  public static String? GetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement)
  {
    return openXmlElement?.DocPartGallery?.Val?.Value;
  }
  
  public static void SetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.DocPartGallery = new DocumentFormat.OpenXml.Wordprocessing.DocPartGallery { Val = value };
      else
        openXmlElement.DocPartGallery = null;
    }
  }
  
  public static String? GetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement)
  {
    return openXmlElement?.DocPartCategory?.Val?.Value;
  }
  
  public static void SetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.DocPartCategory = new DocumentFormat.OpenXml.Wordprocessing.DocPartCategory { Val = value };
      else
        openXmlElement.DocPartCategory = null;
    }
  }
  
  public static Boolean? GetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartUnique>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Wordprocessing.SdtContentDocPartObject? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
