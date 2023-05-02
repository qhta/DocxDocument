namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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