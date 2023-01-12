namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtRepeatedSection Class.
/// </summary>
public static class SdtRepeatedSectionConverter
{
  /// <summary>
  /// SectionTitle.
  /// </summary>
  public static String? GetSectionTitle(DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2013.Word.SectionTitle");
  }
  
  public static void SetSectionTitle(DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2013.Word.SectionTitle");
  }
  
  /// <summary>
  /// DoNotAllowInsertDeleteSection.
  /// </summary>
  public static Boolean? GetDoNotAllowInsertDeleteSection(DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.DoNotAllowInsertDeleteSection>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotAllowInsertDeleteSection(DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.DoNotAllowInsertDeleteSection>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2013.Word.DoNotAllowInsertDeleteSection();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtRepeatedSection? CreateModelElement(DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtRepeatedSection();
      value.SectionTitle = GetSectionTitle(openXmlElement);
      value.DoNotAllowInsertDeleteSection = GetDoNotAllowInsertDeleteSection(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtRepeatedSection? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSectionTitle(openXmlElement, value?.SectionTitle);
      SetDoNotAllowInsertDeleteSection(openXmlElement, value?.DoNotAllowInsertDeleteSection);
      return openXmlElement;
    }
    return default;
  }
}
