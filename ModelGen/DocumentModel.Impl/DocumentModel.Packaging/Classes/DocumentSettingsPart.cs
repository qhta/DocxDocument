namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentSettingsPart
/// </summary>
public class DocumentSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, DocumentSettingsPart
{
  /// <summary>
  /// Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
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
