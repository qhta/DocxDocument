namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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