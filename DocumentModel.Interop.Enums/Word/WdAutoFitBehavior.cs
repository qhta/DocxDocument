namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdautofitbehavior?view=office-pia` for Office interop details.
/// </remarks>
public enum WdAutoFitBehavior
{
  /// <summary>
  /// The table is set to a fixed size, regardless of the content, and is not automatically sized. wdAutoFitContent1
  /// The table is automatically sized to fit the content contained in the table. wdAutoFitWindow2 The table is
  /// automatically sized to the width of the active window.
  /// </summary>
  Fixed = 0,
  /// <summary>
  /// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
  /// </summary>
  Content = 1,
  /// <summary>
  /// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
  /// </summary>
  Window = 2
}
