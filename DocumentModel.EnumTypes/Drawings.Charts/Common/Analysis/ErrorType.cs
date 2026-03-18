namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Error enumeration.
/// Used in types such as CSharpVerifierHelper, AddOpenXmlEnumTypeAttribute, AddOpenXmlPropertyAttribute.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.ErrorValues))]
public enum ErrorType
{
  /// <summary>
  ///   Custom Error Bars.
  /// </summary>
  [OpenXmlEnumValue("Custom")]
  Custom,
  /// <summary>
  ///   Fixed Value.
  /// </summary>
  [OpenXmlEnumValue("FixedValue")]
  FixedValue,
  /// <summary>
  ///   Percentage.
  /// </summary>
  [OpenXmlEnumValue("Percentage")]
  Percentage,
  /// <summary>
  ///   Standard Deviation.
  /// </summary>
  [OpenXmlEnumValue("StandardDeviation")]
  StandardDeviation,
  /// <summary>
  ///   Standard Error.
  /// </summary>
  [OpenXmlEnumValue("StandardError")]
  StandardError
}
