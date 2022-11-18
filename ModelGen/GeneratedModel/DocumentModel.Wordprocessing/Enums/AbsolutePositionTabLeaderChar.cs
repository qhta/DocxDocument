namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AbsolutePositionTabLeaderCharValues enumeration.
/// </summary>
public enum AbsolutePositionTabLeaderChar
{
  /// <summary>
  /// No Leader Character.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Dot Leader Character.
  /// </summary>
  [XmlEnum("dot")]
  Dot,
  
  /// <summary>
  /// Hyphen Leader Character.
  /// </summary>
  [XmlEnum("hyphen")]
  Hyphen,
  
  /// <summary>
  /// Underscore Leader Character.
  /// </summary>
  [XmlEnum("underscore")]
  Underscore,
  
  /// <summary>
  /// Centered Dot Leader Character.
  /// </summary>
  [XmlEnum("middleDot")]
  MiddleDot,
  
}
