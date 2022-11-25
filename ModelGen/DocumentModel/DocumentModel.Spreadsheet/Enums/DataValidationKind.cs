namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Validation Type
/// </summary>
public enum DataValidationKind
{
  /// <summary>
  /// None.
  /// </summary>
  None,
  
  /// <summary>
  /// Whole Number.
  /// </summary>
  Whole,
  
  /// <summary>
  /// Decimal.
  /// </summary>
  Decimal,
  
  /// <summary>
  /// List.
  /// </summary>
  List,
  
  /// <summary>
  /// Date.
  /// </summary>
  Date,
  
  /// <summary>
  /// Time.
  /// </summary>
  Time,
  
  /// <summary>
  /// Text Length.
  /// </summary>
  TextLength,
  
  /// <summary>
  /// Custom.
  /// </summary>
  Custom,
  
}
