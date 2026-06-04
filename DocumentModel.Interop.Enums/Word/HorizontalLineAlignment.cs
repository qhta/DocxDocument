namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of a horizontal line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhorizontallinealignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdHorizontalLineAlignment))]
public enum HorizontalLineAlignment
{
  /// <summary>
  /// Aligned to the left.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHorizontalLineAlignment.wdHorizontalLineAlignLeft))]
  Left = 0,
  /// <summary>
  /// Centered.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHorizontalLineAlignment.wdHorizontalLineAlignCenter))]
  Center = 1,
  /// <summary>
  /// Aligned to the right.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHorizontalLineAlignment.wdHorizontalLineAlignRight))]
  Right = 2
}
