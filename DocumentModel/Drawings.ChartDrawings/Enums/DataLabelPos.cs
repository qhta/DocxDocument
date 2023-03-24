namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataLabelPos enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DataLabelPos
{
  /// <summary>
  ///   bestFit.
  /// </summary>
  BestFit,

  /// <summary>
  ///   b.
  /// </summary>
  B,

  /// <summary>
  ///   ctr.
  /// </summary>
  Ctr,

  /// <summary>
  ///   inBase.
  /// </summary>
  InBase,

  /// <summary>
  ///   inEnd.
  /// </summary>
  InEnd,

  /// <summary>
  ///   l.
  /// </summary>
  L,

  /// <summary>
  ///   outEnd.
  /// </summary>
  OutEnd,

  /// <summary>
  ///   r.
  /// </summary>
  R,

  /// <summary>
  ///   t.
  /// </summary>
  T
}