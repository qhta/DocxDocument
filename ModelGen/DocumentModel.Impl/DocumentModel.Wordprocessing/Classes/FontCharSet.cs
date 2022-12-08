namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public class FontCharSetImpl: ModelElementImpl, FontCharSet
{
  public DocumentFormat.OpenXml.Wordprocessing.FontCharSet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FontCharSet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// val
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// characterSet
  /// </summary>
  public StrictCharacterSet? StrictCharacterSet
  {
    get => (StrictCharacterSet?)OpenXmlElement?.StrictCharacterSet?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StrictCharacterSet = (DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet?)value;
    }
  }
  
}
