namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a query for retrieving parent geographic entities that contain a specific child entity.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a query specification used to retrieve parent
///   geographic entities within which a specified child entity is contained. This upward hierarchical query is the
///   complement to <see cref="GeoChildEntitiesQuery"/>, enabling navigation up the geographic hierarchy rather than
///   down. The query enables map-based charts to determine geographic containment relationships, such as identifying
///   which state contains a given county, which country contains a given state, or which continent contains a given
///   country. By specifying a child entity identifier (<see cref="EntityId"/>), the query retrieves the parent entities
///   at higher administrative or geographic levels that contain or encompass the specified entity. The query results
///   are typically stored in <see cref="GeoParentEntitiesQueryResults"/> within the <see cref="Clear"/> structure,
///   which can be cached in <see cref="GeoCache"/> for offline access and performance optimization. This upward
///   navigation capability is essential for interactive map charts that support drill-up operations (navigating from
///   detailed regions to broader containing regions), breadcrumb navigation (showing the hierarchical path from a
///   specific location to its containing regions), data aggregation (rolling up data from a specific region to its
///   parent regions for summary views), and geographic context display (showing which larger regions contain a selected
///   area). Common scenarios include determining which state contains a selected county for context, identifying which
///   country contains a city for international data visualization, finding regional groupings for local administrative
///   divisions, or establishing hierarchical navigation paths that show the complete containment structure (such as
///   City → County → State → Country → Continent). The parent entity query enables bidirectional navigation through
///   geographic hierarchies, complementing child entity queries to provide complete hierarchical exploration capabilities.
/// </remarks>
public interface GeoParentEntitiesQuery : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier of the child entity whose parent entities are being queried.
  /// </summary>
  /// <value>
  ///   A string containing the child entity's unique identifier,
  ///   or <c>null</c> if no entity is specified.
  /// </value>
  /// <remarks>
   ///   The entity identifier uniquely identifies the child geographic entity for which parent entities are being
  ///   requested. This ID typically corresponds to a geographic entity defined in the mapping service's data model,
  ///   such as a county code, city identifier, or region reference. For example, querying for parent entities of
  ///   "Los Angeles County" would retrieve California (the state) and United States (the country), or querying for
  ///   "Tokyo" might retrieve Japan and Asia. The identifier format depends on the geographic data provider specified
  ///   in <see cref="GeoCache.Provider"/>, which determines how entities are identified and referenced. The entity
  ///   ID enables precise targeting of the child entity in the geographic hierarchy, ensuring that the query returns
  ///   only the relevant parent entities that contain this specific region. This targeted approach is essential for
  ///   efficient data retrieval and enables responsive map chart interactions where users can navigate up through
  ///   multiple levels of geographic containment without loading unnecessary hierarchical data. The parent entity
  ///   results provide context for the child entity, showing its position within broader geographic structures and
  ///   enabling hierarchical navigation, data aggregation from child to parent levels, and geographic context display
  ///   that helps users understand the location's position within larger regional frameworks.
  /// </remarks>
  public string? EntityId { get; set; }
}