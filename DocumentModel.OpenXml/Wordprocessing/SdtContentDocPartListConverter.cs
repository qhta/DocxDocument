namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartList Class.
/// </summary>
public static class SdtContentDocPartListConverter
{
  private static String? GetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartGallery>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartGallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.DocPartGallery { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartCategory>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartCategory>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.DocPartCategory { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartUnique>();
    return itemElement != null;
  }
  
  private static void SetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Wordprocessing.SdtContentDocPartList? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList, new()
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
