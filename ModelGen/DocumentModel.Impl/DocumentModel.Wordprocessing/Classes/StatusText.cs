namespace DocumentModel.Wordprocessing;

/// <summary>
/// Associated Status Text.
/// </summary>
public class StatusTextImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.StatusText>, StatusText
{
  /// <summary>
  /// Status Text Type
  /// </summary>
  public InfoTextKind? Type
  {
    get => (InfoTextKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.InfoTextValues?)value;
    }
  }
  
}
