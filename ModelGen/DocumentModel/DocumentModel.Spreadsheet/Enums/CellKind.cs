namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Type
/// </summary>
public enum CellKind
{
  /// <summary>
  /// Boolean.
  /// </summary>
  Boolean,
  
  /// <summary>
  /// Number.
  /// </summary>
  Number,
  
  /// <summary>
  /// Error.
  /// </summary>
  Error,
  
  /// <summary>
  /// Shared String.
  /// </summary>
  SharedString,
  
  /// <summary>
  /// String.
  /// </summary>
  String,
  
  /// <summary>
  /// Inline String.
  /// </summary>
  InlineString,
  
  /// <summary>
  /// d.
  /// </summary>
  Date,
  
}
