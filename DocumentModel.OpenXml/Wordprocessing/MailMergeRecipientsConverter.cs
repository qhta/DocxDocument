namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines MailMergeRecipients.
/// </summary>
public static class MailMergeRecipientsConverter
{
  private static DMW.SingleDataSourceRecord? GetSingleDataSourceRecord(DXOW.MailMergeRecipients openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOW.SingleDataSourceRecord>();
    if (itemElement != null)
      return DMXW.SingleDataSourceRecordConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSingleDataSourceRecord(DXOW.MailMergeRecipients openXmlElement, DMW.SingleDataSourceRecord? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.SingleDataSourceRecord>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SingleDataSourceRecordConverter.CreateOpenXmlElement<DXOW.SingleDataSourceRecord>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.MailMergeRecipients? CreateModelElement(DXOW.MailMergeRecipients? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MailMergeRecipients();
      value.SingleDataSourceRecord = GetSingleDataSourceRecord(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.MailMergeRecipients? value)
    where OpenXmlElementType: DXOW.MailMergeRecipients, new()
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
