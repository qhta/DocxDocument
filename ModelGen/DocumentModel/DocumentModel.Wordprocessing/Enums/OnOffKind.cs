namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the OnOffValues enumeration.
/// </summary>
public enum OnOffKind
{
  /// <summary>
  /// true.
  /// </summary>
  [XmlEnum("true")]
  True,
  
  /// <summary>
  /// false.
  /// </summary>
  [XmlEnum("false")]
  False,
  
  /// <summary>
  /// 0.
  /// </summary>
  [XmlEnum("0")]
  Zero,
  
  /// <summary>
  /// 1.
  /// </summary>
  [XmlEnum("1")]
  One,
  
}
