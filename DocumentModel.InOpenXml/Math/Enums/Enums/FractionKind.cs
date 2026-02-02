namespace DocumentModel.Math;
/// <summary>
///   Defines the FractionTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.FractionTypeValues))]
public enum FractionKind
{
  /// <summary>
  ///   Bar Fraction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.FractionTypeValues.Bar))]
  Bar,
  /// <summary>
  ///   Skewed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.FractionTypeValues.Skewed))]
  Skewed,
  /// <summary>
  ///   Linear Fraction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.FractionTypeValues.Linear))]
  Linear,
  /// <summary>
  ///   No-Bar Fraction (Stack).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.FractionTypeValues.NoBar))]
  NoBar
}