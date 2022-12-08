namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
public class WebSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WebSettingsPart
{
  public new DocumentFormat.OpenXml.Packaging.WebSettingsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WebSettingsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
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
  public DocumentModel.Wordprocessing.WebSettings? WebSettings
  {
    get;
    set;
  }
  
}
