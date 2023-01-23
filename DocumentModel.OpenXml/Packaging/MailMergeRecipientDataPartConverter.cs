namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines MailMergeRecipientDataPart.
/// </summary>
public static class MailMergeRecipientDataPartConverter
{
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData.
  /// </summary>
  private static DMW.Recipients? GetRecipients(DXPack.MailMergeRecipientDataPart openXmlElement)
  {
      return DMXW.RecipientsConverter.CreateModelElement(openXmlElement?.RootElement as DXW.Recipients);
  }
  
  private static bool CmpRecipients(DXPack.MailMergeRecipientDataPart openXmlElement, DMW.Recipients? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetRecipients(DXPack.MailMergeRecipientDataPart openXmlElement, DMW.Recipients? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.RecipientsConverter.CreateOpenXmlElement<DXW.Recipients>(value);
       if (rootElement != null)
         openXmlElement.Recipients = rootElement;
    }
  }
  
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
  /// </summary>
  private static DMW.MailMergeRecipients? GetMailMergeRecipients(DXPack.MailMergeRecipientDataPart openXmlElement)
  {
      return DMXW.MailMergeRecipientsConverter.CreateModelElement(openXmlElement?.RootElement as DXOW.MailMergeRecipients);
  }
  
  private static bool CmpMailMergeRecipients(DXPack.MailMergeRecipientDataPart openXmlElement, DMW.MailMergeRecipients? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetMailMergeRecipients(DXPack.MailMergeRecipientDataPart openXmlElement, DMW.MailMergeRecipients? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.MailMergeRecipientsConverter.CreateOpenXmlElement<DXOW.MailMergeRecipients>(value);
       if (rootElement != null)
         openXmlElement.MailMergeRecipients = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.MailMergeRecipientDataPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.MailMergeRecipientDataPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.MailMergeRecipientDataPart? CreateModelElement(DXPack.MailMergeRecipientDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.MailMergeRecipientDataPart();
      value.Recipients = GetRecipients(openXmlElement);
      value.MailMergeRecipients = GetMailMergeRecipients(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.MailMergeRecipientDataPart? openXmlElement, DMPack.MailMergeRecipientDataPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRecipients(openXmlElement, value.Recipients, diffs, objName))
        ok = false;
      if (!CmpMailMergeRecipients(openXmlElement, value.MailMergeRecipients, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.MailMergeRecipientDataPart? value)
    where OpenXmlElementType: DXPack.MailMergeRecipientDataPart, new()
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
