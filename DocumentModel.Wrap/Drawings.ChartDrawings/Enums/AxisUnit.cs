namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the AxisUnit enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AxisUnit
{
  /// <summary>
  ///   hundreds.
  /// </summary>
  Hundreds,

  /// <summary>
  ///   thousands.
  /// </summary>
  Thousands,

  /// <summary>
  ///   tenThousands.
  /// </summary>
  TenThousands,

  /// <summary>
  ///   hundredThousands.
  /// </summary>
  HundredThousands,

  /// <summary>
  ///   millions.
  /// </summary>
  Millions,

  /// <summary>
  ///   tenMillions.
  /// </summary>
  TenMillions,

  /// <summary>
  ///   hundredMillions.
  /// </summary>
  HundredMillions,

  /// <summary>
  ///   billions.
  /// </summary>
  Billions,

  /// <summary>
  ///   trillions.
  /// </summary>
  Trillions,

  /// <summary>
  ///   percentage.
  /// </summary>
  Percentage
}