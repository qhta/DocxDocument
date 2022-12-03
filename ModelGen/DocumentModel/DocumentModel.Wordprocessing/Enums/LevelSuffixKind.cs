namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LevelSuffixValues enumeration.
/// </summary>
public enum LevelSuffixKind
{
  /// <summary>
  /// Tab Between Numbering and Text.
  /// </summary>
  [XmlEnum("tab")]
  Tab,
  
  /// <summary>
  /// Space Between Numbering and Text.
  /// </summary>
  [XmlEnum("space")]
  Space,
  
  /// <summary>
  /// Nothing Between Numbering and Text.
  /// </summary>
  [XmlEnum("nothing")]
  Nothing,
  
}
