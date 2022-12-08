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
  
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData.
  /// </summary>
  public DocumentModel.Wordprocessing.Recipients? Recipients
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeRecipients? MailMergeRecipients
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
