namespace DocumentModel.InkML;

/// <summary>
/// Defines the ChannelDataTypeValues enumeration.
/// </summary>
public enum ChannelDataTypeValues
{
  /// <summary>
  /// integer.
  /// </summary>
  [XmlEnum("integer")]
  Integer,
  
  /// <summary>
  /// decimal.
  /// </summary>
  [XmlEnum("decimal")]
  Decimal,
  
  /// <summary>
  /// boolean.
  /// </summary>
  [XmlEnum("boolean")]
  Boolean,
  
}
