namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word resizes a table when the AutoFit feature is used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdautofitbehavior?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdAutoFitBehavior")]
public enum AutoFitBehavior
{
  /// <summary>
  /// The table is set to a fixed size, regardless of the content, and is not automatically sized.
  /// </summary>
  [InteropEnumValue("wdAutoFitFixed")]
  Fixed = 0,
  /// <summary>
  /// The table is automatically sized to fit the content contained in the table.
  /// </summary>
  [InteropEnumValue("wdAutoFitContent")]
  Content = 1,
  /// <summary>
  /// The table is automatically sized to the width of the active window.
  /// </summary>
  [InteropEnumValue("wdAutoFitWindow")]
  Window = 2
}
