namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the formatting to use when pasting the selected table cells.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrecoverytype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRecoveryType
{
  /// <summary>
  /// Not supported.
  /// </summary>
  PasteDefault = 0,
  /// <summary>
  /// Pastes a single cell as text.
  /// </summary>
  SingleCellText = 5,
  /// <summary>
  /// Pastes a single cell table as a separate table.
  /// </summary>
  SingleCellTable = 6,
  /// <summary>
  /// Continues numbering of a pasted list from the list in the document.
  /// </summary>
  ListContinueNumbering = 7,
  /// <summary>
  /// Restarts numbering of a pasted list.
  /// </summary>
  ListRestartNumbering = 8,
  /// <summary>
  /// Merges pasted cells into an existing table by inserting the pasted rows between the selected rows.
  /// </summary>
  TableAppendTable = 10,
  /// <summary>
  /// Inserts a pasted table as rows between two rows in the target table.
  /// </summary>
  TableInsertAsRows = 11,
  /// <summary>
  /// Pastes an appended table without merging table styles.
  /// </summary>
  TableOriginalFormatting = 12,
  /// <summary>
  /// Pastes an Excel chart as a picture.
  /// </summary>
  ChartPicture = 13,
  /// <summary>
  /// Pastes a Microsoft Excel chart as an embedded OLE object.
  /// </summary>
  Chart = 14,
  /// <summary>
  /// Pastes an Excel chart and links it to the original Excel spreadsheet.
  /// </summary>
  ChartLinked = 15,
  /// <summary>
  /// Preserves original formatting of the pasted material.
  /// </summary>
  FormatOriginalFormatting = 16,
  /// <summary>
  /// Uses the styles that are in use in the destination document.
  /// </summary>
  UseDestinationStylesRecovery = 19,
  /// <summary>
  /// Matches the formatting of the pasted text to the formatting of surrounding text.
  /// </summary>
  FormatSurroundingFormattingWithEmphasis = 20,
  /// <summary>
  /// Pastes as plain, unformatted text.
  /// </summary>
  FormatPlainText = 22,
  /// <summary>
  /// Pastes table cells and overwrites existing table cells.
  /// </summary>
  TableOverwriteCells = 23,
  /// <summary>
  /// Merges a pasted list with neighboring lists.
  /// </summary>
  ListCombineWithExistingList = 24,
  /// <summary>
  /// Not supported.
  /// </summary>
  ListDontMerge = 25
}
