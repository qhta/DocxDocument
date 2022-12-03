namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextBoxTightWrapValues enumeration.
/// </summary>
public enum TextBoxTightWrapKind
{
  /// <summary>
  /// Do Not Tight Wrap.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Tight Wrap All Lines.
  /// </summary>
  [XmlEnum("allLines")]
  AllLines,
  
  /// <summary>
  /// Tight Wrap First and Last Lines.
  /// </summary>
  [XmlEnum("firstAndLastLine")]
  FirstAndLastLine,
  
  /// <summary>
  /// Tight Wrap First Line.
  /// </summary>
  [XmlEnum("firstLineOnly")]
  FirstLineOnly,
  
  /// <summary>
  /// Tight Wrap Last Line.
  /// </summary>
  [XmlEnum("lastLineOnly")]
  LastLineOnly,
  
}
