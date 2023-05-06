namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines MailMergeRecipients.
/// </summary>
public static class MailMergeRecipientsConverter
{
  private static DMW.SingleDataSourceRecord? GetSingleDataSourceRecord(DXOW.MailMergeRecipients openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOW.SingleDataSourceRecord>();
    if (element != null)
      return DMXW.SingleDataSourceRecordConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSingleDataSourceRecord(DXOW.MailMergeRecipients openXmlElement, DMW.SingleDataSourceRecord? value, DiffList? diffs, string? objName)
  {
    return DMXW.SingleDataSourceRecordConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOW.SingleDataSourceRecord>(), value, diffs, objName);
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
        openXmlElement.AppendChild(itemElement);
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
  
  public static bool CompareModelElement(DXOW.MailMergeRecipients? openXmlElement, DMW.MailMergeRecipients? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSingleDataSourceRecord(openXmlElement, value.SingleDataSourceRecord, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MailMergeRecipients value)
    where OpenXmlElementType: DXOW.MailMergeRecipients, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.MailMergeRecipients openXmlElement, DMW.MailMergeRecipients value)
  {
    SetSingleDataSourceRecord(openXmlElement, value?.SingleDataSourceRecord);
  }
}
