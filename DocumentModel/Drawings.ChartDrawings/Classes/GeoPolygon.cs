namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoPolygon Class.
/// </summary>
public class GeoPolygon: ModelElement
{
  /// <summary>
  ///   polygonId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? PolygonId { get; set; }

  /// <summary>
  ///   numPoints, this property is only available in Office 2016 and later.
  /// </summary>
  public Int64? NumPoints { get; set; }

  /// <summary>
  ///   pcaRings, this property is only available in Office 2016 and later.
  /// </summary>
  public String? PcaRings { get; set; }
}