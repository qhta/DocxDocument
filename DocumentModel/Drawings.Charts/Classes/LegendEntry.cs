namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   ILegend Entry.
/// </summary>
public class ILegendEntry: ModelElement
{
  /// <summary>
  ///   IIndex.
  /// </summary>
  public UInt32? IIndex { get; set; }

  public bool? Delete { get; set; }

  public TextProperties? TextProperties { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}
