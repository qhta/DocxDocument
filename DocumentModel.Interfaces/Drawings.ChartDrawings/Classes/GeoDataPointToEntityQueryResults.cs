namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a collection of data point-to-entity mapping query results cached for map-based chart visualizations.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a collection of query results that cache
///   data point-to-entity mappings retrieved from mapping services or geographic data providers. Each result in
///   the collection contains both coordinate-based (<see cref="GeoDataPointQuery"/>) and entity-based
///   (<see cref="GeoDataPointToEntityQuery"/>) query specifications, enabling flexible caching strategies that
///   support multiple approaches to associating data points with geographic entities. The collection is part of
///   the <see cref="Clear"/> structure within <see cref="GeoCache"/>, where it supports offline access to
///   point-to-entity mappings and improves performance by eliminating redundant queries to external mapping services.
///   This caching mechanism is essential for map-based charts that need to associate data points with geographic
///   regions, whether the data points are specified by coordinates (requiring reverse geocoding) or by entity
///   identifiers (requiring direct entity lookup). The collection enables the chart to maintain multiple cached
///   mapping results simultaneously, supporting scenarios where charts display data from mixed sources with varying
///   geographic reference formats. For example, a sales visualization might cache mappings for data points specified
///   by customer coordinates (reverse geocoded to countries/regions) alongside mappings for data points labeled with
///   explicit country codes. By maintaining these cached results, the chart provides immediate data-to-geography
///   association without requiring repeated network requests, significantly improving user experience and enabling
///   offline map chart functionality. The collection structure also supports cache validation, where new mapping
///   requests can be compared against cached queries to determine if existing results are applicable or if new
///   data needs to be retrieved from the mapping service. This optimization balances data freshness with performance,
///   enabling responsive map chart rendering while minimizing external service dependencies and network traffic.
///   The dual-query caching approach ensures efficient cache utilization regardless of whether geographic associations
///   are specified by coordinates or entity identifiers, providing comprehensive support for diverse data sources
///   and mapping requirements.
/// </remarks>
public interface GeoDataPointToEntityQueryResults : IElementCollection<GeoDataPointToEntityQueryResult>
{
}