namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Axis
/// </summary>
public enum PivotTableAxisValues
{
  /// <summary>
  /// Row Axis.
  /// </summary>
  [XmlEnum("axisRow")]
  AxisRow,
  
  /// <summary>
  /// Column Axis.
  /// </summary>
  [XmlEnum("axisCol")]
  AxisColumn,
  
  /// <summary>
  /// Include Count Filter.
  /// </summary>
  [XmlEnum("axisPage")]
  AxisPage,
  
  /// <summary>
  /// Values Axis.
  /// </summary>
  [XmlEnum("axisValues")]
  AxisValues,
  
}
