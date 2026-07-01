namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a parent geographic entity in a hierarchical containment relationship.
/// </summary>
/// <remarks>
///   This class defines a parent geographic entity that contains or
///   encompasses a child entity within the geographic hierarchy. Unlike the more comprehensive <see cref = "GeoHierarchyEntity"/>
///   which includes name, identifier, and type, or <see cref = "GeoEntity"/> which includes name and type, GeoParentEntity
///   provides a minimal representation with only the unique identifier, making it a lightweight reference suitable for
///   representing upward hierarchical relationships. This streamlined structure is particularly valuable in parent entity
///   query results where the primary need is to reference the containing entity without the overhead of complete entity
///   information. The parent entity identifier (<see cref = "EntityId"/>) enables precise reference to the containing
///   geographic entity, supporting hierarchical navigation, data aggregation, and geographic context operations. Parent
///   entities are used in <see cref = "GeoParentEntitiesQueryResult"/> within the geographic cache to represent upward
///   containment relationships, such as the state that contains a county, the country that contains a state, or the
///   continent that contains a country. The minimal identifier-only structure promotes efficient memory usage when
///   working with large numbers of parent entity references, such as when caching parent relationships for numerous
///   child entities throughout a geographic hierarchy. When additional entity information (name, type, boundaries,
///   coordinates) is needed for the parent entity, the identifier can be used to query for complete entity data through
///   <see cref = "GeoDataEntityQuery"/> or to retrieve cached comprehensive information from <see cref = "GeoCache"/>. This
///   separation between lightweight parent entity references and detailed entity data enables flexible, efficient
///   geographic data management where hierarchical relationships can be cached and navigated without requiring complete
///   entity definitions for every parent reference. The parent entity structure supports drill-up navigation in map-based
///   charts, enabling users to navigate from detailed regions to broader containing regions while maintaining efficient
///   cache storage and quick hierarchical relationship lookups.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoParentEntity))]
[DataContract]
[XmlRoot("GeoParentEntity", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class GeoParentEntity : ModelElement<DXO16DCD.GeoParentEntity>
{
  /// <summary>
  /// Specifies the entity id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoParentEntity.EntityId))]
  public string? EntityId { get => _EntityId; set => UpdateField(ref _EntityId, value, nameof(EntityId)); }

  private string? _EntityId;
}