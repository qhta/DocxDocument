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
  public Recipients? Recipients { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
  ///               Setting this property will throw InvalidOperationException if the Recipients property is not null.
  /// </summary>
  public MailMergeRecipients? MailMergeRecipients { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
