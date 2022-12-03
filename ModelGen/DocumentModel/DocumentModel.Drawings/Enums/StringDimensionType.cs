namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StringDimensionType enumeration.
/// </summary>
public enum StringDimensionType
{
  /// <summary>
  /// cat.
  /// </summary>
  [XmlEnum("cat")]
  Cat,
  
  /// <summary>
  /// colorStr.
  /// </summary>
  [XmlEnum("colorStr")]
  ColorStr,
  
  /// <summary>
  /// entityId.
  /// </summary>
  [XmlEnum("entityId")]
  EntityId,
  
}
