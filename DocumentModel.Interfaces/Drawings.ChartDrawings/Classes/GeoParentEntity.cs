namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a parent geographic entity in a hierarchical containment relationship.
/// </summary>
/// <remarks>
///   This interface defines a parent geographic entity that contains or
///   encompasses a child entity within the geographic hierarchy. Unlike the more comprehensive <see cref="GeoHierarchyEntity"/>
///   which includes name, identifier, and type, or <see cref="GeoEntity"/> which includes name and type, GeoParentEntity
///   provides a minimal representation with only the unique identifier, making it a lightweight reference suitable for
///   representing upward hierarchical relationships. This streamlined structure is particularly valuable in parent entity
///   query results where the primary need is to reference the containing entity without the overhead of complete entity
///   information. The parent entity identifier (<see cref="EntityId"/>) enables precise reference to the containing
///   geographic entity, supporting hierarchical navigation, data aggregation, and geographic context operations. Parent
///   entities are used in <see cref="GeoParentEntitiesQueryResult"/> within the geographic cache to represent upward
///   containment relationships, such as the state that contains a county, the country that contains a state, or the
///   continent that contains a country. The minimal identifier-only structure promotes efficient memory usage when
///   working with large numbers of parent entity references, such as when caching parent relationships for numerous
///   child entities throughout a geographic hierarchy. When additional entity information (name, type, boundaries,
///   coordinates) is needed for the parent entity, the identifier can be used to query for complete entity data through
///   <see cref="GeoDataEntityQuery"/> or to retrieve cached comprehensive information from <see cref="GeoCache"/>. This
///   separation between lightweight parent entity references and detailed entity data enables flexible, efficient
///   geographic data management where hierarchical relationships can be cached and navigated without requiring complete
///   entity definitions for every parent reference. The parent entity structure supports drill-up navigation in map-based
///   charts, enabling users to navigate from detailed regions to broader containing regions while maintaining efficient
///   cache storage and quick hierarchical relationship lookups.
/// </remarks>
public interface GeoParentEntity
{
  /// <summary>
  ///   Gets or sets the unique identifier of the parent geographic entity.
  /// </summary>
  /// <remarks>
   ///   The entity identifier provides a unique, machine-readable reference for the parent geographic entity that
  ///   contains or encompasses a child entity in the geographic hierarchy. The identifier typically follows standardized
  ///   formats such as ISO country codes (e.g., "US" for United States, "GB" for United Kingdom, "JP" for Japan),
  ///   administrative division codes (e.g., "US-CA" for California, "US-NY" for New York), or provider-specific entity
  ///   identifiers. The identifier format depends on the geographic data provider specified in <see cref="GeoCache.Provider"/>,
  ///   ensuring consistency with the provider's entity identification system. The parent entity identifier serves several
  ///   critical purposes in hierarchical geographic operations: (1) enabling upward navigation where users drill up from
  ///   child entities to their containing parent entities, (2) supporting data aggregation where values from child entities
  ///   are rolled up to parent entities using the identifier to establish containment relationships, (3) facilitating
  ///   breadcrumb navigation that shows the hierarchical path from detailed regions to broader containing areas,
  ///   (4) enabling efficient cache lookup in <see cref="GeoCache"/> where the identifier can be used to retrieve complete
  ///   entity information when needed beyond the lightweight parent reference, and (5) establishing parent-child relationships
  ///   in geographic hierarchies without requiring full entity data for every parent reference. For example, a county entity
  ///   might have a parent entity with identifier "US-CA" (California), which can be used to navigate to the state level,
  ///   aggregate county data to state totals, or display "California" in a breadcrumb trail. The identifier provides the
  ///   essential link in the containment hierarchy while maintaining minimal memory overhead through the lightweight
  ///   parent entity structure.
  /// </remarks>
  public string? EntityId { get; set; }
}