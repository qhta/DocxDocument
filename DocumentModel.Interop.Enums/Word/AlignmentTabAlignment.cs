namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies tab alignment.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdalignmenttabalignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdAlignmentTabAlignment")]
public enum AlignmentTabAlignment
{
  /// <summary>
  /// Left-aligned tab.
  /// </summary>
  [WordInteropEnumValue("wdLeft")]
  Left = 0,
  /// <summary>
  /// Centered tab.
  /// </summary>
  [WordInteropEnumValue("wdCenter")]
  Center = 1,
  /// <summary>
  /// Right-aligned tab.
  /// </summary>
  [WordInteropEnumValue("wdRight")]
  Right = 2
}
