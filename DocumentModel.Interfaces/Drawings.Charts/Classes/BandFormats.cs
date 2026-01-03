namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Band Formats.
/// </summary>
public interface BandFormats: IModelElement
{
  public Collection<BandFormat>? Items { get; set; }
}