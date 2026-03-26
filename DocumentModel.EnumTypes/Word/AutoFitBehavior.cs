namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdautofitbehavior?view=office-pia` for Office interop details.
/// </remarks>
public enum AutoFitBehavior
{
  /// <summary>
  /// The table is set to a fixed size, regardless of the content, and is not automatically sized.
  /// </summary>
  Fixed = 0,
  /// <summary>
  /// The table is automatically sized to fit the content contained in the table.
  /// </summary>
  Content = 1,
  /// <summary>
  /// The table is automatically sized to the width of the active window.
  /// </summary>
  Window = 2
}
