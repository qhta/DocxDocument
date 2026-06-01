namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the GeoPolygon Class.
/// </summary>
public class GeoPolygon: ModelElement
{
  /// <summary>
  ///   polygonId, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public string? PolygonId { get; set; }

  /// <summary>
  ///   numPoints, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public Int64? NumPoints { get; set; }

  /// <summary>
  ///   pcaRings, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public string? PcaRings { get; set; }
}
