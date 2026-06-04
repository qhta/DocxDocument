namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the formatting to use when pasting the selected table cells.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrecoverytype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRecoveryType))]
public enum RecoveryType
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdPasteDefault))]
  PasteDefault = 0,
  /// <summary>
  /// Pastes a single cell as text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdSingleCellText))]
  SingleCellText = 5,
  /// <summary>
  /// Pastes a single cell table as a separate table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdSingleCellTable))]
  SingleCellTable = 6,
  /// <summary>
  /// Continues numbering of a pasted list from the list in the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdListContinueNumbering))]
  ListContinueNumbering = 7,
  /// <summary>
  /// Restarts numbering of a pasted list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdListRestartNumbering))]
  ListRestartNumbering = 8,
  /// <summary>
  /// Merges pasted cells into an existing table by inserting the pasted rows between the selected rows.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdTableAppendTable))]
  TableAppendTable = 10,
  /// <summary>
  /// Inserts a pasted table as rows between two rows in the target table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdTableInsertAsRows))]
  TableInsertAsRows = 11,
  /// <summary>
  /// Pastes an appended table without merging table styles.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdTableOriginalFormatting))]
  TableOriginalFormatting = 12,
  /// <summary>
  /// Pastes an Excel chart as a picture.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdChartPicture))]
  ChartPicture = 13,
  /// <summary>
  /// Pastes an Excel chart as a picture.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdChart))]
  Chart = 14,
  /// <summary>
  /// Pastes an Excel chart and links it to the original Excel spreadsheet.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdChartLinked))]
  ChartLinked = 15,
  /// <summary>
  /// Preserves original formatting of the pasted material.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdFormatOriginalFormatting))]
  FormatOriginalFormatting = 16,
  /// <summary>
  /// Uses the styles that are in use in the destination document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdUseDestinationStylesRecovery))]
  UseDestinationStylesRecovery = 19,
  /// <summary>
  /// Matches the formatting of the pasted text to the formatting of surrounding text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdFormatSurroundingFormattingWithEmphasis))]
  FormatSurroundingFormattingWithEmphasis = 20,
  /// <summary>
  /// Pastes as plain, unformatted text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdFormatPlainText))]
  FormatPlainText = 22,
  /// <summary>
  /// Pastes table cells and overwrites existing table cells.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdTableOverwriteCells))]
  TableOverwriteCells = 23,
  /// <summary>
  /// Merges a pasted list with neighboring lists.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdListCombineWithExistingList))]
  ListCombineWithExistingList = 24,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRecoveryType.wdListDontMerge))]
  ListDontMerge = 25
}
