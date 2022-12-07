namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public class FontCharSetImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.FontCharSet>, FontCharSet
{
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
