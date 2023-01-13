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
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Recipients rootElement)
      return DocumentModel.OpenXml.Wordprocessing.RecipientsConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetRecipients(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart? openXmlElement, DocumentModel.Wordprocessing.Recipients? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Wordprocessing.RecipientsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Recipients>(value);
         if (rootElement != null)
           openXmlElement.Recipients = rootElement;
      }
  }
  
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeRecipients? GetMailMergeRecipients(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office.Word.MailMergeRecipients rootElement)
      return DocumentModel.OpenXml.Wordprocessing.MailMergeRecipientsConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetMailMergeRecipients(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart? openXmlElement, DocumentModel.Wordprocessing.MailMergeRecipients? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Wordprocessing.MailMergeRecipientsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.MailMergeRecipients>(value);
         if (rootElement != null)
           openXmlElement.MailMergeRecipients = rootElement;
      }
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRecipients(openXmlElement, value?.Recipients);
      SetMailMergeRecipients(openXmlElement, value?.MailMergeRecipients);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
