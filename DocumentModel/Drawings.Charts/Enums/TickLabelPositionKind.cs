namespace DocumentModel.Drawings.Charts;

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