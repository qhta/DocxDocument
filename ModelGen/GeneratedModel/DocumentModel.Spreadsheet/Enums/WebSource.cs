namespace DocumentModel.Spreadsheet;

/// <summary>
/// Web Source Type
/// </summary>
public enum WebSource
{
  /// <summary>
  /// All Sheet Content.
  /// </summary>
  [XmlEnum("sheet")]
  Sheet,
  
  /// <summary>
  /// Print Area.
  /// </summary>
  [XmlEnum("printArea")]
  PrintArea,
  
  /// <summary>
  /// AutoFilter.
  /// </summary>
  [XmlEnum("autoFilter")]
  AutoFilter,
  
  /// <summary>
  /// Range.
  /// </summary>
  [XmlEnum("range")]
  Range,
  
  /// <summary>
  /// Chart.
  /// </summary>
  [XmlEnum("chart")]
  Chart,
  
  /// <summary>
  /// PivotTable.
  /// </summary>
  [XmlEnum("pivotTable")]
  PivotTable,
  
  /// <summary>
  /// QueryTable.
  /// </summary>
  [XmlEnum("query")]
  Query,
  
  /// <summary>
  /// Label.
  /// </summary>
  [XmlEnum("label")]
  Label,
  
}
