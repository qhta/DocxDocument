namespace DocumentModel.Wordprocessing;

/// <summary>
/// Associated Help Text.
/// </summary>
public class HelpTextImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.HelpText>, HelpText
{
  /// <summary>
  /// Help Text Type
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
