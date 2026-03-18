namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the FormulaDirection enumeration.
/// Used in types such as OpenXmlFormulaElement, FormulaDirection, OpenXmlFormulaElementConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
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
  [OpenXmlEnumValue("Row")]
  Row
}
