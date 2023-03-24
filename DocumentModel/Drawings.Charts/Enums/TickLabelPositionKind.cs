namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Tick Label Position
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TickLabelPositionKind
{
  /// <summary>
  ///   High.
  /// </summary>
  High,

  /// <summary>
  ///   Low.
  /// </summary>
  Low,

  /// <summary>
  ///   Next To.
  /// </summary>
  NextTo,

  /// <summary>
  ///   None.
  /// </summary>
  None
}