namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents geographic data for a specific entity including identification, bounding box coordinates, and geometric boundaries.
/// </summary>
/// <remarks>
///   This interface defines comprehensive geographic information for a single
///   geographic entity used in map-based chart visualizations. The geographic data includes entity identification
///   (<see cref="EntityName"/> and <see cref="EntityId"/>), a bounding box defining the entity's geographic extent
///   (<see cref="East"/>, <see cref="West"/>, <see cref="North"/>, <see cref="South"/>), detailed boundary polygons
///   (<see cref="GeoPolygons"/>), and copyright attributions for the geographic data (<see cref="Copyrights"/>).
///   This complete data structure enables accurate rendering of geographic regions on map charts, supporting various
///   visualization scenarios from country-level overviews to detailed regional displays. The entity identification
///   enables correlation between chart data points and their corresponding geographic regions, while the bounding box
///   provides quick spatial reference for positioning and zoom calculations. The detailed polygons define precise
///   boundaries for accurate region rendering, and copyright information ensures proper attribution of geographic data
///   sources. Geographic data instances are typically retrieved from mapping services or geographic data providers
///   (identified in <see cref="GeoCache.Provider"/>) and cached in <see cref="GeoCache"/> for offline access and
///   performance optimization. The data supports various map chart features including region coloring based on data
///   values (choropleth maps), boundary rendering, geographic selection and interaction, and spatial data analysis.
///   The bounding box coordinates use standard geographic coordinate system (latitude/longitude), enabling integration
///   with various mapping and GIS systems. This geographic data structure is fundamental to Office's map chart
///   capabilities, enabling visualization of data in geographic context across countries, states, regions, or custom
///   geographic boundaries.
/// </remarks>
public interface GeoData : IModelElement
{
  /// <summary>
  ///   Gets or sets the human-readable name of the geographic entity.
  /// </summary>
  /// <remarks>
   ///   The entity name provides a human-readable identifier for the geographic region, such as "United States",
  ///   "California", "Tokyo", or "European Union". This name is typically used for display purposes in chart labels,
  ///   tooltips, legends, and other user-facing elements where the geographic entity needs to be identified in a
  ///   way that users can easily understand. The name may be localized based on the document's language settings
  ///   or user preferences, providing appropriate regional naming conventions. The entity name works in conjunction
  ///   with <see cref="EntityId"/> to provide both user-friendly identification and machine-readable referencing
  ///   of geographic entities.
  /// </remarks>
  public string? EntityName { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for the geographic entity.
  /// </summary>
  /// <remarks>
   ///   The entity identifier provides a machine-readable, unique reference for the geographic region that remains
  ///   consistent across different localizations, data updates, and provider versions. Common identifier schemes
  ///   include ISO country codes (e.g., "US", "GB", "JP"), administrative division codes, or provider-specific
  ///   entity identifiers. This ID is used to correlate chart data points with geographic entities, enabling the
  ///   chart to associate data values with the correct regions for visualization. The entity ID is particularly
  ///   important for data binding, where external data sources reference geographic entities by their identifiers
  ///   rather than potentially ambiguous names. The identifier format depends on the geographic data provider
  ///   specified in <see cref="GeoCache.Provider"/>, ensuring consistency with the provider's entity identification
  ///   system.
  /// </remarks>
  public string? EntityId { get; set; }

  /// <summary>
  ///   Gets or sets the eastern longitude boundary of the entity's bounding box.
  /// </summary>
  /// <remarks>
   ///   The eastern longitude defines the rightmost boundary of the geographic entity's extent in the standard
  ///   geographic coordinate system, using decimal degrees where values range from -180 (180°W) to +180 (180°E).
  ///   The bounding box formed by the east, west, north, and south coordinates provides a rectangular approximation
  ///   of the entity's geographic extent, useful for quick spatial calculations such as determining map viewport,
  ///   calculating zoom levels, or performing preliminary spatial queries. The eastern boundary represents the
  ///   maximum longitude value within the entity's boundaries.
  /// </remarks>
  public Double? East { get; set; }

  /// <summary>
  ///   Gets or sets the western longitude boundary of the entity's bounding box.
  /// </summary>
  /// <remarks>
   ///   The western longitude defines the leftmost boundary of the geographic entity's extent in the standard
  ///   geographic coordinate system, using decimal degrees where values range from -180 (180°W) to +180 (180°E).
  ///   The western boundary represents the minimum longitude value within the entity's boundaries. Together with
  ///   the eastern boundary, this defines the horizontal extent of the bounding box used for spatial calculations
  ///   and map positioning.
  /// </remarks>
  public Double? West { get; set; }

  /// <summary>
  ///   Gets or sets the northern latitude boundary of the entity's bounding box.
  /// </summary>
  /// <remarks>
   ///   The northern latitude defines the uppermost boundary of the geographic entity's extent in the standard
  ///   geographic coordinate system, using decimal degrees where values range from -90 (90°S) to +90 (90°N).
  ///   The northern boundary represents the maximum latitude value within the entity's boundaries, defining the
  ///   topmost edge of the bounding box used for spatial reference and map calculations.
  /// </remarks>
  public Double? North { get; set; }

  /// <summary>
  ///   Gets or sets the southern latitude boundary of the entity's bounding box.
  /// </summary>
  /// <remarks>
   ///   The southern latitude defines the lowermost boundary of the geographic entity's extent in the standard
  ///   geographic coordinate system, using decimal degrees where values range from -90 (90°S) to +90 (90°N).
  ///   The southern boundary represents the minimum latitude value within the entity's boundaries. Together with
  ///   the northern boundary, this defines the vertical extent of the bounding box, completing the rectangular
  ///   approximation of the entity's geographic extent.
  /// </remarks>
  public Double? South { get; set; }

  /// <summary>
  ///   Gets or sets the collection of polygons that define the precise geographic boundaries of the entity.
  /// </summary>
  /// <remarks>
  ///   The geographic polygons provide detailed, accurate boundary definitions for the entity, enabling precise
  ///   rendering of the region's shape on map charts. Unlike the bounding box (which provides a simple rectangular
  ///   approximation), the polygons define the actual irregular boundaries of the geographic entity, including
  ///   coastlines, borders, and any interior features such as holes or islands. These polygons are essential for
  ///   accurate map visualization, particularly for choropleth maps where regions are colored based on data values.
  ///   The polygon data may include multiple polygons for entities with disconnected regions (such as archipelagos
  ///   or countries with non-contiguous territories) and can represent boundaries at various levels of detail
  ///   depending on the visualization requirements and data source resolution. The polygons use coordinate pairs
  ///   (latitude/longitude) to define the boundary vertices, enabling accurate geographic representation and
  ///   supporting spatial operations such as point-in-polygon tests for determining which entity contains a
  ///   specific location.
  /// </remarks>
  public GeoPolygons? GeoPolygons { get; set; }

  /// <summary>
  ///   Gets or sets the copyright information for the geographic data.
  /// </summary>
  /// <remarks>
  ///   The copyright information provides proper attribution for the geographic data sources, ensuring legal
  ///   compliance and acknowledging the providers of the boundary data, coordinates, and other geographic
  ///   information. This is particularly important for map-based visualizations that incorporate data from
  ///   commercial mapping services, government geographic databases, or other third-party sources that require
  ///   attribution. The copyright notices may include multiple attributions if the geographic data is derived
  ///   from multiple sources or providers. See <see cref="Copyrights"/> for details on the structure and content
  ///   of copyright attributions.
  /// </remarks>
  public Copyrights? Copyrights { get; set; }
}