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
  
  public WebVideoPropertyImpl(): base() {}
  
  public WebVideoPropertyImpl(DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  public String? EmbeddedHtml
  {
    get => (String?)OpenXmlElement?.EmbeddedHtml?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EmbeddedHtml = (System.String?)value;
    }
  }
  
  /// <summary>
  /// h, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Height
  {
    get => (UInt32?)OpenXmlElement?.Height?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Height = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// w, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Width
  {
    get => (UInt32?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.UInt32?)value;
    }
  }
  
}
