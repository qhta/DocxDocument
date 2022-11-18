namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoLocations Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoLocation))]
public interface IGeoLocations // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoLocation.
  /// </summary>
  public IGeoLocation? GeoLocation { get ; set; }
  
}
