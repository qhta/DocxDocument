namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a polygon that defines a portion of a geographic entity's boundary or shape.
/// </summary>
/// <remarks>
///   This class defines a geometric polygon used to represent the
///   boundaries, coastlines, or other geographic features of a map entity. Geographic polygons are essential for
///   accurate rendering of region shapes in map-based charts, enabling precise visualization of countries, states,
///   counties, and other geographic entities with their actual irregular boundaries rather than simplified geometric
///   approximations. Each polygon consists of a series of coordinate points that define its perimeter, stored in a
///   compressed or encoded format (<see cref = "PcaRings"/>) for efficient storage and transmission. The polygon may
///   represent a complete entity boundary or a portion of it, with complex entities often requiring multiple polygons
///   to accurately represent features such as disconnected territories (archipelagos), interior features (lakes, holes),
///   or different boundary components. Polygons are used within <see cref = "GeoPolygons"/> collections in <see cref = "GeoData"/>
///   to define complete entity shapes. The polygon structure supports various levels of detail, from simplified low-resolution
///   boundaries for overview maps to high-resolution boundaries for detailed visualizations. The coordinate points defining
///   the polygon typically use latitude/longitude pairs in the geographic coordinate system, enabling accurate positioning
///   and rendering on map projections. Geographic polygons enable map chart features including region coloring (choropleth
///   maps where regions are filled with colors based on data values), boundary rendering, point-in-polygon tests (determining
///   which region contains a specific coordinate), and spatial operations (calculating areas, testing overlaps, or measuring
///   distances). The polygon identifier enables tracking and referencing specific boundary components, while the point count
///   provides information about the polygon's complexity and detail level.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoPolygon))]
[DataContract]
[XmlRoot("GeoPolygon", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class GeoPolygon: ModelElement<DXO16DCD.GeoPolygon>
{
  /// <summary>
  /// Specifies the polygon id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoPolygon.PolygonId))]
  public string? PolygonId
  {
    get => _PolygonId ??= GetProperty<string?>(GetUpdatableElement()?.PolygonId);
    set => UpdateField(ref _PolygonId, value, nameof(PolygonId));
  }

  private string? _PolygonId;

  /// <summary>
  /// Specifies the num points.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoPolygon.NumPoints))]
  public Int64? NumPoints
  {
    get => _NumPoints ??= GetProperty<Int64?>(GetUpdatableElement()?.NumPoints);
    set => UpdateField(ref _NumPoints, value, nameof(NumPoints));
  }

  private Int64? _NumPoints;

  /// <summary>
  /// Specifies the pca rings.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoPolygon.PcaRings))]
  public string? PcaRings
  {
    get => _PcaRings ??= GetProperty<string?>(GetUpdatableElement()?.PcaRings);
    set => UpdateField(ref _PcaRings, value, nameof(PcaRings));
  }

  private string? _PcaRings;
}