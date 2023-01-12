namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines MailMergeRecipients.
/// </summary>
public static class MailMergeRecipientsConverter
{
  public static DocumentModel.Wordprocessing.SingleDataSourceRecord? GetSingleDataSourceRecord(DocumentFormat.OpenXml.Office.Word.MailMergeRecipients? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SingleDataSourceRecordConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSingleDataSourceRecord(DocumentFormat.OpenXml.Office.Word.MailMergeRecipients? openXmlElement, DocumentModel.Wordprocessing.SingleDataSourceRecord? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SingleDataSourceRecordConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MailMergeRecipients? CreateModelElement(DocumentFormat.OpenXml.Office.Word.MailMergeRecipients? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MailMergeRecipients();
      value.SingleDataSourceRecord = GetSingleDataSourceRecord(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.MailMergeRecipients? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.MailMergeRecipients, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
