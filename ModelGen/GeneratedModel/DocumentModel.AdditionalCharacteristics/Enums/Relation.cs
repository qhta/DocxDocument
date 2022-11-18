namespace DocumentModel.AdditionalCharacteristics;

/// <summary>
/// Characteristic Relationship Types
/// </summary>
public enum Relation
{
  /// <summary>
  /// Greater Than or Equal to.
  /// </summary>
  [XmlEnum("ge")]
  GreaterThanOrEqualTo,
  
  /// <summary>
  /// Less Than or Equal To.
  /// </summary>
  [XmlEnum("le")]
  LessThanOrEqualTo,
  
  /// <summary>
  /// Greater Than.
  /// </summary>
  [XmlEnum("gt")]
  GreaterThan,
  
  /// <summary>
  /// Less Than.
  /// </summary>
  [XmlEnum("lt")]
  LessThan,
  
  /// <summary>
  /// Equal To.
  /// </summary>
  [XmlEnum("eq")]
  EqualTo,
  
}
