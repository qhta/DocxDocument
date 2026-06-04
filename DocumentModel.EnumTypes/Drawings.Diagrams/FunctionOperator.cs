namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the FunctionOperator enumeration.
/// Used in types such as DiagramChooseIf.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues))]
public enum FunctionOperator
{
  /// <summary>
  ///   Equal.
  /// </summary>
  [OpenXmlEnumValue("Equal")]
  Equal,
  /// <summary>
  ///   Not Equal To.
  /// </summary>
  [OpenXmlEnumValue("NotEqualTo")]
  NotEqualTo,
  /// <summary>
  ///   Greater Than.
  /// </summary>
  [OpenXmlEnumValue("GreaterThan")]
  GreaterThan,
  /// <summary>
  ///   Less Than.
  /// </summary>
  [OpenXmlEnumValue("LessThan")]
  LessThan,
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

