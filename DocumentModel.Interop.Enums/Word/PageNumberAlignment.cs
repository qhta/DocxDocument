namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment to apply to page numbers.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpagenumberalignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdPageNumberAlignment))]
public enum PageNumberAlignment
{
  /// <summary>
  /// Left-aligned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageNumberAlignment.wdAlignPageNumberLeft))]
  Left = 0,
  /// <summary>
  /// Centered.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageNumberAlignment.wdAlignPageNumberCenter))]
  Center = 1,
  /// <summary>
  /// Right-aligned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageNumberAlignment.wdAlignPageNumberRight))]
  Right = 2,
  /// <summary>
  /// Left-aligned just inside the footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageNumberAlignment.wdAlignPageNumberInside))]
  Inside = 3,
  /// <summary>
  /// Right-aligned just outside the footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageNumberAlignment.wdAlignPageNumberOutside))]
  Outside = 4
}
