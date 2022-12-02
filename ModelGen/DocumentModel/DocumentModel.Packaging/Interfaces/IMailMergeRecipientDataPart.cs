namespace DocumentModel.Packaging;

/// <summary>
/// Defines MailMergeRecipientDataPart.
/// </summary>
public interface IMailMergeRecipientDataPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData.
  /// </summary>
  public DocumentModel.Wordprocessing.IRecipients? Recipients { get ; set; }
  
  /// <summary>
  /// Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
  /// </summary>
  public DocumentModel.Wordprocessing.IMailMergeRecipients? MailMergeRecipients { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
