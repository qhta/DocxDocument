namespace DocumentModel.Spreadsheet;

/// <summary>
/// Calculation Mode
/// </summary>
public enum CalculateModeValues
{
  /// <summary>
  /// Manual Calculation Mode.
  /// </summary>
  [XmlEnum("manual")]
  Manual,
  
  /// <summary>
  /// Automatic.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
  /// <summary>
  /// Automatic Calculation (No Tables).
  /// </summary>
  [XmlEnum("autoNoTable")]
  AutoNoTable,
  
}
