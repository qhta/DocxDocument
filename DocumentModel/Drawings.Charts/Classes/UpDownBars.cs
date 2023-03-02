namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the UpDownBars Class.
/// </summary>
public record UpDownBars
{
  /// <summary>
  ///   Gap Width.
  /// </summary>
  public UInt16? GapWidth { get; set; }

  /// <summary>
  ///   Up Bars.
  /// </summary>
  public UpBars? UpBars { get; set; }

  /// <summary>
  ///   Down Bars.
  /// </summary>
  public DownBars? DownBars { get; set; }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}