namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoLocationQueryResults Class.
/// </summary>
public interface IGeoLocationQueryResults // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IGeoLocationQueryResult>? GeoLocationQueryResults { get ; set; }
  
}
