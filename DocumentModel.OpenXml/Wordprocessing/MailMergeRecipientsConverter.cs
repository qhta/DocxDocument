using DocumentModel.Wordprocessing;
using MailMergeRecipients = DocumentFormat.OpenXml.Office.Word.MailMergeRecipients;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines MailMergeRecipients.
/// </summary>
public static class MailMergeRecipientsConverter
{
  public static SingleDataSourceRecord? GetSingleDataSourceRecord(MailMergeRecipients? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord>();
    if (itemElement != null)
      return SingleDataSourceRecordConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSingleDataSourceRecord(MailMergeRecipients? openXmlElement, SingleDataSourceRecord? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SingleDataSourceRecordConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.MailMergeRecipients? CreateModelElement(MailMergeRecipients? openXmlElement)
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
    where OpenXmlElementType : MailMergeRecipients, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSingleDataSourceRecord(openXmlElement, value?.SingleDataSourceRecord);
      return openXmlElement;
    }
    return default;
  }
}