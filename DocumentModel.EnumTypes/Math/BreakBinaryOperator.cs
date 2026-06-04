namespace DocumentModel.Math;
/// <summary>
///   Defines the BreakBinaryOperatorValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues))]
public enum BreakBinaryOperator
{
  /// <summary>
  ///   Break occurs before binary operator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues.Before))]
  Before,
  /// <summary>
  ///   Break occurs after binary operator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues.After))]
  After,
  /// <summary>
  ///   Break occurs after binary operator, but the operator is repeater at the beginning on the next line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues.Repeat))]
  Repeat
}