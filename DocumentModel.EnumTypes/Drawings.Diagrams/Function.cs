namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the Function enumeration.
/// Used in types such as ConnectionShape, GraphicFrame, Picture.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.FunctionValues))]
public enum Function
{
  /// <summary>
  ///   Count.
  /// </summary>
  [OpenXmlEnumValue("Count")]
  Count,
  /// <summary>
  ///   Position.
  /// </summary>
  [OpenXmlEnumValue("Position")]
  Position,
  /// <summary>
  ///   Reverse Position.
  /// </summary>
  [OpenXmlEnumValue("ReversePosition")]
  ReversePosition,
  /// <summary>
  ///   Position Even.
  /// </summary>
  [OpenXmlEnumValue("PositionEven")]
  PositionEven,
  /// <summary>
  ///   Position Odd.
  /// </summary>
  [OpenXmlEnumValue("PositionOdd")]
  PositionOdd,
  /// <summary>
  ///   Variable.
  /// </summary>
  [OpenXmlEnumValue("Variable")]
  Variable,
  /// <summary>
  ///   Depth.
  /// </summary>
  [OpenXmlEnumValue("Depth")]
  Depth,
  /// <summary>
  ///   Max Depth.
  /// </summary>
  [OpenXmlEnumValue("MaxDepth")]
  MaxDepth
}
