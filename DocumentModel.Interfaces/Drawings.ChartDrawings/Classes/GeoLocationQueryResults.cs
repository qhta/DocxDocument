namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a collection of geographic location query results cached for map-based chart visualizations.
/// </summary>
/// <remarks>
///   This interface defines a collection of query results that cache geocoded location data retrieved from mapping services or geographic
///   data providers. Each result in the collection pairs a geocoding query specification (<see cref="GeoLocationQuery"/>)
///   with its corresponding location results (<see cref="GeoLocations"/>), enabling efficient cache management and
///   quick retrieval of previously geocoded addresses. The collection is part of the <see cref="Clear"/> structure
///   within <see cref="GeoCache"/>, where it supports offline access to geocoded location data and improves performance
///   by eliminating redundant queries to external mapping services. This caching mechanism is essential for map-based
///   charts that need to convert address data into mappable coordinates and complete location information. The collection
///   enables the chart to maintain multiple cached geocoding results simultaneously, supporting scenarios where maps
///   display data from various addresses, administrative divisions, or postal codes that have been geocoded individually.
///   For example, a sales territory map might cache geocoding results for customer addresses across multiple cities,
///   states, or countries, while a facility location map might cache results for various office or warehouse addresses.
///   By maintaining these cached results, the chart provides immediate conversion of address data to coordinates without
///   requiring repeated network requests, significantly improving user experience and enabling offline map chart viewing.
///   The collection structure also supports cache validation, where new geocoding queries can be compared against cached
///   queries to determine if existing location data is applicable or if new geocoding data needs to be retrieved from
///   the mapping service. This optimization balances data freshness with performance, enabling responsive map chart
///   rendering while minimizing external service dependencies and network traffic. The cached geocoding results include
///   complete location information (coordinates, entity identification, structured addresses) needed for accurate map
///   visualization, supporting features such as point plotting, location-based data aggregation, and geographic filtering.
///   The collection handles scenarios where geocoding queries return multiple locations for ambiguous addresses, storing
///   all potential matches for comprehensive address resolution.
/// </remarks>
public interface GeoLocationQueryResults : IElementCollection<GeoLocationQueryResult>
{
}