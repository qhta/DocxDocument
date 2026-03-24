namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates how to paste copied text.
/// </summary>
public enum WdPasteOptions
{
  /// <summary>
  /// Keeps formatting from the source document. wdMatchDestinationFormatting1 Matches formatting to the destination
  /// document.
  /// </summary>
  KeepSourceFormatting = 0,
  /// <summary>
  /// Indicates how to paste copied text.
  /// </summary>
  MatchDestinationFormatting = 1,
  /// <summary>
  /// Keeps text only, without formatting.
  /// </summary>
  KeepTextOnly = 2,
  /// <summary>
  /// Matches formatting to the destination document using styles for formatting.
  /// </summary>
  UseDestinationStyles = 3
}
