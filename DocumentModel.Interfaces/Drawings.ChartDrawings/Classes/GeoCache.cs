namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a cache of geographic data query results used for map-based chart visualizations.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a geographic data cache that stores the results
///   of geographic queries to improve performance and enable offline access to map-based chart features. The GeoCache
///   serves as a local repository of geographic information retrieved from mapping services or geographic data providers,
///   reducing the need for repeated network requests and enabling charts to render quickly with previously retrieved
///   data. This caching mechanism is essential for map charts and geographic visualizations that display data by
///   country, state, region, or custom geographic boundaries. The cache contains binary-encoded geographic data
///   (<see cref="XsdBase64Binary"/>) from a specific geographic data provider (<see cref="Provider"/>), along with
///   structured query results (<see cref="Clear"/>) that include location information, entity definitions, and
///   geographic relationships. By caching geographic data locally within the document, charts can display map-based
///   visualizations without requiring active internet connectivity or repeated calls to external mapping services.
///   This is particularly valuable for presentations, reports, or documents that need to work offline, in restricted
///   network environments, or when consistent geographic data representation is required across multiple document
///   openings. The cached data ensures geographic accuracy and visual consistency even when the original mapping
///   service is unavailable or has updated its data. The cache can be refreshed when connectivity is available to
///   incorporate updated geographic information, boundary changes, or new location data while preserving the ability
///   to render the chart using cached data when updates aren't possible.
/// </remarks>
public interface GeoCache : IModelElement
{
  /// <summary>
  ///   Gets or sets the identifier of the geographic data provider that supplied the cached data.
  /// </summary>
  /// <remarks>
   ///   The provider identifier specifies which geographic data service or mapping provider was used to retrieve
  ///   the cached geographic information. This enables Office to understand the source and format of the cached
  ///   data, apply appropriate processing and rendering logic, and potentially refresh the cache using the same
  ///   provider when updates are needed. Different providers may use different geographic data formats, coordinate
  ///   systems, boundary definitions, or location hierarchies, so identifying the provider ensures the cached data
  ///   is interpreted correctly. Common providers might include Microsoft's own mapping services, Bing Maps, or
  ///   other geographic data services that Office integrates with for map chart functionality.
  /// </remarks>
  public string? Provider { get; set; }

  /// <summary>
  ///   Gets or sets the binary-encoded geographic data cached from the provider.
  /// </summary>
  /// <remarks>
  ///   The binary data contains the raw geographic information retrieved from the mapping provider, encoded in
  ///   base64 format for storage within the XML document structure. This data may include geographic boundaries,
  ///   coordinate information, location metadata, map tiles, or other geographic elements needed to render map-based
  ///   charts. The base64 encoding enables binary geographic data (which may include images, compressed data, or
  ///   proprietary formats) to be embedded within the text-based XML document structure. The cached binary data
  ///   ensures that map charts can be rendered without requiring access to the original geographic data provider,
  ///   supporting offline viewing and consistent visualization across different environments. The size and content
  ///   of the binary data depend on the complexity of the geographic visualization, the number of locations involved,
  ///   and the level of detail required for the map chart.
  /// </remarks>
  public string? XsdBase64Binary { get; set; }

  /// <summary>
  ///   Gets or sets the structured geographic query results cached for this chart.
  /// </summary>
  /// <remarks>
  ///   The Clear object provides structured access to the various types of geographic query results cached for
  ///   the chart, including location queries (coordinates and addresses), data entity queries (geographic regions
  ///   and their properties), point-to-entity mappings (associating data points with geographic entities), and
  ///   hierarchical relationships (parent and child entities for drill-down navigation). This structured cache
  ///   enables efficient access to specific types of geographic information without requiring parsing of the raw
  ///   binary data, supporting fast chart rendering and interactive geographic features. The structured results
  ///   complement the <see cref="XsdBase64Binary"/> data by providing organized, queryable geographic information
  ///   that the chart rendering engine can directly access. See <see cref="Clear"/> for details on the types of
  ///   geographic query results included in the cache.
  /// </remarks>
  public Clear? Clear { get; set; }
}