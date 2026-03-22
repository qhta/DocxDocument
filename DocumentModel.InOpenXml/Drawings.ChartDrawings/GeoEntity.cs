namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a basic geographic entity reference with identification information.
/// </summary>
/// <remarks>
///   This class defines a lightweight geographic entity representation
///   that provides basic identification through a name and type classification. Unlike <see cref = "GeoData"/> which
///   contains comprehensive geographic information including boundaries, coordinates, and polygons, GeoEntity provides
///   minimal entity identification suitable for references, lists, or scenarios where full geographic detail is not
///   required. This lightweight structure is particularly valuable in geographic hierarchies, query results, or
///   entity collections where only identification and classification information is needed without the overhead of
///   complete boundary and coordinate data. The entity name (<see cref = "EntityName"/>) provides human-readable
///   identification for display and user interaction, while the entity type (<see cref = "EntityType"/>) specifies
///   the administrative or geographic classification level (such as country, state, county, or city). Geographic
///   entities are used throughout the chart drawing geographic data structures to reference regions in hierarchical
///   relationships (via <see cref = "GeoHierarchyEntity"/>), query specifications (such as <see cref = "GeoChildEntitiesQuery"/>),
///   and result collections. The minimal structure promotes efficient memory usage and fast processing when working
///   with large numbers of geographic references, such as listing all states in a country or all counties in a state.
///   When detailed geographic information is needed for rendering or spatial operations, the entity can be used as
///   a reference to query for complete <see cref = "GeoData"/> containing boundaries and coordinates. This separation
///   between lightweight entity references and detailed geographic data enables flexible, efficient geographic data
///   management in map-based chart visualizations.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoEntity))]
public class GeoEntity: ModelElement<DXO16DCD.GeoEntity>
{
  /// <summary>
  /// Specifies the entity name.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoEntity.EntityName))]
  public string? EntityName { get => _EntityName; set => UpdateField(ref _EntityName, value, nameof(EntityName)); }
  private string? _EntityName;
  /// <summary>
  /// Specifies the entity type.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoEntity.EntityType))]
  public EntityTypeEnum? EntityType
  {
    get => _EntityType;
    set => UpdateField(ref _EntityType, value, nameof(EntityType));
  }
  private EntityTypeEnum? _EntityType;
}