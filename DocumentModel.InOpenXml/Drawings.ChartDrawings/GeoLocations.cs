namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a container for geographic location data retrieved from geocoding operations.
/// </summary>
/// <remarks>
///   This class defines a container for geographic location information
///   returned from geocoding queries that convert address components into coordinate and entity data. The GeoLocations
///   container holds a <see cref="GeoLocation"/> object containing comprehensive location information including coordinates
///   (latitude/longitude), entity identification (name and type), and structured address data. This structure serves as
///   the result wrapper for geocoding operations within <see cref="GeoLocationQueryResult"/>, where it pairs with the
///   originating <see cref="GeoLocationQuery"/> to form a complete query-result pair that can be cached for offline
///   access and performance optimization. The container structure enables consistent handling of geocoding results
///   throughout the geographic data system, providing a standardized format for location information retrieved from
///   mapping services or geographic data providers. While the container currently holds a single location, the structure
///   design allows for potential extension to support multiple location results in cases where geocoding queries return
///   multiple matches for ambiguous addresses (such as multiple cities with the same name in different regions). The
///   GeoLocation data within this container provides all the information needed to plot points on map charts, associate
///   data with geographic entities, display location details, and perform spatial operations. This container is used
///   within the <see cref="Clear"/> structure as part of the geographic cache in <see cref="GeoCache"/>, enabling
///   efficient storage and retrieval of geocoded location data. The standardized container format ensures consistent
///   location data handling across different geocoding scenarios including address-to-coordinate conversion, reverse
///   geocoding results, and location search operations.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoLocations))]
public class GeoLocations: ModelElementCollection<GeoLocation, DXO16DCD.GeoLocations, DXO16DCD.GeoLocation>
{
}