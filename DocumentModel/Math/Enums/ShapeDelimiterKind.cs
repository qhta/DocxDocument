namespace DocumentModel.Math;

/// <summary>
///   Defines the ShapeDelimiterValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ShapeDelimiterKind
{
  /// <summary>
  ///   Centered (Delimiters).
  /// </summary>
  Centered,

  /// <summary>
  ///   Match.
  /// </summary>
  Match
}