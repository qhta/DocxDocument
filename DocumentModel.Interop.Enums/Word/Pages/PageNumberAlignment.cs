namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment to apply to page numbers.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpagenumberalignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdPageNumberAlignment")]
public enum PageNumberAlignment
{
  /// <summary>
  /// Left-aligned.
  /// </summary>
  [InteropEnumValue("wdAlignPageNumberLeft")]
  Left = 0,
  /// <summary>
  /// Centered.
  /// </summary>
  [InteropEnumValue("wdAlignPageNumberCenter")]
  Center = 1,
  /// <summary>
  /// Right-aligned.
  /// </summary>
  [InteropEnumValue("wdAlignPageNumberRight")]
  Right = 2,
  /// <summary>
  /// Left-aligned just inside the footer.
  /// </summary>
  [InteropEnumValue("wdAlignPageNumberInside")]
  Inside = 3,
  /// <summary>
  /// Right-aligned just outside the footer.
  /// </summary>
  [InteropEnumValue("wdAlignPageNumberOutside")]
  Outside = 4
}
