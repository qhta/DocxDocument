namespace DocumentModel.Spreadsheet;

/// <summary>
/// Print Errors
/// </summary>
public enum PrintError
{
  /// <summary>
  /// Display Cell Errors.
  /// </summary>
  [XmlEnum("displayed")]
  Displayed,
  
  /// <summary>
  /// Show Cell Errors As Blank.
  /// </summary>
  [XmlEnum("blank")]
  Blank,
  
  /// <summary>
  /// Dash Cell Errors.
  /// </summary>
  [XmlEnum("dash")]
  Dash,
  
  /// <summary>
  /// NA.
  /// </summary>
  [XmlEnum("NA")]
  NA,
  
}
