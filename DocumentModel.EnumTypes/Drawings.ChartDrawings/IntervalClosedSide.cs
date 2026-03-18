namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the IntervalClosedSide enumeration.
/// Used in types such as Binning, IntervalClosedSide, BinningConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum IntervalClosedSide
{
  /// <summary>
  ///   l.
  /// </summary>
  [OpenXmlEnumValue("L")]
  L,
  /// <summary>
  ///   r.
  /// </summary>
  [OpenXmlEnumValue("R")]
  R
}
