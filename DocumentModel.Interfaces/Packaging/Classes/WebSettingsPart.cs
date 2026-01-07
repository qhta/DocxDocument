namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WebSettingsPart
/// </summary>
public interface WebSettingsPart: OpenXmlPart
{


  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMW.WebSettings? WebSettings { get; set; }
}