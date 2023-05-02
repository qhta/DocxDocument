namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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