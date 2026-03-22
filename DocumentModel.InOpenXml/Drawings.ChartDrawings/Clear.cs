namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a container for geographic data query results used in map-based chart visualizations.
/// </summary>
/// <remarks>
///   This class defines a collection of geographic data query
///   result sets that support map charts and geographic visualizations. The Clear class aggregates various
///   types of geographic query results including location queries (coordinates and addresses), data entity queries
///   (geographic regions and their properties), point-to-entity mappings (associating data points with geographic
///   entities), child entity relationships (hierarchical geographic subdivisions), and parent entity relationships
///   (geographic containment). These query results enable rich geographic data visualization by providing the
///   necessary geographic metadata, boundaries, and relationships for rendering map-based charts. The class
///   supports complex geographic scenarios such as displaying data by country, state, county, or custom regions,
///   and enables drill-down capabilities through the parent-child entity relationships. This functionality is
///   essential for creating interactive map charts that accurately represent data in geographic context.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.Clear))]
public class Clear: ModelElement<DXO16DCD.Clear>
{
  /// <summary>
  /// Specifies the geo location query results.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Clear.GeoLocationQueryResults))]
  public GeoLocationQueryResults? GeoLocationQueryResults
  {
    get => _GeoLocationQueryResults;
    set => UpdateField(ref _GeoLocationQueryResults, value, nameof(GeoLocationQueryResults));
  }
  private GeoLocationQueryResults? _GeoLocationQueryResults;
  /// <summary>
  /// Specifies the geo data entity query results.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Clear.GeoDataEntityQueryResults))]
  public GeoDataEntityQueryResults? GeoDataEntityQueryResults
  {
    get => _GeoDataEntityQueryResults;
    set => UpdateField(ref _GeoDataEntityQueryResults, value, nameof(GeoDataEntityQueryResults));
  }
  private GeoDataEntityQueryResults? _GeoDataEntityQueryResults;
  /// <summary>
  /// Specifies the geo data point to entity query results.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Clear.GeoDataPointToEntityQueryResults))]
  public GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults
  {
    get => _GeoDataPointToEntityQueryResults;
    set => UpdateField(ref _GeoDataPointToEntityQueryResults, value, nameof(GeoDataPointToEntityQueryResults));
  }
  private GeoDataPointToEntityQueryResults? _GeoDataPointToEntityQueryResults;
  /// <summary>
  /// Specifies the geo child entities query results.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Clear.GeoChildEntitiesQueryResults))]
  public GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults
  {
    get => _GeoChildEntitiesQueryResults;
    set => UpdateField(ref _GeoChildEntitiesQueryResults, value, nameof(GeoChildEntitiesQueryResults));
  }
  private GeoChildEntitiesQueryResults? _GeoChildEntitiesQueryResults;
  /// <summary>
  /// Specifies the geo parent entities query results.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Clear.GeoParentEntitiesQueryResults))]
  public GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults
  {
    get => _GeoParentEntitiesQueryResults;
    set => UpdateField(ref _GeoParentEntitiesQueryResults, value, nameof(GeoParentEntitiesQueryResults));
  }
  private GeoParentEntitiesQueryResults? _GeoParentEntitiesQueryResults;
}