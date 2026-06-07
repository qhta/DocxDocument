namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies alignment for the content in selected rows.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrowalignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdRowAlignment")]
public enum RowAlignment
{
  /// <summary>
  /// Left aligned. default.
  /// </summary>
  [InteropEnumValue("wdAlignRowLeft")]
  Left = 0,
  /// <summary>
  /// Centered.
  /// </summary>
  [InteropEnumValue("wdAlignRowCenter")]
  Center = 1,
  /// <summary>
  /// Right aligned.
  /// </summary>
  [InteropEnumValue("wdAlignRowRight")]
  Right = 2
}
