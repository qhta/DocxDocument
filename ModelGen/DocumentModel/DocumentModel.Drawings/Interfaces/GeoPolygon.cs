namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoPolygon Class.
/// </summary>
public interface GeoPolygon
{
  /// <summary>
  /// polygonId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? PolygonId { get ; set; }
  
  /// <summary>
  /// numPoints, this property is only available in Office 2016 and later.
  /// </summary>
  public Int32? NumPoints { get ; set; }
  
  /// <summary>
  /// pcaRings, this property is only available in Office 2016 and later.
  /// </summary>
  public String? PcaRings { get ; set; }
  
}
