using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a query for geocoding address components to determine geographic coordinates and location information.
/// </summary>
/// <remarks>
///   This class defines a geocoding query specification that converts
///   structured address components into geographic location data including coordinates, entity identification, and
///   complete address information. The query accepts partial or complete address information through administrative
///   division properties (<see cref = "CountryRegion"/>, <see cref = "AdminDistrict1"/>, <see cref = "AdminDistrict2"/>),
///   postal code (<see cref = "PostalCode"/>), and optional entity type filtering (<see cref = "EntityType"/>), enabling
///   flexible geocoding from various levels of address specificity. This geocoding mechanism is essential for map-based
///   charts that need to convert address data into mappable coordinates, supporting scenarios where data sources contain
///   address information rather than explicit geographic coordinates. The query results typically return <see cref = "GeoLocation"/>
///   objects containing coordinates (latitude/longitude), entity identification, and complete structured address data,
///   stored in <see cref = "GeoLocationQueryResults"/> within the <see cref = "Clear"/> structure, which can be cached in
///   <see cref = "GeoCache"/> for offline access and performance optimization. Common use cases include geocoding customer
///   addresses for sales territory mapping, converting facility addresses to coordinates for location visualization,
///   plotting demographic data specified by administrative divisions and postal codes, or resolving partial address
///   information to complete geographic locations. The hierarchical address structure supports various geocoding
///   granularities: country-only queries for national-level mapping, country + state queries for regional analysis,
///   or complete address queries including postal codes for precise location identification. The entity type filter
///   helps target specific geographic classification levels, such as querying for cities, counties, or other entity
///   types within the specified address components. This flexible address-based query mechanism enables charts to work
///   with diverse data sources that specify locations through addresses, administrative boundaries, or postal codes
///   rather than explicit coordinates, automatically converting these references into mappable geographic positions.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoLocationQuery))]
[DataContract]
[XmlRoot("GeoLocationQuery", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class GeoLocationQuery: ModelElement<DXO16DCD.GeoLocationQuery>
{
  /// <summary>
  /// Specifies the country region.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoLocationQuery.CountryRegion))]
  public string? CountryRegion
  {
    get => _CountryRegion ??= GetProperty<string?>(GetUpdatableElement()?.CountryRegion);
    set => UpdateField(ref _CountryRegion, value, nameof(CountryRegion));
  }

  private string? _CountryRegion;

  /// <summary>
  /// Specifies the admin district1.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoLocationQuery.AdminDistrict1))]
  public string? AdminDistrict1
  {
    get => _AdminDistrict1 ??= GetProperty<string?>(GetUpdatableElement()?.AdminDistrict1);
    set => UpdateField(ref _AdminDistrict1, value, nameof(AdminDistrict1));
  }

  private string? _AdminDistrict1;

  /// <summary>
  /// Specifies the admin district2.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoLocationQuery.AdminDistrict2))]
  public string? AdminDistrict2
  {
    get => _AdminDistrict2 ??= GetProperty<string?>(GetUpdatableElement()?.AdminDistrict2);
    set => UpdateField(ref _AdminDistrict2, value, nameof(AdminDistrict2));
  }

  private string? _AdminDistrict2;

  /// <summary>
  /// Specifies the postal code.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoLocationQuery.PostalCode))]
  public string? PostalCode
  {
    get => _PostalCode ??= GetProperty<string?>(GetUpdatableElement()?.PostalCode);
    set => UpdateField(ref _PostalCode, value, nameof(PostalCode));
  }

  private string? _PostalCode;

  /// <summary>
  /// Specifies the entity type.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoLocationQuery.EntityType))]
  public EntityTypeEnum? EntityType
  {
    get => _EntityType ??= GetProperty<EntityTypeEnum?>(GetUpdatableElement()?.EntityType);
    set => UpdateField(ref _EntityType, value, nameof(EntityType));
  }

  private EntityTypeEnum? _EntityType;
}