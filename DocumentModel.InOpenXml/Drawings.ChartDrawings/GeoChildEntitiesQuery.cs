namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a query for retrieving child geographic entities within a specific parent geographic entity.
/// </summary>
/// <remarks>
///   This class defines a query specification used to retrieve child
///   geographic entities that are contained within a parent geographic entity. The query enables map-based charts
///   to request hierarchical geographic information from mapping services or cached geographic data, supporting
///   drill-down navigation and progressive detail display in geographic visualizations. By specifying a parent
///   entity identifier (<see cref = "EntityId"/>) and optionally filtering by child entity types (<see cref = "GeoChildTypes"/>),
///   the query can retrieve specific subsets of child entities such as states within a country, counties within a
///   state, or cities within a region. The query results are typically stored in <see cref = "GeoChildEntitiesQueryResults"/>
///   within the <see cref = "Clear"/> structure, which can be cached in <see cref = "GeoCache"/> for offline access and
///   performance optimization. This query mechanism is fundamental to interactive map charts that allow users to
///   navigate geographic hierarchies, where selecting a parent region triggers queries for its child entities to
///   display more detailed geographic data. The query supports various use cases including dynamic drill-down (loading
///   child entities on demand when users interact with parent regions), hierarchical data exploration (progressively
///   revealing more detailed geographic levels), and selective loading (retrieving only specific types of child
///   entities to optimize performance and reduce data transfer). The query structure enables efficient geographic
///   data retrieval by targeting specific parent-child relationships rather than loading entire geographic hierarchies,
///   making it practical to work with large geographic datasets while maintaining responsive chart interactions.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoChildEntitiesQuery))]
[XmlRoot("GeoChildEntitiesQuery", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class GeoChildEntitiesQuery : ModelElement<DXO16DCD.GeoChildEntitiesQuery>
{
  /// <summary>
  /// Specifies the entity id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoChildEntitiesQuery.EntityId))]
  public string? EntityId { get => _EntityId; set => UpdateField(ref _EntityId, value, nameof(EntityId)); }

  private string? _EntityId;
  /// <summary>
  /// Specifies the geo child types.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoChildEntitiesQuery.GeoChildTypes))]
  public ListOf<string>? GeoChildTypes { get => _GeoChildTypes; set => UpdateField(ref _GeoChildTypes, value, nameof(GeoChildTypes)); }

  private ListOf<string>? _GeoChildTypes;
}