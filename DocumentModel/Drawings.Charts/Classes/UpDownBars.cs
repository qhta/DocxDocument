namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the UpDownBars Class.
/// </summary>
public class UpDownBars: ModelElement
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