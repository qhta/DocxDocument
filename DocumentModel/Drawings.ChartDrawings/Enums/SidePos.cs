namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the SidePos enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SidePos
{
  /// <summary>
  ///   l.
  /// </summary>
  L,

  /// <summary>
  ///   t.
  /// </summary>
  T,

  /// <summary>
  ///   r.
  /// </summary>
  R,

  /// <summary>
  ///   b.
  /// </summary>
  B
}