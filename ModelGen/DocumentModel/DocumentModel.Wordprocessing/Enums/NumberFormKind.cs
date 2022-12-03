namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberFormValues enumeration.
/// </summary>
public enum NumberFormKind
{
  /// <summary>
  /// default.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// lining.
  /// </summary>
  [XmlEnum("lining")]
  Lining,
  
  /// <summary>
  /// oldStyle.
  /// </summary>
  [XmlEnum("oldStyle")]
  OldStyle,
  
}
