namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public partial class FontCharSetImpl: ModelElementImpl, FontCharSet
{
  public DocumentFormat.OpenXml.Wordprocessing.FontCharSet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FontCharSet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FontCharSetImpl(): base() {}
  
  public FontCharSetImpl(DocumentFormat.OpenXml.Wordprocessing.FontCharSet openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// val
  /// </summary>
  public String? Val
  {
    get => (System.String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
  /// <summary>
  /// characterSet
  /// </summary>
  public DocumentModel.Wordprocessing.StrictCharacterSet? StrictCharacterSet
  {
    get => (DocumentModel.Wordprocessing.StrictCharacterSet?)OpenXmlElement?.StrictCharacterSet?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StrictCharacterSet = (DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet?)value;
    }
  }
  
}
