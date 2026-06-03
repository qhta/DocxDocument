namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the BoolOperator enumeration.
/// Used in types such as Constraint.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.BoolOperatorValues))]
public enum BoolOperator
{
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None,
  /// <summary>
  ///   Equal.
  /// </summary>
  [OpenXmlEnumValue("Equal")]
  Equal,
  /// <summary>
  ///   Greater Than or Equal to.
  /// </summary>
  [OpenXmlEnumValue("GreaterThanOrEqualTo")]
  GreaterThanOrEqualTo,
  /// <summary>
  ///   Less Than or Equal to.
  /// </summary>
  [OpenXmlEnumValue("LessThanOrEqualTo")]
  LessThanOrEqualTo
}

