namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   pivot chart format persistence data.
/// </summary>
public class PivotFormats: ModelElement
{
  public Collection<PivotFormat>? Items { get; set; }
}
