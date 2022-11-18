namespace DocumentModel.Spreadsheet;

/// <summary>
/// MDX KPI Property
/// </summary>
public enum MdxKPIProperty
{
  /// <summary>
  /// Value.
  /// </summary>
  [XmlEnum("v")]
  Value,
  
  /// <summary>
  /// Goal.
  /// </summary>
  [XmlEnum("g")]
  Goal,
  
  /// <summary>
  /// Status.
  /// </summary>
  [XmlEnum("s")]
  Status,
  
  /// <summary>
  /// Trend.
  /// </summary>
  [XmlEnum("t")]
  Trend,
  
  /// <summary>
  /// Weight.
  /// </summary>
  [XmlEnum("w")]
  Weight,
  
  /// <summary>
  /// Current Time Member.
  /// </summary>
  [XmlEnum("m")]
  Time,
  
}
