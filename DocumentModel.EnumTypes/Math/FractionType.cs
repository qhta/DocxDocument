namespace DocumentModel.Math;
/// <summary>
///   Defines the FractionTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.FractionTypeValues))]
public enum FractionType
{
  /// <summary>
  ///   Bar Fraction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.FractionTypeValues.Bar))]
  Bar = 1,

  /// <summary>
  ///   Skewed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.FractionTypeValues.Skewed))]
  Skewed,
  /// <summary>
  ///   Linear Fraction.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.FractionTypeValues.Linear))]
  Linear,
  /// <summary>
  ///   No-Bar Fraction (Stack).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.FractionTypeValues.NoBar))]
  NoBar
}