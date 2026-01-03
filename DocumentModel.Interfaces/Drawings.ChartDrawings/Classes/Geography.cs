namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the geographic configuration and settings for map-based chart visualizations.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines the comprehensive geographic settings that control
///   how map-based charts render and display geographic data. The geography configuration includes the map projection
///   type (<see cref="ProjectionType"/>) which determines how the spherical Earth is represented on a flat chart surface,
///   the viewed region type (<see cref="ViewedRegionType"/>) which specifies the geographic scope and detail level,
///   culture settings (<see cref="CultureLanguage"/> and <see cref="CultureRegion"/>) for localization of geographic
///   names and formats, data attribution (<see cref="Attribution"/>) for proper credit to geographic data sources, and
///   a geographic data cache (<see cref="GeoCache"/>) for offline access and performance optimization. These settings
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
public interface Geography : IModelElement
{
  /// <summary>
  ///   Gets or sets the map projection type used to render the geographic chart.
  /// </summary>
  /// <value>
  ///   A <see cref="GeoProjectionType"/> value specifying the projection method,
  ///   or <c>null</c> to use the default projection for the viewed region.
  /// </value>
  /// <remarks>
   ///   The projection type determines how the three-dimensional spherical Earth is mathematically transformed to a
  ///   two-dimensional chart surface. Different projections preserve different geographic properties and are suited
  ///   for different visualization purposes. Common projection types include Mercator (preserves shapes and angles,
  ///   commonly used for navigation and world maps but distorts areas near poles), Miller (compromise projection
  ///   balancing distortion across properties), Albers (equal-area conic projection preserving area relationships,
  ///   suitable for regional maps), and others. The choice of projection significantly affects how geographic regions
  ///   appear on the map and influences visual interpretation of the data. For example, Mercator projection makes
  ///   Greenland appear much larger relative to Africa than it actually is, while equal-area projections maintain
  ///   accurate size relationships. The projection should be chosen based on the geographic scope (world, continent,
  ///   country), the data being visualized, and the analytical goals (comparing areas, analyzing distances, or
  ///   preserving shapes).
  /// </remarks>
  public GeoProjectionType? ProjectionType { get; set; }

  /// <summary>
  ///   Gets or sets the geographic scope and detail level of the viewed region.
  /// </summary>
  /// <value>
  ///   A <see cref="GeoMappingLevel"/> value specifying the regional scope,
  ///   or <c>null</c> to use automatic region detection based on the data.
  /// </value>
  /// <remarks>
   ///   The viewed region type specifies the geographic hierarchy level and scope of the map visualization, such as
  ///   world view (showing all countries globally), continental view (focusing on a specific continent), country view
  ///   (showing regions within a country), or more detailed regional views. This setting influences the level of detail
  ///   displayed, the appropriate projection to use, and the geographic entities that are rendered. Different region
  ///   types enable appropriate zoom levels and detail granularity for the data being visualized. For example, a world
  ///   view is suitable for comparing data across countries, while a country view is appropriate for analyzing regional
  ///   variations within that nation. The viewed region type works in conjunction with the data being visualized to
  ///   determine the appropriate geographic scope, detail level, and rendering approach. This enables the map chart to
  ///   automatically adjust its display to match the data's geographic extent and analytical requirements.
  /// </remarks>
  public GeoMappingLevel? ViewedRegionType { get; set; }

  /// <summary>
  ///   Gets or sets the culture language code used for localizing geographic names and labels.
  /// </summary>
  /// <value>
  ///   A string containing the language code (e.g., "en" for English, "fr" for French, "ja" for Japanese),
  ///   or <c>null</c> to use the document's default language settings.
  /// </value>
  /// <remarks>
   ///   The culture language specifies which language should be used for displaying geographic entity names, labels,
  ///   and other text elements in the map chart. This enables localization of geographic names to match user preferences
  ///   or document requirements. For example, with language "de" (German), "Germany" might be displayed as "Deutschland",
  ///   "Spain" as "Spanien", and "Japan" as "Japan". The language code typically follows ISO 639-1 (two-letter codes)
  ///   or ISO 639-2 (three-letter codes) standards. Language localization is essential for creating documents intended
  ///   for international audiences, ensuring geographic names are presented in a familiar, recognizable format. The
  ///   culture language works in conjunction with <see cref="CultureRegion"/> to provide complete cultural localization,
  ///   where language specifies the language of text and region specifies formatting conventions.
  /// </remarks>
  public string? CultureLanguage { get; set; }

