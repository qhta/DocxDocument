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
    if (openXmlElement?.RootElement is DXW.Recipients rootElement)
      return DMXW.RecipientsConverter.CreateModelElement(rootElement);
    return null;
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
    if (openXmlElement?.RootElement is DXOW.MailMergeRecipients rootElement)
      return DMXW.MailMergeRecipientsConverter.CreateModelElement(rootElement);
    return null;
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
