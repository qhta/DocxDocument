namespace DocumentModel.Math;
/// <summary>
///   Defines the BreakBinaryOperatorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.BreakBinaryOperatorValues))]
public enum BreakBinaryOperator
{
  /// <summary>
  ///   Break occurs before binary operator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BreakBinaryOperatorValues.Before))]
  Before,
  /// <summary>
  ///   Break occurs after binary operator.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BreakBinaryOperatorValues.After))]
  After,
  /// <summary>
  ///   Break occurs after binary operator, but the operator is repeater at the beginning on the next line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BreakBinaryOperatorValues.Repeat))]
  Repeat
}