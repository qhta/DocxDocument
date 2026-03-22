namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a query for identifying the geographic entity that contains a specific coordinate point.
/// </summary>
/// <remarks>
///   This class defines a query specification used to determine which
///   geographic entity contains a specific latitude/longitude coordinate point. This reverse geocoding operation
///   is essential for map-based charts that need to associate data points specified by coordinates with their
///   corresponding geographic regions, enabling accurate data visualization and geographic analysis. The query
///   specifies a coordinate point (<see cref = "Latitude"/> and <see cref = "Longitude"/>) and optionally filters
///   by entity type (<see cref = "EntityType"/>) to find the appropriate containing entity at a specific administrative
///   or geographic classification level. This mechanism supports various map chart scenarios including plotting
///   individual data points on maps and determining which region they fall within, geocoding address data to
///   associate records with geographic entities, or performing spatial analysis to aggregate point data by containing
///   regions. The query results typically return the geographic entity that contains the specified point, stored in
///   <see cref = "GeoDataPointToEntityQueryResults"/> within the <see cref = "Clear"/> structure, which can be cached
///   in <see cref = "GeoCache"/> for offline access and performance optimization. Common use cases include determining
///   which country contains a specific city coordinate, identifying which state or province contains a facility
///   location, or finding which sales region encompasses a customer's coordinates. The entity type filter enables
///   targeting specific administrative levels, such as querying for the country containing a point (ignoring
///   lower-level subdivisions) or finding the most specific local administrative division. This point-to-entity
///   mapping is fundamental to geographic data visualization, enabling charts to organize and aggregate point-based
///   data according to geographic boundaries and hierarchies.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoDataPointQuery))]
public class GeoDataPointQuery: ModelElement<DXO16DCD.GeoDataPointQuery>
{
  /// <summary>
  /// Specifies the entity type.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoDataPointQuery.EntityType))]
  public EntityTypeEnum? EntityType
  {
    get => _EntityType;
    set => UpdateField(ref _EntityType, value, nameof(EntityType));
  }
  private EntityTypeEnum? _EntityType;
  /// <summary>
  /// Specifies the latitude.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoDataPointQuery.Latitude))]
  public Double? Latitude { get => _Latitude; set => UpdateField(ref _Latitude, value, nameof(Latitude)); }
  private Double? _Latitude;
  /// <summary>
  /// Specifies the longitude.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoDataPointQuery.Longitude))]
  public Double? Longitude { get => _Longitude; set => UpdateField(ref _Longitude, value, nameof(Longitude)); }
  private Double? _Longitude;
}