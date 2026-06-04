namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates how to paste copied text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpasteoptions?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdPasteOptions")]
public enum PasteOptions
{
  /// <summary>
  /// Keeps formatting from the source document.
  /// </summary>
  [InteropEnumValue("wdKeepSourceFormatting")]
  KeepSourceFormatting = 0,
  /// <summary>
  /// Matches formatting to the destination document.
  /// </summary>
  [InteropEnumValue("wdMatchDestinationFormatting")]
  MatchDestinationFormatting = 1,
  /// <summary>
  /// Keeps text only, without formatting.
  /// </summary>
  [InteropEnumValue("wdKeepTextOnly")]
  KeepTextOnly = 2,
  /// <summary>
  /// Matches formatting to the destination document using styles for formatting.
  /// </summary>
  [InteropEnumValue("wdUseDestinationStyles")]
  UseDestinationStyles = 3
}
