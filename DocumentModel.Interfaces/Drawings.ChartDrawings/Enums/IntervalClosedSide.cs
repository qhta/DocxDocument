namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the IntervalClosedSide enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum IntervalClosedSide
{
  /// <summary>
  ///   l.
  /// </summary>
  L,
  /// <summary>
  ///   r.
  /// </summary>
  R
}