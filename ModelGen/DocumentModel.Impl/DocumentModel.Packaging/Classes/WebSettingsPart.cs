namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
public class WebSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, WebSettingsPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.WebSettings? WebSettings
  {
    get;
    set;
  }
  
}
