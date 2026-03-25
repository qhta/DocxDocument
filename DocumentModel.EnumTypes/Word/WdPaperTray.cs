namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a printer paper tray.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpapertray?view=office-pia` for Office interop details.
/// </remarks>
public enum WdPaperTray
{
  /// <summary>
  /// Default bin.
  /// </summary>
  DefaultBin = 0,
  /// <summary>
  /// Upper bin.
  /// </summary>
  UpperBin = 1,
  /// <summary>
  /// Printer's only bin.
  /// </summary>
  OnlyBin = 1,
  /// <summary>
  /// Lower bin.
  /// </summary>
  LowerBin = 2,
  /// <summary>
  /// Middle bin.
  /// </summary>
  MiddleBin = 3,
  /// <summary>
  /// Manual feed.
  /// </summary>
  ManualFeed = 4,
  /// <summary>
  /// Envelope feed.
  /// </summary>
  EnvelopeFeed = 5,
  /// <summary>
  /// Manual envelope feed.
  /// </summary>
  ManualEnvelopeFeed = 6,
  /// <summary>
  /// Automatic sheet feed.
  /// </summary>
  AutomaticSheetFeed = 7,
  /// <summary>
  /// Tractor feed.
  /// </summary>
  TractorFeed = 8,
  /// <summary>
  /// Small-format bin.
  /// </summary>
  SmallFormatBin = 9,
  /// <summary>
  /// Large-format bin.
  /// </summary>
  LargeFormatBin = 10,
  /// <summary>
  /// Large-capacity bin.
  /// </summary>
  LargeCapacityBin = 11,
  /// <summary>
  /// Paper cassette.
  /// </summary>
  PaperCassette = 14,
  /// <summary>
  /// Form source.
  /// </summary>
  FormSource = 15
}
