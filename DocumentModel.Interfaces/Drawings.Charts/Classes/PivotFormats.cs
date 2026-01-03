namespace DocumentModel.Drawings.Charts;

/// <summary>
///   pivot chart format persistence data.
/// </summary>
public interface PivotFormats: IModelElement
{
  public Collection<PivotFormat>? Items { get; set; }
}