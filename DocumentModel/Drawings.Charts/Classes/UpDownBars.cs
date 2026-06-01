namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
  public IUpBars? IUpBars { get; set; }

  /// <summary>
  ///   Down Bars.
  /// </summary>
  public IDownBars? IDownBars { get; set; }

  /// <summary>
  ///   IChart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
