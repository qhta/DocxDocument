namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoDataEntityQueryResults Class.
/// </summary>
public interface IGeoDataEntityQueryResults // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IGeoDataEntityQueryResult>? GeoDataEntityQueryResults { get ; set; }
  
}
