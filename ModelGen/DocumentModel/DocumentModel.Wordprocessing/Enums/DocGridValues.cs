namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocGridValues enumeration.
/// </summary>
public enum DocGridValues
{
  /// <summary>
  /// No Document Grid.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// Line Grid Only.
  /// </summary>
  [XmlEnum("lines")]
  Lines,
  
  /// <summary>
  /// Line and Character Grid.
  /// </summary>
  [XmlEnum("linesAndChars")]
  LinesAndChars,
  
  /// <summary>
  /// Character Grid Only.
  /// </summary>
  [XmlEnum("snapToChars")]
  SnapToChars,
  
}
