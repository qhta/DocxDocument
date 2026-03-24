namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a printer paper tray.
/// </summary>
public enum WdPaperTray
{
  /// <summary>
  /// Default bin.
  /// </summary>
  DefaultBin = unchecked((int)0),
  /// <summary>
  /// Upper bin.
  /// </summary>
  UpperBin = unchecked((int)1),
  /// <summary>
  /// Printer's only bin.
  /// </summary>
  OnlyBin = unchecked((int)1),
  /// <summary>
  /// Lower bin.
  /// </summary>
  LowerBin = unchecked((int)2),
  /// <summary>
  /// Middle bin.
  /// </summary>
  MiddleBin = unchecked((int)3),
  /// <summary>
  /// Manual feed.
  /// </summary>
  ManualFeed = unchecked((int)4),
  /// <summary>
  /// Envelope feed.
  /// </summary>
  EnvelopeFeed = unchecked((int)5),
  /// <summary>
  /// Manual envelope feed.
  /// </summary>
  ManualEnvelopeFeed = unchecked((int)6),
  /// <summary>
  /// Automatic sheet feed.
  /// </summary>
  AutomaticSheetFeed = unchecked((int)7),
  /// <summary>
  /// Tractor feed.
  /// </summary>
  TractorFeed = unchecked((int)8),
  /// <summary>
  /// Small-format bin. [System.Runtime.InteropServices.Guid("57D6BF95-896D-30E5-B0F0-B97327E7C71D")] public enum
  /// WdPaperTray ﾉ Expand table
  /// </summary>
  SmallFormatBin = unchecked((int)9),
  /// <summary>
  /// Large-format bin.
  /// </summary>
  LargeFormatBin = unchecked((int)10),
  /// <summary>
  /// Large-capacity bin.
  /// </summary>
  LargeCapacityBin = unchecked((int)11),
  /// <summary>
  /// Paper cassette.
  /// </summary>
  PaperCassette = unchecked((int)14),
  /// <summary>
  /// Form source.
  /// </summary>
  FormSource = unchecked((int)15)
}
