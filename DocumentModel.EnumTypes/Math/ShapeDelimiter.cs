namespace DocumentModel.Math;
/// <summary>
///   Defines the ShapeDelimiterValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.ShapeDelimiterValues))]
public enum ShapeDelimiter
{
  /// <summary>
  ///   Centered (Delimiters).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.ShapeDelimiterValues.Centered))]
  Centered,
  /// <summary>
  ///   Match.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.ShapeDelimiterValues.Match))]
  Match
}