namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents the result of a geographic data entity query, containing both the query specification and retrieved entity data.
/// </summary>
/// <remarks>
///   This class defines a query result structure that pairs a geographic
///   entity query (<see cref = "GeoDataEntityQuery"/>) with its corresponding geographic data (<see cref = "GeoData"/>).
///   This structure preserves the association between the query parameters (entity identifier and optional entity type)
///   and the comprehensive geographic information retrieved in response to that query. By maintaining this query-result
///   pairing, the class enables efficient caching and retrieval of geographic entity data in map-based charts.
///   The query result is stored within the <see cref = "Clear"/> structure as part of <see cref = "GeoDataEntityQueryResults"/>,
///   which can be cached in <see cref = "GeoCache"/> to support offline access and improve performance by eliminating
///   redundant queries to external mapping services. This structure is particularly valuable for map charts that display
///   specific geographic regions with accurate boundaries, where the detailed entity data (including bounding box,
///   boundary polygons, identification, and copyright information) needs to be readily accessible for rendering.
///   By caching query results, the chart can respond immediately to repeated rendering requests or navigation actions
///   without requiring new queries to external services. The query-result pairing also enables query validation and
///   cache management, where cached results can be matched against query parameters to determine if a cached result
///   satisfies a new query or if fresh data needs to be retrieved. This optimization is essential for maintaining
///   responsive map chart rendering while minimizing network traffic and external service dependencies. Common use
///   cases include caching country boundary data for world map visualizations, storing state or province data for
///   regional maps, or maintaining custom geographic entity definitions for specialized domain visualizations. The
///   cached geographic data ensures consistent, accurate rendering of map regions even when offline or when the
///   external mapping service is unavailable.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoDataEntityQueryResult))]
[DataContract]
[XmlRoot("GeoDataEntityQueryResult", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class GeoDataEntityQueryResult : ModelElement<DXO16DCD.GeoDataEntityQueryResult>
{
  /// <summary>
  /// Specifies the geo data entity query.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoDataEntityQueryResult.GeoDataEntityQuery))]
  public GeoDataEntityQuery? GeoDataEntityQuery { get => _GeoDataEntityQuery; set => UpdateField(ref _GeoDataEntityQuery, value, nameof(GeoDataEntityQuery)); }

  private GeoDataEntityQuery? _GeoDataEntityQuery;
  /// <summary>
  /// Specifies the geo data.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoDataEntityQueryResult.GeoData))]
  public GeoData? GeoData { get => _GeoData; set => UpdateField(ref _GeoData, value, nameof(GeoData)); }

  private GeoData? _GeoData;
}