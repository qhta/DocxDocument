namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Defines the WebVideoProperty Class.
/// </summary>
public class WebVideoPropertyImpl: ModelElementImpl, WebVideoProperty
{
  public DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  public String? EmbeddedHtml
  {
    get;
    set;
  }
  
  /// <summary>
  /// h, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Height
  {
    get;
    set;
  }
  
  /// <summary>
  /// w, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Width
  {
    get;
    set;
  }
  
}
