namespace DocumentModel.Vml;

/// <summary>
///   Stroke Arrowhead Length
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StrokeArrowLengthKind
{
  /// <summary>
  ///   Short Arrowhead.
  /// </summary>
  Short,
  /// <summary>
  ///   Medium Arrowhead.
  /// </summary>
  Medium,
  /// <summary>
  ///   Long Arrowhead.
  /// </summary>
  Long
}