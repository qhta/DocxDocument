namespace DocumentModel.Drawings.Charts;

/// <summary>
///   pivot chart format persistence data.
/// </summary>
public record PivotFormats
{
  public Collection<PivotFormat>? Items { get; set; }
}