using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the geographic configuration and settings for map-based chart visualizations.
/// </summary>
/// <remarks>
///   This class defines the comprehensive geographic settings that control
///   how map-based charts render and display geographic data. The geography configuration includes the map projection
///   type (<see cref = "ProjectionType"/>) which determines how the spherical Earth is represented on a flat chart surface,
///   the viewed region type (<see cref = "ViewedRegionType"/>) which specifies the geographic scope and detail level,
///   culture settings (<see cref = "CultureLanguage"/> and <see cref = "CultureRegion"/>) for localization of geographic
///   names and formats, data attribution (<see cref = "Attribution"/>) for proper credit to geographic data sources, and
///   a geographic data cache (<see cref = "GeoCache"/>) for offline access and performance optimization. These settings
///   collectively control the visual representation, regional focus, cultural context, and data management of map charts,
///   enabling accurate, culturally appropriate, and performant geographic data visualization. The projection type affects
///   how geographic regions appear on the map, with different projections preserving different properties such as area,
///   shape, or distance. The viewed region type determines the geographic hierarchy level being visualized, such as world
///   view, continental view, or country-specific view. Culture settings ensure geographic names, labels, and formatting
///   conventions match the document's locale and user preferences. Attribution provides proper credit to mapping service
///   providers and geographic data sources, ensuring legal compliance and acknowledging data creators. The geographic cache
///   stores previously retrieved geographic data, enabling offline map chart rendering and reducing dependency on external
///   mapping services. Together, these components provide comprehensive control over map-based chart visualization,
///   supporting various use cases from global data analysis to regional drill-down visualizations with appropriate
///   cultural localization and efficient data management.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.Geography))]
[DataContract]
[XmlRoot("Geography", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class Geography: ModelElement<DXO16DCD.Geography>
{
  /// <summary>
  /// Specifies the projection type.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Geography.ProjectionType))]
  public GeoProjectionType? ProjectionType
  {
    get => _ProjectionType ??= GetProperty<GeoProjectionType?>(GetUpdatableElement()?.ProjectionType);
    set => UpdateField(ref _ProjectionType, value, nameof(ProjectionType));
  }

  private GeoProjectionType? _ProjectionType;

  /// <summary>
  /// Specifies the viewed region type.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Geography.ViewedRegionType))]
  public GeoMappingLevel? ViewedRegionType
  {
    get => _ViewedRegionType ??= GetProperty<GeoMappingLevel?>(GetUpdatableElement()?.ViewedRegionType);
    set => UpdateField(ref _ViewedRegionType, value, nameof(ViewedRegionType));
  }

  private GeoMappingLevel? _ViewedRegionType;

  /// <summary>
  /// Specifies the culture language.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Geography.CultureLanguage))]
  public string? CultureLanguage
  {
    get => _CultureLanguage ??= GetProperty<string?>(GetUpdatableElement()?.CultureLanguage);
    set => UpdateField(ref _CultureLanguage, value, nameof(CultureLanguage));
  }

  private string? _CultureLanguage;

  /// <summary>
  /// Specifies the culture region.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Geography.CultureRegion))]
  public string? CultureRegion
  {
    get => _CultureRegion ??= GetProperty<string?>(GetUpdatableElement()?.CultureRegion);
    set => UpdateField(ref _CultureRegion, value, nameof(CultureRegion));
  }

  private string? _CultureRegion;

  /// <summary>
  /// Specifies the attribution.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Geography.Attribution))]
  public string? Attribution
  {
    get => _Attribution ??= GetProperty<string?>(GetUpdatableElement()?.Attribution);
    set => UpdateField(ref _Attribution, value, nameof(Attribution));
  }

  private string? _Attribution;

  /// <summary>
  /// Specifies the geo cache.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Geography.GeoCache))]
  public GeoCache? GeoCache
  {
    get => _GeoCache ??= GetProperty<GeoCache?>(GetUpdatableElement()?.GeoCache);
    set => UpdateField(ref _GeoCache, value, nameof(GeoCache));
  }

  private GeoCache? _GeoCache;
}