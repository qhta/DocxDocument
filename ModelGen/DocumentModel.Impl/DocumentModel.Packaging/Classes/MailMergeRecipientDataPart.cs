namespace DocumentModel.Packaging;

/// <summary>
/// Defines MailMergeRecipientDataPart.
/// </summary>
public partial class MailMergeRecipientDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, MailMergeRecipientDataPart
{
  public new DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MailMergeRecipientDataPartImpl(): base() {}
  
  public MailMergeRecipientDataPartImpl(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData.
  /// </summary>
  public DocumentModel.Wordprocessing.Recipients? Recipients
  {
    get
    {
      if (OpenXmlElement?.Recipients != null)
        return new DocumentModel.Wordprocessing.RecipientsImpl(OpenXmlElement.Recipients);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.RecipientsImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Recipients = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeRecipients? MailMergeRecipients
  {
    get
    {
      if (OpenXmlElement?.MailMergeRecipients != null)
        return new DocumentModel.Wordprocessing.MailMergeRecipientsImpl(OpenXmlElement.MailMergeRecipients);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.MailMergeRecipientsImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.MailMergeRecipients = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
