namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the LineCapValues enumeration.
/// </summary>
public enum LineCap
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
