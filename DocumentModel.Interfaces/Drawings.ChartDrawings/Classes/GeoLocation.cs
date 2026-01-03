namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a complete geographic location with coordinates, entity identification, and address information.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a comprehensive geographic location representation
///   that combines coordinate positioning (<see cref="Latitude"/> and <see cref="Longitude"/>), entity identification
///   (<see cref="EntityName"/> and <see cref="EntityType"/>), and structured address data (<see cref="Address"/>).
///   This complete location structure supports various map-based chart scenarios including geocoding (converting addresses
///   to coordinates), reverse geocoding (converting coordinates to addresses and entity identification), location-based
///   data visualization, and geographic search operations. The GeoLocation interface provides all the information needed
///   to accurately position, identify, and describe a geographic point, making it suitable for location queries, search
///   results, and cached geographic data. The coordinate properties enable precise positioning on map charts using standard
///   latitude/longitude values in the geographic coordinate system. The entity identification properties associate the
///   location with a specific geographic entity (such as a city, region, or administrative division), enabling data
///   aggregation and categorization by geographic entity. The address property provides detailed, human-readable location
///   information including street addresses, administrative divisions, postal codes, and country information. Geographic
///   locations are typically used in <see cref="GeoLocationQueryResults"/> within the <see cref="Clear"/> structure,
///   which can be cached in <see cref="GeoCache"/> for offline access and performance optimization. Common use cases
///   include storing geocoded customer addresses for sales mapping, caching search results for location-based queries,
///   maintaining facility locations with complete address and coordinate data, or preserving reverse geocoding results
///   that map coordinates to their containing entities and addresses. The comprehensive location structure eliminates
///   the need for separate coordinate, entity, and address lookups, providing all location information in a single,
///   cohesive structure suitable for efficient caching and retrieval in map-based chart applications.
/// </remarks>
public interface GeoLocation : IModelElement
{
  /// <summary>
  ///   Gets or sets the latitude coordinate of the geographic location.
  /// </summary>
  /// <remarks>
   ///   The latitude specifies the north-south position of the location in the standard geographic coordinate system,
  ///   using decimal degrees where values range from -90 (90°S, South Pole) to +90 (90°N, North Pole). The latitude,
  ///   combined with <see cref="Longitude"/>, provides precise positioning for the location on map charts, enabling
  ///   accurate point plotting, spatial analysis, and geographic visualization. For example, a location in San Francisco
  ///   might have latitude 37.7749. The coordinate precision (number of decimal places) affects the specificity of the
  ///   location, with approximately 5-6 decimal places providing meter-level accuracy suitable for most mapping applications.
  ///   The latitude enables the location to be positioned on maps regardless of whether entity or address information is
  ///   available, supporting pure coordinate-based data visualization scenarios.
  /// </remarks>
  public Double? Latitude { get; set; }

  /// <summary>
  ///   Gets or sets the longitude coordinate of the geographic location.
  /// </summary>
  /// <remarks>
   ///   The longitude specifies the east-west position of the location in the standard geographic coordinate system,
  ///   using decimal degrees where values range from -180 (180°W) to +180 (180°E). The longitude, combined with
  ///   <see cref="Latitude"/>, provides precise positioning for the location on map charts. For example, a location
  ///   in San Francisco might have longitude -122.4194. The coordinate precision (number of decimal places) affects
  ///   the specificity of the location, with approximately 5-6 decimal places providing meter-level accuracy. Together
  ///   with latitude, the longitude enables accurate geographic positioning for data visualization, spatial analysis,
  ///   and location-based operations such as distance calculations, proximity queries, and point-in-region tests.
  /// </remarks>
  public Double? Longitude { get; set; }

  /// <summary>
  ///   Gets or sets the human-readable name of the geographic entity associated with this location.
  /// </summary>
  /// <remarks>
   ///   The entity name provides a user-friendly identifier for the geographic entity that contains or represents this
  ///   location, such as "San Francisco", "California", "United States", or "Tokyo". This name is useful for display
  ///   purposes in chart labels, tooltips, location lists, and other user-facing contexts where the location needs to
  ///   be identified in a readable format. The entity name typically results from reverse geocoding operations that
  ///   identify which geographic entity (city, region, country) contains the specified coordinates. The name may be
  ///   localized based on culture settings, providing appropriate regional naming conventions. The entity name works
  ///   in conjunction with <see cref="EntityType"/> to provide complete entity identification, where the name specifies
  ///   which entity and the type specifies what kind of entity it is.
  /// </remarks>
  public string? EntityName { get; set; }

  /// <summary>
  ///   Gets or sets the classification type of the geographic entity associated with this location.
  /// </summary>
  /// <remarks>
   ///   The entity type specifies the administrative or geographic classification level of the entity associated with
  ///   this location, such as country, first-level administrative division (state/province), second-level administrative
  ///   division (county/district), populated place (city/town), or other classifications. This type information helps
  ///   categorize and organize locations, supports appropriate data aggregation (such as grouping locations by city,
  ///   state, or country), and enables hierarchical location analysis. For example, a location might be classified as
  ///   a "City" entity type with entity name "San Francisco", indicating the location is within or represents that city.
  ///   The entity type works in conjunction with <see cref="EntityName"/> to provide complete entity identification,
  ///   enabling proper interpretation of the location's position within geographic hierarchies.
  /// </remarks>
  public EntityTypeEnum? EntityType { get; set; }

  /// <summary>
  ///   Gets or sets the detailed structured address information for this location.
  /// </summary>
  /// <remarks>
  ///   The address provides detailed, human-readable location information organized into standardized components
  ///   including street address, administrative divisions (country, states, districts), postal code, locality (city/town),
  ///   and ISO country code. This structured address data enables comprehensive location description, supports address-based
  ///   search and filtering, facilitates address display in various formats, and enables integration with address validation
  ///   and geocoding systems. For example, a complete address might include "123 Main Street" as the street address,
  ///   "San Francisco" as the locality, "California" as the first-level administrative division, "94102" as the postal
  ///   code, and "United States" as the country. The address structure provides human-readable location information that
  ///   complements the machine-readable coordinates (<see cref="Latitude"/> and <see cref="Longitude"/>) and entity
  ///   identification (<see cref="EntityName"/> and <see cref="EntityType"/>), offering a complete, multi-faceted
  ///   representation of the geographic location. See <see cref="Address"/> for details on the address component structure.
  /// </remarks>
  public Address? Address { get; set; }
}