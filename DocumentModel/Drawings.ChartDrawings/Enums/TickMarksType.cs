namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the TickMarksType enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TickMarksType
{
  /// <summary>
  ///   in.
  /// </summary>
  In,

  /// <summary>
  ///   out.
  /// </summary>
  Out,

  /// <summary>
  ///   cross.
  /// </summary>
  Cross,

  /// <summary>
  ///   none.
  /// </summary>
  None
}