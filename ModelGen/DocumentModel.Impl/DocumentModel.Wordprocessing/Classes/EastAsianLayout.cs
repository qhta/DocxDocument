namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EastAsianLayout Class.
/// </summary>
public class EastAsianLayoutImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>, EastAsianLayout
{
  /// <summary>
  /// Display Brackets Around Two Lines in One
  /// </summary>
  public CombineBracketKind? CombineBrackets
  {
    get => (CombineBracketKind?)OpenXmlElement?.CombineBrackets?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CombineBrackets = (DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues?)value;
    }
  }
  
}
