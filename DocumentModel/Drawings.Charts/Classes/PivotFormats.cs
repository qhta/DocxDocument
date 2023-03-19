namespace DocumentModel.Drawings.Charts;

/// <summary>
///   pivot chart format persistence data.
/// </summary>
public class PivotFormats: ModelElement
{
  public Collection<PivotFormat>? Items { get; set; }
}