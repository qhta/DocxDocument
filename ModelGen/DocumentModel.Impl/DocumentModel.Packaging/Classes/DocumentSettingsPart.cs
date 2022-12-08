namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentSettingsPart
/// </summary>
public class DocumentSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DocumentSettingsPart
{
  public new DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DocumentSettingsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public ImagePart? ImageParts
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Settings? Settings
  {
    get;
    set;
  }
  
}
