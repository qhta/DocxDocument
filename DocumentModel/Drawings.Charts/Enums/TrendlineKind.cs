namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   ITrendline Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TrendlineKind
{
  /// <summary>
  ///   Exponential.
  /// </summary>
  Exponential,

  /// <summary>
  ///   Linear.
  /// </summary>
  Linear,

  /// <summary>
  ///   Logarithmic.
  /// </summary>
  Logarithmic,

  /// <summary>
  ///   Moving Average.
  /// </summary>
  MovingAverage,

  /// <summary>
  ///   Polynomial.
  /// </summary>
  Polynomial,

  /// <summary>
  ///   Power.
  /// </summary>
  Power
}
