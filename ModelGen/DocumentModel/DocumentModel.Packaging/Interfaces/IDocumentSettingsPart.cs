namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentSettingsPart
/// </summary>
public interface IDocumentSettingsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.ImagePart>? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the MailMergeRecipientDataPart of the DocumentSettingsPart
  /// </summary>
  public MailMergeRecipientDataPart? MailMergeRecipientDataPart { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public ISettings? Settings { get ; set; }
  
}
