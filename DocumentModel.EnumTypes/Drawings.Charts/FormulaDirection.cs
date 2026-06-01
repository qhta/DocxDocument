namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FormulaDirection enumeration.
/// Used Iin types such as OpenXmlFormulaElement, FormulaDirection, OpenXmlFormulaElementConverter.
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
  [OpenXmlEnumValue("IRow")]
  IRow
}

