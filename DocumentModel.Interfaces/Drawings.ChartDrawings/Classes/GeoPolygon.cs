namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a polygon that defines a portion of a geographic entity's boundary or shape.
/// </summary>
/// <remarks>
///   This interface defines a geometric polygon used to represent the
///   boundaries, coastlines, or other geographic features of a map entity. Geographic polygons are essential for
///   accurate rendering of region shapes in map-based charts, enabling precise visualization of countries, states,
///   counties, and other geographic entities with their actual irregular boundaries rather than simplified geometric
///   approximations. Each polygon consists of a series of coordinate points that define its perimeter, stored in a
///   compressed or encoded format (<see cref="PcaRings"/>) for efficient storage and transmission. The polygon may
///   represent a complete entity boundary or a portion of it, with complex entities often requiring multiple polygons
///   to accurately represent features such as disconnected territories (archipelagos), interior features (lakes, holes),
///   or different boundary components. Polygons are used within <see cref="GeoPolygons"/> collections in <see cref="GeoData"/>
///   to define complete entity shapes. The polygon structure supports various levels of detail, from simplified low-resolution
///   boundaries for overview maps to high-resolution boundaries for detailed visualizations. The coordinate points defining
///   the polygon typically use latitude/longitude pairs in the geographic coordinate system, enabling accurate positioning
///   and rendering on map projections. Geographic polygons enable map chart features including region coloring (choropleth
///   maps where regions are filled with colors based on data values), boundary rendering, point-in-polygon tests (determining
///   which region contains a specific coordinate), and spatial operations (calculating areas, testing overlaps, or measuring
///   distances). The polygon identifier enables tracking and referencing specific boundary components, while the point count
///   provides information about the polygon's complexity and detail level.
/// </remarks>
public interface GeoPolygon
{
  /// <summary>
  ///   Gets or sets the unique identifier for this polygon within the entity's boundary definition.
  /// </summary>
  /// <remarks>
   ///   The polygon identifier enables tracking and referencing of specific boundary components within a geographic
  ///   entity's complete boundary definition. When an entity has multiple polygons (such as a country with islands,
  ///   or a region with interior holes like lakes), each polygon can be uniquely identified for management, updates,
  ///   or selective rendering. The identifier is particularly valuable for complex geographic entities where boundary
  ///   components need to be individually addressed, such as updating specific coastline segments, referencing particular
  ///   territorial components, or managing different boundary detail levels. The identifier format depends on the
  ///   geographic data provider and may follow provider-specific conventions for polygon referencing.
  /// </remarks>
  public string? PolygonId { get; set; }

  /// <summary>
  ///   Gets or sets the number of coordinate points that define this polygon's boundary.
  /// </summary>
  /// <remarks>
   ///   The number of points indicates the complexity and detail level of the polygon boundary. Higher point counts
  ///   provide more detailed, accurate boundary representations with smoother curves and finer features, but require
  ///   more storage space and processing time. Lower point counts create simplified boundaries suitable for overview
  ///   maps or performance-critical scenarios where extreme precision is not required. For example, a simplified country
  ///   boundary might use hundreds of points for broad shape recognition, while a detailed coastline representation
  ///   might use thousands or tens of thousands of points to accurately capture inlets, peninsulas, and coastal features.
  ///   The point count helps applications make informed decisions about which polygon detail level to use based on
  ///   the current zoom level, available memory, or performance requirements. Understanding the point count also aids
  ///   in estimating rendering performance and memory usage for map visualizations.
  /// </remarks>
  public Int64? NumPoints { get; set; }

  /// <summary>
  ///   Gets or sets the encoded coordinate data representing the polygon's rings (outer boundary and any holes).
  /// </summary>
  /// <remarks>
   ///   The pcaRings (Principal Component Analysis rings) contains the polygon's coordinate data in an encoded or compressed
  ///   format for efficient storage and transmission. A polygon ring is a closed sequence of coordinate points (latitude/longitude
  ///   pairs) that defines a boundary. The data typically includes the outer ring (the polygon's perimeter) and potentially
  ///   interior rings representing holes (such as lakes within a landmass, or enclaves). The encoding format depends on
  ///   the geographic data provider specified in <see cref="GeoCache.Provider"/> and may use compression techniques,
  ///   delta encoding, or other optimization methods to reduce data size while preserving boundary accuracy. When rendering
  ///   the polygon, this encoded data is decoded into coordinate sequences that can be plotted on the map using the
  ///   appropriate projection specified in <see cref="Geography.ProjectionType"/>. The ring structure follows standard
  ///   polygon conventions where the outer ring defines the filled area and interior rings define exclusions (holes).
  ///   The coordinate precision and encoding method balance accuracy requirements with storage efficiency, enabling
  ///   practical storage of detailed geographic boundaries within document files while maintaining reasonable file sizes.
  /// </remarks>
  public string? PcaRings { get; set; }
}