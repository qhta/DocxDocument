namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the FormulaDirection enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FormulaDirection
{
  /// <summary>
  ///   col.
  /// </summary>
  Col,
  /// <summary>
  ///   row.
  /// </summary>
  Row
}