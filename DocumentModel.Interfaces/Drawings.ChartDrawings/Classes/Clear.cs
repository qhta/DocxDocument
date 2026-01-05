namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a container for geographic data query results used in map-based chart visualizations.
/// </summary>
/// <remarks>
///   This interface defines a collection of geographic data query
///   result sets that support map charts and geographic visualizations. The Clear interface aggregates various
///   types of geographic query results including location queries (coordinates and addresses), data entity queries
///   (geographic regions and their properties), point-to-entity mappings (associating data points with geographic
///   entities), child entity relationships (hierarchical geographic subdivisions), and parent entity relationships
///   (geographic containment). These query results enable rich geographic data visualization by providing the
///   necessary geographic metadata, boundaries, and relationships for rendering map-based charts. The interface
///   supports complex geographic scenarios such as displaying data by country, state, county, or custom regions,
///   and enables drill-down capabilities through the parent-child entity relationships. This functionality is
///   essential for creating interactive map charts that accurately represent data in geographic context.
/// </remarks>
public interface Clear :
{
  /// <summary>
  ///   Gets or sets the results from geographic location queries.
  /// </summary>
  /// <remarks>
  ///   Geographic location query results provide coordinate information (latitude/longitude) and structured
  ///   address data for locations referenced in the chart. This enables the chart to accurately position
  ///   data points on a map and display location-specific information.
  /// </remarks>
  public GeoLocationQueryResults? GeoLocationQueryResults { get; set; }

  /// <summary>
  ///   Gets or sets the results from geographic data entity queries.
  /// </summary>
  /// <remarks>
  ///   Geographic data entity query results provide information about geographic entities such as countries,
  ///   states, provinces, counties, or custom regions. This includes entity identifiers, names, boundaries,
  ///   and other properties needed to render and label geographic regions in map charts.
  /// </remarks>
  public GeoDataEntityQueryResults? GeoDataEntityQueryResults { get; set; }

  /// <summary>
  ///   Gets or sets the results from queries that map data points to geographic entities.
  /// </summary>
  /// <remarks>
  ///   Geographic data point-to-entity query results establish associations between chart data points and
  ///   their corresponding geographic entities. This enables the chart to correctly attribute data values
  ///   to specific countries, regions, or locations, supporting accurate data visualization on maps.
  /// </remarks>
  public GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults { get; set; }

  /// <summary>
  ///   Gets or sets the results from queries for child geographic entities.
  /// </summary>
  /// <remarks>
  ///   Geographic child entities query results provide information about subdivisions within a parent
  ///   geographic entity, such as states within a country or counties within a state. This supports
  ///   hierarchical geographic visualizations and drill-down interactions where users can navigate from
  ///   larger regions to their constituent parts.
  /// </remarks>
  public GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults { get; set; }

  /// <summary>
  ///   Gets or sets the results from queries for parent geographic entities.
  /// </summary>
  /// <remarks>
  ///   Geographic parent entities query results provide information about the containing or parent entities
  ///   for a given geographic region, such as identifying the state that contains a county or the country
  ///   that contains a state. This supports geographic context and enables roll-up aggregations where data
  ///   from smaller regions is combined to show totals for larger containing regions.
  /// </remarks>
  public GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults { get; set; }
}