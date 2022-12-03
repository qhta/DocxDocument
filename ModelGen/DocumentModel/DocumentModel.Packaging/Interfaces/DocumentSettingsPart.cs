namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentSettingsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings")]
[PartConstraint(typeof(DocumentModel.Packaging.MailMergeRecipientDataPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
public interface DocumentSettingsPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Settings? Settings { get ; set; }
  
}
