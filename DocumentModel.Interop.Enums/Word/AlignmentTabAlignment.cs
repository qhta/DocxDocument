namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies tab alignment.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdalignmenttabalignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdAlignmentTabAlignment")]
public enum AlignmentTabAlignment
{
  /// <summary>
  /// Left-aligned tab.
  /// </summary>
  [InteropEnumValue("wdLeft")]
  Left = 0,
  /// <summary>
  /// Centered tab.
  /// </summary>
  [InteropEnumValue("wdCenter")]
  Center = 1,
  /// <summary>
  /// Right-aligned tab.
  /// </summary>
  [InteropEnumValue("wdRight")]
  Right = 2
}
