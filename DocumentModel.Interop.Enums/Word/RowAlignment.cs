namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies alignment for the content in selected rows.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrowalignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdRowAlignment")]
public enum RowAlignment
{
  /// <summary>
  /// Left aligned. default.
  /// </summary>
  [WordInteropEnumValue("wdAlignRowLeft")]
  Left = 0,
  /// <summary>
  /// Centered.
  /// </summary>
  [WordInteropEnumValue("wdAlignRowCenter")]
  Center = 1,
  /// <summary>
  /// Right aligned.
  /// </summary>
  [WordInteropEnumValue("wdAlignRowRight")]
  Right = 2
}
