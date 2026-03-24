namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
/// </summary>
public enum WdAutoFitBehavior
{
  /// <summary>
  /// The table is set to a fixed size, regardless of the content, and is not automatically sized. wdAutoFitContent1
  /// The table is automatically sized to fit the content contained in the table. wdAutoFitWindow2 The table is
  /// automatically sized to the width of the active window.
  /// </summary>
  Fixed = unchecked((int)0),
  /// <summary>
  /// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
  /// </summary>
  Content = unchecked((int)1),
  /// <summary>
  /// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
  /// </summary>
  Window = unchecked((int)2)
}
