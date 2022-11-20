namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Validation Error Styles
/// </summary>
public enum DataValidationErrorStyleValues
{
  /// <summary>
  /// Stop Icon.
  /// </summary>
  [XmlEnum("stop")]
  Stop,
  
  /// <summary>
  /// Warning Icon.
  /// </summary>
  [XmlEnum("warning")]
  Warning,
  
  /// <summary>
  /// Information Icon.
  /// </summary>
  [XmlEnum("information")]
  Information,
  
}
