namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the formatting to use when pasting the selected table cells.
/// </summary>
public enum WdRecoveryType
{
  /// <summary>
  /// Not supported.
  /// </summary>
  wdPasteDefault = unchecked((int)0),
  /// <summary>
  /// Pastes a single cell as text.
  /// </summary>
  wdSingleCellText = unchecked((int)5),
  /// <summary>
  /// Pastes a single cell table as a separate table.
  /// </summary>
  wdSingleCellTable = unchecked((int)6),
  /// <summary>
  /// Continues numbering of a pasted list from the list in the document.
  /// </summary>
  wdListContinueNumbering = unchecked((int)7),
  /// <summary>
  /// Restarts numbering of a pasted list.
  /// </summary>
  wdListRestartNumbering = unchecked((int)8),
  /// <summary>
  /// Merges pasted cells into an existing table by inserting the pasted rows between the selected rows.
  /// </summary>
  wdTableAppendTable = unchecked((int)10),
  /// <summary>
  /// Inserts a pasted table as rows between two rows in the target table.
  /// </summary>
  wdTableInsertAsRows = unchecked((int)11),
  /// <summary>
  /// Pastes an appended table without merging table styles.
  /// [System.Runtime.InteropServices.Guid("CD2C303A-F5BB-3414-A740-57FB0618169A")] public enum WdRecoveryType ﾉ
  /// Expand table
  /// </summary>
  wdTableOriginalFormatting = unchecked((int)12),
  /// <summary>
  /// Pastes an Excel chart as a picture.
  /// </summary>
  wdChartPicture = unchecked((int)13),
  /// <summary>
  /// Pastes a Microsoft Excel chart as an embedded OLE object.
  /// </summary>
  wdChart = unchecked((int)14),
  /// <summary>
  /// Pastes an Excel chart and links it to the original Excel spreadsheet.
  /// </summary>
  wdChartLinked = unchecked((int)15),
  /// <summary>
  /// Preserves original formatting of the pasted material.
  /// </summary>
  wdFormatOriginalFormatting = unchecked((int)16),
  /// <summary>
  /// Uses the styles that are in use in the destination document. wdFormatSurroundingFormattingWithEmphasis20
  /// Matches the formatting of the pasted text to the formatting of surrounding text.
  /// </summary>
  wdUseDestinationStylesRecovery = unchecked((int)19),
  /// <summary>
  /// Specifies the formatting to use when pasting the selected table cells.
  /// </summary>
  wdFormatSurroundingFormattingWithEmphasis = unchecked((int)20),
  /// <summary>
  /// Pastes as plain, unformatted text.
  /// </summary>
  wdFormatPlainText = unchecked((int)22),
  /// <summary>
  /// Pastes table cells and overwrites existing table cells.
  /// </summary>
  wdTableOverwriteCells = unchecked((int)23),
  /// <summary>
  /// Merges a pasted list with neighboring lists.
  /// </summary>
  wdListCombineWithExistingList = unchecked((int)24),
  /// <summary>
  /// Not supported.
  /// </summary>
  wdListDontMerge = unchecked((int)25)
}
