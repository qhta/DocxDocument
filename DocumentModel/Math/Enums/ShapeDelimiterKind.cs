namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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