namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a collection of geographic entity type filters used to specify which child entity types to retrieve.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a collection of entity type identifiers used
///   to filter geographic child entity queries. When requesting child entities from a parent geographic region
///   (via <see cref="GeoChildEntitiesQuery"/>), the GeoChildTypes collection specifies which categories or types
///   of child entities should be included in the results. This filtering capability enables selective retrieval
///   of geographic data, improving query performance and reducing data transfer by requesting only the entity types
///   needed for specific map chart visualizations. Geographic entities can be classified into various types based
///   on their administrative level, statistical designation, or functional category. Common entity types include
///   administrative subdivisions (such as states, provinces, counties, districts), populated places (cities, towns,
///   villages), statistical regions (census tracts, metropolitan areas), postal code areas, economic zones, or custom
///   geographic classifications specific to particular domains or mapping providers. By specifying entity types in
///   the filter, applications can retrieve precisely the level and category of geographic detail required. For example,
///   a chart visualizing state-level data might filter for only first-level administrative divisions, excluding cities
///   and postal codes to optimize the query. Similarly, a demographic visualization might focus on populated places
///   while excluding administrative boundaries. The entity type identifiers in the collection are typically strings
///   that correspond to classification schemes used by the geographic data provider (specified in <see cref="GeoCache.Provider"/>),
///   ensuring that the filtering aligns with the provider's data model and taxonomy. When no entity types are specified
///   or the collection is null, queries typically return all available child entity types within the parent region,
///   providing comprehensive geographic hierarchy information at the cost of larger data transfers and longer query times.
/// </remarks>
public interface GeoChildTypes : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of entity type identifiers to include in child entity queries.
  /// </summary>
  /// <value>
  ///   A collection of strings where each string represents a geographic entity type identifier,
  ///   or <c>null</c> to retrieve all entity types without filtering.
  /// </value>
  /// <remarks>
  ///   Each string in the collection identifies a specific type or category of geographic entity to include in
  ///   query results. The entity type identifiers correspond to the classification system used by the geographic
  ///   data provider, which may include administrative levels (e.g., "AdminDivision1" for states/provinces,
  ///   "AdminDivision2" for counties), place types (e.g., "City", "Town", "Village"), statistical designations
  ///   (e.g., "MetropolitanArea", "CensusTract"), or domain-specific categories. By specifying multiple entity
  ///   types, the query can retrieve a combination of geographic entity categories in a single request. For example,
  ///   including both "AdminDivision1" and "City" would retrieve both first-level administrative divisions and
  ///   major cities within a parent region. The collection enables flexible query construction where applications
  ///   can precisely control the types of geographic entities retrieved based on the visualization requirements,
  ///   data analysis needs, or performance constraints. When the collection is empty or null, the query behavior
  ///   depends on the geographic data provider's default settings, typically returning all available child entity
  ///   types. The entity type filtering works in conjunction with the parent entity identifier specified in
  ///   <see cref="GeoChildEntitiesQuery.EntityId"/> to create targeted, efficient queries that retrieve only the
  ///   geographic data needed for specific map chart scenarios.
  /// </remarks>
  public Collection<String>? EntityTypes { get; set; }
}