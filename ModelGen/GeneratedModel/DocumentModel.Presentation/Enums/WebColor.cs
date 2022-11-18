namespace DocumentModel.Presentation;

/// <summary>
/// HTML Slide Navigation Control Colors
/// </summary>
public enum WebColor
{
  /// <summary>
  /// Non-specific Colors.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Browser Colors.
  /// </summary>
  [XmlEnum("browser")]
  Browser,
  
  /// <summary>
  /// Presentation Text Colors.
  /// </summary>
  [XmlEnum("presentationText")]
  PresentationText,
  
  /// <summary>
  /// Presentation Accent Colors.
  /// </summary>
  [XmlEnum("presentationAccent")]
  PresentationAccent,
  
  /// <summary>
  /// White Text on Black Colors.
  /// </summary>
  [XmlEnum("whiteTextOnBlack")]
  WhiteTextOnBlack,
  
  /// <summary>
  /// Black Text on White Colors.
  /// </summary>
  [XmlEnum("blackTextOnWhite")]
  BlackTextOnWhite,
  
}
