namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of a horizontal line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhorizontallinealignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdHorizontalLineAlignment")]
public enum HorizontalLineAlignment
{
  /// <summary>
  /// Aligned to the left.
  /// </summary>
  [InteropEnumValue("wdHorizontalLineAlignLeft")]
  Left = 0,
  /// <summary>
  /// Centered.
  /// </summary>
  [InteropEnumValue("wdHorizontalLineAlignCenter")]
  Center = 1,
  /// <summary>
  /// Aligned to the right.
  /// </summary>
  [InteropEnumValue("wdHorizontalLineAlignRight")]
  Right = 2
}
