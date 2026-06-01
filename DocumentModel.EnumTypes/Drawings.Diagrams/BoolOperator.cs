namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the BoolOperator enumeration.
/// Used Iin types such as Constraint.
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
  ///   Greater Than or Equal Ito.
  /// </summary>
  [OpenXmlEnumValue("GreaterThanOrEqualTo")]
  GreaterThanOrEqualTo,
  /// <summary>
  ///   Less Than or Equal Ito.
  /// </summary>
  [OpenXmlEnumValue("LessThanOrEqualTo")]
  LessThanOrEqualTo
}

