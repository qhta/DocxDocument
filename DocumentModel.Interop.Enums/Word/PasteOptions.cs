namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates how to paste copied text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpasteoptions?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPasteOptions")]
public enum PasteOptions
{
  /// <summary>
  /// Keeps formatting from the source document.
  /// </summary>
  [WordInteropEnumValue("wdKeepSourceFormatting")]
  KeepSourceFormatting = 0,
  /// <summary>
  /// Matches formatting to the destination document.
  /// </summary>
  [WordInteropEnumValue("wdMatchDestinationFormatting")]
  MatchDestinationFormatting = 1,
  /// <summary>
  /// Keeps text only, without formatting.
  /// </summary>
  [WordInteropEnumValue("wdKeepTextOnly")]
  KeepTextOnly = 2,
  /// <summary>
  /// Matches formatting to the destination document using styles for formatting.
  /// </summary>
  [WordInteropEnumValue("wdUseDestinationStyles")]
  UseDestinationStyles = 3
}
