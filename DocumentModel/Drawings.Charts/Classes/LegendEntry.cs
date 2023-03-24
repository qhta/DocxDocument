namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Legend Entry.
/// </summary>
public class LegendEntry: ModelElement
{
  /// <summary>
  ///   Index.
  /// </summary>
  public UInt32? Index { get; set; }

  public Boolean? Delete { get; set; }

  public TextProperties? TextProperties { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}