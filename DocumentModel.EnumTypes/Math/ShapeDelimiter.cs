namespace DocumentModel.Math;
/// <summary>
///   Defines the ShapeDelimiterValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.ShapeDelimiterValues))]
public enum ShapeDelimiter
{
  /// <summary>
  ///   Centered (Delimiters).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.ShapeDelimiterValues.Centered))]
  Centered,
  /// <summary>
  ///   Match.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.ShapeDelimiterValues.Match))]
  Match
}