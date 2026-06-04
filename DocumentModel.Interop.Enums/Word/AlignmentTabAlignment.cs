namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies tab alignment.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdalignmenttabalignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdAlignmentTabAlignment))]
public enum AlignmentTabAlignment
{
  /// <summary>
  /// Left-aligned tab.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAlignmentTabAlignment.wdLeft))]
  Left = 0,
  /// <summary>
  /// Centered tab.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAlignmentTabAlignment.wdCenter))]
  Center = 1,
  /// <summary>
  /// Right-aligned tab.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAlignmentTabAlignment.wdRight))]
  Right = 2
}
