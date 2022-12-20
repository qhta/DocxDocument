namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentSettingsPart
/// </summary>
public partial interface DocumentSettingsPart
{
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  /// <summary>
  /// Gets the MailMergeRecipientDataPart of the DocumentSettingsPart
  /// </summary>
  public DocumentModel.Packaging.MailMergeRecipientDataPart? MailMergeRecipientDataPart { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Settings? Settings { get; set; }
  
}
