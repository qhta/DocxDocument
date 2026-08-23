namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents geographic data for a specific entity including identification, bounding box coordinates, and geometric boundaries.
/// </summary>
/// <remarks>
///   This class defines comprehensive geographic information for a single
///   geographic entity used in map-based chart visualizations. The geographic data includes entity identification
///   (<see cref = "EntityName"/> and <see cref = "EntityId"/>), a bounding box defining the entity's geographic extent
///   (<see cref = "East"/>, <see cref = "West"/>, <see cref = "North"/>, <see cref = "South"/>), detailed boundary polygons
///   (<see cref = "GeoPolygons"/>), and copyright attributions for the geographic data (<see cref = "Copyrights"/>).
///   This complete data structure enables accurate rendering of geographic regions on map charts, supporting various
///   visualization scenarios from country-level overviews to detailed regional displays. The entity identification
///   enables correlation between chart data points and their corresponding geographic regions, while the bounding box
///   provides quick spatial reference for positioning and zoom calculations. The detailed polygons define precise
///   boundaries for accurate region rendering, and copyright information ensures proper attribution of geographic data
///   sources. Geographic data instances are typically retrieved from mapping services or geographic data providers
///   (identified in <see cref = "GeoCache.Provider"/>) and cached in <see cref = "GeoCache"/> for offline access and
///   performance optimization. The data supports various map chart features including region coloring based on data
///   values (choropleth maps), boundary rendering, geographic selection and interaction, and spatial data analysis.
///   The bounding box coordinates use standard geographic coordinate system (latitude/longitude), enabling integration
///   with various mapping and GIS systems. This geographic data structure is fundamental to Office's map chart
///   capabilities, enabling visualization of data in geographic context across countries, states, regions, or custom
///   geographic boundaries.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoData))]
[DataContract]
[XmlRoot("GeoData", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class GeoData: ModelElement<DXO16DCD.GeoData>
{
  /// <summary>
  /// Specifies the entity name.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoData.EntityName))]
  public string? EntityName
  {
    get => _EntityName ??= GetProperty<string?>(GetUpdatableElement()?.EntityName);
    set => UpdateField(ref _EntityName, value, nameof(EntityName));
  }

  private string? _EntityName;

  /// <summary>
  /// Specifies the entity id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoData.EntityId))]
  public string? EntityId
  {
    get => _EntityId ??= GetProperty<string?>(GetUpdatableElement()?.EntityId);
    set => UpdateField(ref _EntityId, value, nameof(EntityId));
  }

  private string? _EntityId;

  /// <summary>
  /// Specifies the east.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoData.East))]
  public Double? East
  {
    get => _East ??= GetProperty<Double?>(GetUpdatableElement()?.East);
    set => UpdateField(ref _East, value, nameof(East));
  }

  private Double? _East;

  /// <summary>
  /// Specifies the west.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoData.West))]
  public Double? West
  {
    get => _West ??= GetProperty<Double?>(GetUpdatableElement()?.West);
    set => UpdateField(ref _West, value, nameof(West));
  }

  private Double? _West;

  /// <summary>
  /// Specifies the north.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoData.North))]
  public Double? North
  {
    get => _North ??= GetProperty<Double?>(GetUpdatableElement()?.North);
    set => UpdateField(ref _North, value, nameof(North));
  }

  private Double? _North;

  /// <summary>
  /// Specifies the south.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoData.South))]
  public Double? South
  {
    get => _South ??= GetProperty<Double?>(GetUpdatableElement()?.South);
    set => UpdateField(ref _South, value, nameof(South));
  }

  private Double? _South;

  /// <summary>
  /// Specifies the geo polygons.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoData.GeoPolygons))]
  public GeoPolygons? GeoPolygons
  {
    get => _GeoPolygons ??= GetProperty<GeoPolygons?>(GetUpdatableElement()?.GeoPolygons);
    set => UpdateField(ref _GeoPolygons, value, nameof(GeoPolygons));
  }

  private GeoPolygons? _GeoPolygons;

  /// <summary>
  /// Specifies the copyrights.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoData.Copyrights))]
  public Copyrights? Copyrights
  {
    get => _Copyrights ??= GetProperty<Copyrights?>(GetUpdatableElement()?.Copyrights);
    set => UpdateField(ref _Copyrights, value, nameof(Copyrights));
  }

  private Copyrights? _Copyrights;
}