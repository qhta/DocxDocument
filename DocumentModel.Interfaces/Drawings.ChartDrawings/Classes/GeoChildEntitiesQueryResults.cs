namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a collection of geographic child entities query results cached for map-based chart visualizations.
/// </summary>
/// <remarks>
///   This interface defines a collection of query results that cache
///   geographic child entity data retrieved from mapping services or geographic data providers. Each result in
///   the collection pairs a query specification (<see cref="GeoChildEntitiesQuery"/>) with its corresponding
///   child entities data (<see cref="GeoChildEntities"/>), enabling efficient cache management and quick retrieval
///   of previously queried geographic hierarchies. The collection is part of the <see cref="Clear"/> structure
///   within <see cref="GeoCache"/>, where it supports offline access to hierarchical geographic relationships and
///   improves performance by eliminating redundant queries to external mapping services. This caching mechanism is
///   essential for interactive map charts that support drill-down navigation, where users explore geographic
///   hierarchies by selecting parent regions to reveal their child entities (such as drilling from countries to
///   states, or from states to counties). The collection enables the chart to maintain multiple cached query results
///   simultaneously, supporting scenarios where users navigate through different branches of the geographic hierarchy
///   or return to previously explored levels. For example, the collection might cache results for drilling down into
///   multiple countries, each with its own set of states or provinces, or cache county-level data for multiple states
///   that users have explored. By maintaining these cached results, the chart provides immediate response to navigation
///   actions without requiring repeated network requests, significantly improving user experience in geographic
///   visualizations. The collection structure also supports cache validation, where new queries can be compared
///   against cached queries to determine if existing results are applicable or if new data needs to be retrieved.
///   This optimization balances data freshness with performance, enabling responsive map chart interactions while
///   minimizing external service dependencies and network traffic.
/// </remarks>
public interface GeoChildEntitiesQueryResults : IElementCollection<GeoChildEntitiesQueryResult>
{
}