namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a query for identifying the geographic entity that contains a specific coordinate point.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a query specification used to determine which
///   geographic entity contains a specific latitude/longitude coordinate point. This reverse geocoding operation
///   is essential for map-based charts that need to associate data points specified by coordinates with their
///   corresponding geographic regions, enabling accurate data visualization and geographic analysis. The query
///   specifies a coordinate point (<see cref="Latitude"/> and <see cref="Longitude"/>) and optionally filters
///   by entity type (<see cref="EntityType"/>) to find the appropriate containing entity at a specific administrative
///   or geographic classification level. This mechanism supports various map chart scenarios including plotting
///   individual data points on maps and determining which region they fall within, geocoding address data to
///   associate records with geographic entities, or performing spatial analysis to aggregate point data by containing
///   regions. The query results typically return the geographic entity that contains the specified point, stored in
///   <see cref="GeoDataPointToEntityQueryResults"/> within the <see cref="Clear"/> structure, which can be cached
///   in <see cref="GeoCache"/> for offline access and performance optimization. Common use cases include determining
///   which country contains a specific city coordinate, identifying which state or province contains a facility
///   location, or finding which sales region encompasses a customer's coordinates. The entity type filter enables
///   targeting specific administrative levels, such as querying for the country containing a point (ignoring
///   lower-level subdivisions) or finding the most specific local administrative division. This point-to-entity
///   mapping is fundamental to geographic data visualization, enabling charts to organize and aggregate point-based
///   data according to geographic boundaries and hierarchies.
/// </remarks>
public interface GeoDataPointQuery : IModelElement
{
  /// <summary>
  ///   Gets or sets the type of geographic entity to search for when identifying the containing region.
  /// </summary>
  /// <value>
  ///   An <see cref="EntityTypeEnum"/> value specifying the desired entity classification level,
  ///   or <c>null</c> to return any entity type that contains the point.
  /// </value>
  /// <remarks>
   ///   The entity type specifies the administrative or geographic classification level at which to identify the
  ///   containing entity. This filtering is valuable because a given coordinate point may be contained within
  ///   multiple nested geographic entities (such as a city within a county within a state within a country), and
  ///   the query needs to specify which level of the hierarchy to return. For example, specifying "Country" returns
  ///   the country containing the coordinates, while specifying "AdminDivision1" (state/province level) returns the
  ///   first-level administrative division. This enables precise control over the geographic aggregation level for
  ///   data visualization and analysis. When no entity type is specified, the query may return the most specific
  ///   entity containing the point or follow the provider's default entity resolution logic. The entity type works
  ///   in conjunction with the coordinate parameters to provide targeted point-to-entity mapping at the appropriate
  ///   geographic hierarchy level.
  /// </remarks>
  public EntityTypeEnum? EntityType { get; set; }

  /// <summary>
  ///   Gets or sets the latitude coordinate of the point to query.
  /// </summary>
  /// <value>
  ///   A double-precision floating-point value representing the latitude in decimal degrees,
  ///   or <c>null</c> if no latitude is specified.
  /// </value>
  /// <remarks>
   ///   The latitude specifies the north-south position of the point in the standard geographic coordinate system,
  ///   using decimal degrees where values range from -90 (90°S, South Pole) to +90 (90°N, North Pole). The latitude,
  ///   combined with <see cref="Longitude"/>, uniquely identifies the geographic location for which the containing
  ///   entity is being queried. For example, querying with latitude 37.7749 and longitude -122.4194 would identify
  ///   entities containing San Francisco, California. The coordinate precision (number of decimal places) affects
  ///   the specificity of the location, with more decimal places providing finer geographic resolution. Standard
  ///   precision includes approximately 5-6 decimal places for meter-level accuracy in most geographic applications.
  /// </remarks>
  public Double? Latitude { get; set; }

  /// <summary>
  ///   Gets or sets the longitude coordinate of the point to query.
  /// </summary>
  /// <value>
  ///   A double-precision floating-point value representing the longitude in decimal degrees,
  ///   or <c>null</c> if no longitude is specified.
  /// </value>
  /// <remarks>
   ///   The longitude specifies the east-west position of the point in the standard geographic coordinate system,
  ///   using decimal degrees where values range from -180 (180°W) to +180 (180°E). The longitude, combined with
  ///   <see cref="Latitude"/>, uniquely identifies the geographic location for which the containing entity is being
  ///   queried. The International Date Line is located at approximately ±180° longitude. For coordinates near this
  ///   line, special handling may be required depending on the geographic data provider's coordinate system conventions.
  ///   The coordinate precision (number of decimal places) affects the specificity of the location, with standard
  ///   geographic applications using approximately 5-6 decimal places for meter-level accuracy. Together with the
  ///   latitude, this enables precise point-to-entity mapping that supports accurate geographic data visualization
  ///   and spatial analysis in map-based charts.
  /// </remarks>
  public Double? Longitude { get; set; }
}