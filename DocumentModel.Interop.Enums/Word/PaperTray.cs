namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a printer paper tray.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpapertray?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPaperTray")]
public enum PaperTray
{
  /// <summary>
  /// Default bin.
  /// </summary>
  [WordInteropEnumValue("wdPrinterDefaultBin")]
  DefaultBin = 0,
  /// <summary>
  /// Upper bin.
  /// </summary>
  [WordInteropEnumValue("wdPrinterUpperBin")]
  UpperBin = 1,
  /// <summary>
  /// Printer's only bin.
  /// </summary>
  [WordInteropEnumValue("wdPrinterOnlyBin")]
  OnlyBin = 1,
  /// <summary>
  /// Lower bin.
  /// </summary>
  [WordInteropEnumValue("wdPrinterLowerBin")]
  LowerBin = 2,
  /// <summary>
  /// Middle bin.
  /// </summary>
  [WordInteropEnumValue("wdPrinterMiddleBin")]
  MiddleBin = 3,
  /// <summary>
  /// Manual feed.
  /// </summary>
  [WordInteropEnumValue("wdPrinterManualFeed")]
  ManualFeed = 4,
  /// <summary>
  /// Envelope feed.
  /// </summary>
  [WordInteropEnumValue("wdPrinterEnvelopeFeed")]
  EnvelopeFeed = 5,
  /// <summary>
  /// Manual envelope feed.
  /// </summary>
  [WordInteropEnumValue("wdPrinterManualEnvelopeFeed")]
  ManualEnvelopeFeed = 6,
  /// <summary>
  /// Automatic sheet feed.
  /// </summary>
  [WordInteropEnumValue("wdPrinterAutomaticSheetFeed")]
  AutomaticSheetFeed = 7,
  /// <summary>
  /// Tractor feed.
  /// </summary>
  [WordInteropEnumValue("wdPrinterTractorFeed")]
  TractorFeed = 8,
  /// <summary>
  /// Small-format bin.
  /// </summary>
  [WordInteropEnumValue("wdPrinterSmallFormatBin")]
  SmallFormatBin = 9,
  /// <summary>
  /// Large-format bin.
  /// </summary>
  [WordInteropEnumValue("wdPrinterLargeFormatBin")]
  LargeFormatBin = 10,
  /// <summary>
  /// Large-capacity bin.
  /// </summary>
  [WordInteropEnumValue("wdPrinterLargeCapacityBin")]
  LargeCapacityBin = 11,
  /// <summary>
  /// Paper cassette.
  /// </summary>
  [WordInteropEnumValue("wdPrinterPaperCassette")]
  PaperCassette = 14,
  /// <summary>
  /// Form source.
  /// </summary>
  [WordInteropEnumValue("wdPrinterFormSource")]
  FormSource = 15
}