  /// <summary>
  ///   Gets or sets the culture region code used for formatting conventions and regional preferences.
  /// </summary>
  /// <value>
  ///   A string containing the region code (e.g., "US" for United States, "GB" for United Kingdom, "JP" for Japan),
  ///   or <c>null</c> to use the document's default region settings.
  /// </value>
  /// <remarks>
   ///   The culture region specifies regional formatting conventions and preferences that affect how data is displayed
  ///   in the map chart, including number formats, date formats, measurement units, and regional naming preferences.
  ///   For example, region "US" typically uses imperial measurements and month/day/year date format, while region "GB"
  ///   uses metric measurements and day/month/year format. The region code typically follows ISO 3166-1 alpha-2 (two-letter)
  ///   country codes. Culture region settings ensure that data presentation aligns with regional conventions and user
  ///   expectations. The culture region works in conjunction with <see cref="CultureLanguage"/> to provide complete
  ///   cultural localization, where region specifies formatting conventions and language specifies the language of text.
  ///   Together, these settings enable creation of map charts that are culturally appropriate and easily understandable
  ///   for specific audiences.
  /// </remarks>
  public string? CultureRegion { get; set; }

  /// <summary>
  ///   Gets or sets the attribution text that credits the geographic data source providers.
  /// </summary>
  /// <value>
  ///   A string containing the attribution text with credits to data providers,
  ///   or <c>null</c> if no attribution is specified.
  /// </value>
  /// <remarks>
   ///   The attribution text provides proper credit to the mapping services, geographic data providers, and other sources
  ///   that supplied the geographic information used in the map chart. This attribution is essential for legal compliance,
  ///   honoring data licensing agreements, and acknowledging the work of geographic data creators and maintainers. Common
  ///   attribution might include credits to commercial mapping services (such as Bing Maps or other providers), government
  ///   geographic databases, open-source mapping projects (such as OpenStreetMap contributors), or academic geographic
  ///   data sources. The attribution text may be displayed within the chart, in chart metadata, or in accompanying
  ///   documentation, depending on the provider's requirements and display context. Proper attribution ensures ethical
  ///   use of geographic data and helps maintain access to quality geographic data sources by acknowledging their
  ///   contributions.
  /// </remarks>
  public string? Attribution { get; set; }

  /// <summary>
  ///   Gets or sets the geographic data cache for offline access and performance optimization.
  /// </summary>
  /// <value>
  ///   A <see cref="GeoCache"/> object containing cached geographic data,
  ///   or <c>null</c> if no cache is configured.
  /// </value>
  /// <remarks>
  ///   The geographic cache stores previously retrieved geographic data including entity boundaries, coordinates,
  ///   query results, and hierarchical relationships. This cached data enables offline map chart rendering without
  ///   requiring active connections to external mapping services, improves performance by eliminating redundant
  ///   queries, and ensures consistent geographic representation even when original data sources are unavailable
  ///   or have updated their data. The cache includes various types of geographic information organized through
  ///   the <see cref="Clear"/> structure, supporting entity queries, child entity queries, point-to-entity mappings,
  ///   and hierarchical relationships. By maintaining this cached data within the document, map charts can be viewed
  ///   and rendered reliably across different environments, network conditions, and time periods. The cache is
  ///   particularly valuable for presentations, reports, and documents that need to work offline or in restricted
  ///   network environments. See <see cref="GeoCache"/> for details on the structure and content of cached geographic data.
  /// </remarks>
  public GeoCache? GeoCache { get; set; }
}