namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a printer paper tray.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpapertray?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdPaperTray")]
public enum PaperTray
{
  /// <summary>
  /// Default bin.
  /// </summary>
  [InteropEnumValue("wdPrinterDefaultBin")]
  DefaultBin = 0,
  /// <summary>
  /// Upper bin.
  /// </summary>
  [InteropEnumValue("wdPrinterUpperBin")]
  UpperBin = 1,
  /// <summary>
  /// Printer's only bin.
  /// </summary>
  [InteropEnumValue("wdPrinterOnlyBin")]
  OnlyBin = 1,
  /// <summary>
  /// Lower bin.
  /// </summary>
  [InteropEnumValue("wdPrinterLowerBin")]
  LowerBin = 2,
  /// <summary>
  /// Middle bin.
  /// </summary>
  [InteropEnumValue("wdPrinterMiddleBin")]
  MiddleBin = 3,
  /// <summary>
  /// Manual feed.
  /// </summary>
  [InteropEnumValue("wdPrinterManualFeed")]
  ManualFeed = 4,
  /// <summary>
  /// Envelope feed.
  /// </summary>
  [InteropEnumValue("wdPrinterEnvelopeFeed")]
  EnvelopeFeed = 5,
  /// <summary>
  /// Manual envelope feed.
  /// </summary>
  [InteropEnumValue("wdPrinterManualEnvelopeFeed")]
  ManualEnvelopeFeed = 6,
  /// <summary>
  /// Automatic sheet feed.
  /// </summary>
  [InteropEnumValue("wdPrinterAutomaticSheetFeed")]
  AutomaticSheetFeed = 7,
  /// <summary>
  /// Tractor feed.
  /// </summary>
  [InteropEnumValue("wdPrinterTractorFeed")]
  TractorFeed = 8,
  /// <summary>
  /// Small-format bin.
  /// </summary>
  [InteropEnumValue("wdPrinterSmallFormatBin")]
  SmallFormatBin = 9,
  /// <summary>
  /// Large-format bin.
  /// </summary>
  [InteropEnumValue("wdPrinterLargeFormatBin")]
  LargeFormatBin = 10,
  /// <summary>
  /// Large-capacity bin.
  /// </summary>
  [InteropEnumValue("wdPrinterLargeCapacityBin")]
  LargeCapacityBin = 11,
  /// <summary>
  /// Paper cassette.
  /// </summary>
  [InteropEnumValue("wdPrinterPaperCassette")]
  PaperCassette = 14,
  /// <summary>
  /// Form source.
  /// </summary>
  [InteropEnumValue("wdPrinterFormSource")]
  FormSource = 15
}
