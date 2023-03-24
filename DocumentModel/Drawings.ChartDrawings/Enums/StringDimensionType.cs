namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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