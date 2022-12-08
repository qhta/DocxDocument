namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EastAsianLayout Class.
/// </summary>
public class EastAsianLayoutImpl: ModelElementImpl, EastAsianLayout
{
  public DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// East Asian Typography Run ID
  /// </summary>
  public Int32? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Two Lines in One
  /// </summary>
  public Boolean? Combine
  {
    get;
    set;
  }
  
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
  
  /// <summary>
  /// Horizontal in Vertical (Rotate Text)
  /// </summary>
  public Boolean? Vertical
  {
    get;
    set;
  }
  
  /// <summary>
  /// Compress Rotated Text to Line Height
  /// </summary>
  public Boolean? VerticalCompress
  {
    get;
    set;
  }
  
}
