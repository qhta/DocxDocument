namespace DocumentModel.Vml;

/// <summary>
///   Stroke End Cap Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StrokeEndCapKind
{
  /// <summary>
  ///   Flat End.
  /// </summary>
  Flat,

  /// <summary>
  ///   Square End.
  /// </summary>
  Square,

  /// <summary>
  ///   Round End.
  /// </summary>
  Round
}