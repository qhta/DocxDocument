namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the result of a geographic data entity query, containing both the query specification and retrieved entity data.
/// </summary>
/// <remarks>
///   This interface defines a query result structure that pairs a geographic
///   entity query (<see cref="GeoDataEntityQuery"/>) with its corresponding geographic data (<see cref="GeoData"/>).
///   This structure preserves the association between the query parameters (entity identifier and optional entity type)
///   and the comprehensive geographic information retrieved in response to that query. By maintaining this query-result
///   pairing, the interface enables efficient caching and retrieval of geographic entity data in map-based charts.
///   The query result is stored within the <see cref="Clear"/> structure as part of <see cref="GeoDataEntityQueryResults"/>,
///   which can be cached in <see cref="GeoCache"/> to support offline access and improve performance by eliminating
///   redundant queries to external mapping services. This structure is particularly valuable for map charts that display
///   specific geographic regions with accurate boundaries, where the detailed entity data (including bounding box,
///   boundary polygons, identification, and copyright information) needs to be readily accessible for rendering.
///   By caching query results, the chart can respond immediately to repeated rendering requests or navigation actions
///   without requiring new queries to external services. The query-result pairing also enables query validation and
///   cache management, where cached results can be matched against query parameters to determine if a cached result
///   satisfies a new query or if fresh data needs to be retrieved. This optimization is essential for maintaining
///   responsive map chart rendering while minimizing network traffic and external service dependencies. Common use
///   cases include caching country boundary data for world map visualizations, storing state or province data for
///   regional maps, or maintaining custom geographic entity definitions for specialized domain visualizations. The
///   cached geographic data ensures consistent, accurate rendering of map regions even when offline or when the
///   external mapping service is unavailable.
/// </remarks>
public interface GeoDataEntityQueryResult
{
  /// <summary>
  ///   Gets or sets the query specification that was used to retrieve the geographic entity data.
  /// </summary>
  /// <remarks>
  ///   The query specification preserves the parameters used to retrieve the geographic entity data, including
  ///   the entity identifier and optional entity type that were specified in the original query. This enables
  ///   cache validation by comparing new query parameters against cached queries to determine if a cached result
  ///   is still valid and applicable. For example, if a map chart queries for "US" (United States) with entity
  ///   type "Country", the query specification stores these parameters. When the chart later needs to render the
  ///   same entity, the cached query can be matched against the new request to quickly retrieve the previously
  ///   loaded geographic data without querying the mapping service again. The query specification also provides
  ///   context for understanding the cached data, documenting what was requested and enabling informed decisions
  ///   about cache refresh, expiration, or replacement strategies. This is particularly important for managing
  ///   cached geographic data where the same entity might be queried with different parameters (such as different
  ///   detail levels or coordinate precision), ensuring the cached data matches the specific requirements of the
  ///   current visualization.
  /// </remarks>
  public GeoDataEntityQuery? GeoDataEntityQuery { get; set; }

  /// <summary>
  ///   Gets or sets the comprehensive geographic data retrieved for the queried entity.
  /// </summary>
  /// <remarks>
  ///   The geographic data contains comprehensive information about the queried entity, including its identification
  ///   (name and ID), bounding box coordinates (east, west, north, south), detailed boundary polygons, and copyright
  ///   attributions. This complete data structure enables accurate rendering of the geographic entity on map charts,
  ///   supporting features such as region coloring (choropleth maps), boundary display, geographic selection, and
  ///   spatial analysis. The cached geographic data ensures the chart can render the entity immediately without
  ///   requiring network access to external mapping services, supporting offline viewing and improving performance
  ///   for repeated rendering operations. The data remains associated with its originating query through this pairing,
  ///   ensuring that cached data can be correctly matched to future query requests and enabling efficient cache
  ///   management. The geographic data may include high-detail boundary polygons for accurate visualization or
  ///   simplified polygons for performance optimization, depending on the query parameters and mapping provider
  ///   capabilities. See <see cref="GeoData"/> for details on the structure and content of the geographic entity data.
  /// </remarks>
  public GeoData? GeoData { get; set; }
}