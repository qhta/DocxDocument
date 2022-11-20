namespace DocumentModel.Spreadsheet;

/// <summary>
/// Volatile Dependency Types
/// </summary>
public enum VolatileDependencyValues
{
  /// <summary>
  /// Real Time Data.
  /// </summary>
  [XmlEnum("realTimeData")]
  RealTimeData,
  
  /// <summary>
  /// OLAP Formulas.
  /// </summary>
  [XmlEnum("olapFunctions")]
  OlapFunctions,
  
}
