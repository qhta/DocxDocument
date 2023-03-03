namespace DocumentModel.Vml;

/// <summary>
///   Line Join Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StrokeJoinStyleKind
{
  /// <summary>
  ///   Round Joint.
  /// </summary>
  Round,

  /// <summary>
  ///   Bevel Joint.
  /// </summary>
  Bevel,

  /// <summary>
  ///   Miter Joint.
  /// </summary>
  Miter
}