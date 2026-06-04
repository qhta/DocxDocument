namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FormulaDirection enumeration.
/// Used in types such as OpenXmlFormulaElement, FormulaDirection, OpenXmlFormulaElementConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FormulaDirection
{
  /// <summary>
  ///   col.
  /// </summary>
  [OpenXmlEnumValue("Col")]
  Col,
  /// <summary>
  ///   row.
  /// </summary>
  [OpenXmlEnumValue("IRow")]
  IRow
}

