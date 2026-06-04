namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a printer paper tray.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpapertray?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdPaperTray))]
public enum PaperTray
{
  /// <summary>
  /// Default bin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterDefaultBin))]
  DefaultBin = 0,
  /// <summary>
  /// Upper bin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterUpperBin))]
  UpperBin = 1,
  /// <summary>
  /// Printer's only bin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterOnlyBin))]
  OnlyBin = 1,
  /// <summary>
  /// Lower bin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterLowerBin))]
  LowerBin = 2,
  /// <summary>
  /// Middle bin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterMiddleBin))]
  MiddleBin = 3,
  /// <summary>
  /// Manual feed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterManualFeed))]
  ManualFeed = 4,
  /// <summary>
  /// Envelope feed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterEnvelopeFeed))]
  EnvelopeFeed = 5,
  /// <summary>
  /// Manual envelope feed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterManualEnvelopeFeed))]
  ManualEnvelopeFeed = 6,
  /// <summary>
  /// Automatic sheet feed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterAutomaticSheetFeed))]
  AutomaticSheetFeed = 7,
  /// <summary>
  /// Tractor feed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterTractorFeed))]
  TractorFeed = 8,
  /// <summary>
  /// Small-format bin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterSmallFormatBin))]
  SmallFormatBin = 9,
  /// <summary>
  /// Large-format bin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterLargeFormatBin))]
  LargeFormatBin = 10,
  /// <summary>
  /// Large-capacity bin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterLargeCapacityBin))]
  LargeCapacityBin = 11,
  /// <summary>
  /// Paper cassette.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterPaperCassette))]
  PaperCassette = 14,
  /// <summary>
  /// Form source.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperTray.wdPrinterFormSource))]
  FormSource = 15
}
