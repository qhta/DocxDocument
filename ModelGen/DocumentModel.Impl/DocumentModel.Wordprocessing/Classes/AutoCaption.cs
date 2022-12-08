namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Automatic Captioning Setting.
/// </summary>
public class AutoCaptionImpl: ModelElementImpl, AutoCaption
{
  public DocumentFormat.OpenXml.Wordprocessing.AutoCaption? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.AutoCaption?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Identifier of Object to be Automatically Captioned
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Caption Used for Automatic Captioning
  /// </summary>
  public String? Caption
  {
    get;
    set;
  }
  
}
