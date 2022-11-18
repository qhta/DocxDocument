namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HeaderFooterValues enumeration.
/// </summary>
public enum HeaderFooter
{
  /// <summary>
  /// Even Numbered Pages Only.
  /// </summary>
  [XmlEnum("even")]
  Even,
  
  /// <summary>
  /// Default Header or Footer.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// First Page Only.
  /// </summary>
  [XmlEnum("first")]
  First,
  
}
