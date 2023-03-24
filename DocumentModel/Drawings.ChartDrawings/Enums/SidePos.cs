namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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