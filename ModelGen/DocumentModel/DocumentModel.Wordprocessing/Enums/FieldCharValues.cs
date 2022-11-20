namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FieldCharValues enumeration.
/// </summary>
public enum FieldCharValues
{
  /// <summary>
  /// Start Character.
  /// </summary>
  [XmlEnum("begin")]
  Begin,
  
  /// <summary>
  /// Separator Character.
  /// </summary>
  [XmlEnum("separate")]
  Separate,
  
  /// <summary>
  /// End Character.
  /// </summary>
  [XmlEnum("end")]
  End,
  
}
