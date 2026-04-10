using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a complete geographic location with coordinates, entity identification, and address information.
/// </summary>
/// <remarks>
///   This class defines a comprehensive geographic location representation
///   that combines coordinate positioning (<see cref = "Latitude"/> and <see cref = "Longitude"/>), entity identification
///   (<see cref = "EntityName"/> and <see cref = "EntityType"/>), and structured address data (<see cref = "Address"/>).
///   This complete location structure supports various map-based chart scenarios including geocoding (converting addresses
///   to coordinates), reverse geocoding (converting coordinates to addresses and entity identification), location-based
///   data visualization, and geographic search operations. The GeoLocation class provides all the information needed
///   to accurately position, identify, and describe a geographic point, making it suitable for location queries, search
///   results, and cached geographic data. The coordinate properties enable precise positioning on map charts using standard
///   latitude/longitude values in the geographic coordinate system. The entity identification properties associate the
///   location with a specific geographic entity (such as a city, region, or administrative division), enabling data
///   aggregation and categorization by geographic entity. The address property provides detailed, human-readable location
///   information including street addresses, administrative divisions, postal codes, and country information. Geographic
///   locations are typically used in <see cref = "GeoLocationQueryResults"/> within the <see cref = "Clear"/> structure,
///   which can be cached in <see cref = "GeoCache"/> for offline access and performance optimization. Common use cases
///   include storing geocoded customer addresses for sales mapping, caching search results for location-based queries,
///   maintaining facility locations with complete address and coordinate data, or preserving reverse geocoding results
///   that map coordinates to their containing entities and addresses. The comprehensive location structure eliminates
///   the need for separate coordinate, entity, and address lookups, providing all location information in a single,
///   cohesive structure suitable for efficient caching and retrieval in map-based chart applications.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoLocation))]
[XmlRoot("GeoLocation", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class GeoLocation : ModelElement<DXO16DCD.GeoLocation>
{
 /// <summary>
 /// Specifies the latitude.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.GeoLocation.Latitude))]
 public Double? Latitude { get => _Latitude; set => UpdateField(ref _Latitude, value, nameof(Latitude)); }

 private Double? _Latitude;
 /// <summary>
 /// Specifies the longitude.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.GeoLocation.Longitude))]
 public Double? Longitude { get => _Longitude; set => UpdateField(ref _Longitude, value, nameof(Longitude)); }

 private Double? _Longitude;
 /// <summary>
 /// Specifies the entity name.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.GeoLocation.EntityName))]
 public string? EntityName { get => _EntityName; set => UpdateField(ref _EntityName, value, nameof(EntityName)); }

 private string? _EntityName;
 /// <summary>
 /// Specifies the entity type.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.GeoLocation.EntityType))]
 public EntityTypeEnum? EntityType { get => _EntityType; set => UpdateField(ref _EntityType, value, nameof(EntityType)); }

 private EntityTypeEnum? _EntityType;
 /// <summary>
 /// Specifies the address.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.GeoLocation.Address))]
 public Address? Address { get => _Address; set => UpdateField(ref _Address, value, nameof(Address)); }

 private Address? _Address;
}