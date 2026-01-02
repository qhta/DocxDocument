namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PosAlign enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PosAlign
{
  /// <summary>
  ///   min.
  /// </summary>
  Min,
  /// <summary>
  ///   ctr.
  /// </summary>
  Ctr,
  /// <summary>
  ///   max.
  /// </summary>
  Max
}