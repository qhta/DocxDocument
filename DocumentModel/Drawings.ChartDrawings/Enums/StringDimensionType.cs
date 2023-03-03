namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the StringDimensionType enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StringDimensionType
{
  /// <summary>
  ///   cat.
  /// </summary>
  Cat,

  /// <summary>
  ///   colorStr.
  /// </summary>
  ColorStr,

  /// <summary>
  ///   entityId.
  /// </summary>
  EntityId
}