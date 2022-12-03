namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineCapValues enumeration.
/// </summary>
public enum LineCapKind
{
  /// <summary>
  /// rnd.
  /// </summary>
  [XmlEnum("rnd")]
  Round,
  
  /// <summary>
  /// sq.
  /// </summary>
  [XmlEnum("sq")]
  Square,
  
  /// <summary>
  /// flat.
  /// </summary>
  [XmlEnum("flat")]
  Flat,
  
}
