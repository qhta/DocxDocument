namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines MailMergeRecipientDataPart.
/// </summary>
public static class MailMergeRecipientDataPartConverter
{
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData.
  /// </summary>
  public static DocumentModel.Wordprocessing.Recipients? GetRecipients(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetRecipients(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart? openXmlElement, DocumentModel.Wordprocessing.Recipients? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeRecipients? GetMailMergeRecipients(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetMailMergeRecipients(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart? openXmlElement, DocumentModel.Wordprocessing.MailMergeRecipients? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.MailMergeRecipientDataPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.MailMergeRecipientDataPart();
      value.Recipients = GetRecipients(openXmlElement);
      value.MailMergeRecipients = GetMailMergeRecipients(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.MailMergeRecipientDataPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
