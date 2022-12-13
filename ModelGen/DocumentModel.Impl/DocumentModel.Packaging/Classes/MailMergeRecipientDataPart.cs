namespace DocumentModel.Packaging;

/// <summary>
/// Defines MailMergeRecipientDataPart.
/// </summary>
public class MailMergeRecipientDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, MailMergeRecipientDataPart
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeRecipients? MailMergeRecipients
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
