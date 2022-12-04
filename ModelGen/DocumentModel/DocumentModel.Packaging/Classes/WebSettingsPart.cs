namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
public class WebSettingsPart: DocumentModel.Packaging.OpenXmlPartContainer
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
