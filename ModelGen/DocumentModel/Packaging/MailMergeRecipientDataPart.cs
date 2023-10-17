namespace DocumentModel.Packaging;


/// <summary>
///   Defines the MailMergeRecipientDataPart
/// </summary>
public partial class MailMergeRecipientDataPart
{
  
  /// <summary>
  ///   Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData.
  ///               Setting this property will throw InvalidOperationException if the MailMergeRecipients property is not null.
  /// </summary>
  public DocumentModel.Wordprocessing.Recipients? Recipients { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
