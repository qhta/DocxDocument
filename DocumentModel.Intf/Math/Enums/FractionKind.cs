namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FractionTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FractionKind
{
  /// <summary>
  ///   Bar Fraction.
  /// </summary>
  Bar,

  /// <summary>
  ///   Skewed.
  /// </summary>
  Skewed,

  /// <summary>
  ///   Linear Fraction.
  /// </summary>
  Linear,

  /// <summary>
  ///   No-Bar Fraction (Stack).
  /// </summary>
  NoBar
}