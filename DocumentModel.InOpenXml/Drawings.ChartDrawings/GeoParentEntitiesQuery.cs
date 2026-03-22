namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a query for retrieving parent geographic entities that contain a specific child entity.
/// </summary>
/// <remarks>
///   This class defines a query specification used to retrieve parent
///   geographic entities within which a specified child entity is contained. This upward hierarchical query is the
///   complement to <see cref = "GeoChildEntitiesQuery"/>, enabling navigation up the geographic hierarchy rather than
///   down. The query enables map-based charts to determine geographic containment relationships, such as identifying
///   which state contains a given county, which country contains a given state, or which continent contains a given
///   country. By specifying a child entity identifier (<see cref = "EntityId"/>), the query retrieves the parent entities
///   at higher administrative or geographic levels that contain or encompass the specified entity. The query results
///   are typically stored in <see cref = "GeoParentEntitiesQueryResults"/> within the <see cref = "Clear"/> structure,
///   which can be cached in <see cref = "GeoCache"/> for offline access and performance optimization. This upward
///   navigation capability is essential for interactive map charts that support drill-up operations (navigating from
///   detailed regions to broader containing regions), breadcrumb navigation (showing the hierarchical path from a
///   specific location to its containing regions), data aggregation (rolling up data from a specific region to its
///   parent regions for summary views), and geographic context display (showing which larger regions contain a selected
///   area). Common scenarios include determining which state contains a selected county for context, identifying which
///   country contains a city for international data visualization, finding regional groupings for local administrative
///   divisions, or establishing hierarchical navigation paths that show the complete containment structure (such as
///   City Ä‚â€žÄąÄ…Ă„Ä…Ă„ËťÄ‚â€ąÄąÄ„ County Ä‚â€žÄąÄ…Ă„Ä…Ă„ËťÄ‚â€ąÄąÄ„ State Ä‚â€žÄąÄ…Ă„Ä…Ă„ËťÄ‚â€ąÄąÄ„ Country Ä‚â€žÄąÄ…Ă„Ä…Ă„ËťÄ‚â€ąÄąÄ„ Continent). The parent entity query enables bidirectional navigation through
///   geographic hierarchies, complementing child entity queries to provide complete hierarchical exploration capabilities.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoParentEntitiesQuery))]
public class GeoParentEntitiesQuery: ModelElement<DXO16DCD.GeoParentEntitiesQuery>
{
  /// <summary>
  /// Specifies the entity id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoParentEntitiesQuery.EntityId))]
  public string? EntityId { get => _EntityId; set => UpdateField(ref _EntityId, value, nameof(EntityId)); }
  private string? _EntityId;
}