namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a cache of geographic data query results used for map-based chart visualizations.
/// </summary>
/// <remarks>
///   This class defines a geographic data cache that stores the results
///   of geographic queries to improve performance and enable offline access to map-based chart features. The GeoCache
///   serves as a local repository of geographic information retrieved from mapping services or geographic data providers,
///   reducing the need for repeated network requests and enabling charts to render quickly with previously retrieved
///   data. This caching mechanism is essential for map charts and geographic visualizations that display data by
///   country, state, region, or custom geographic boundaries. The cache contains binary-encoded geographic data
///   (<see cref = "XsdBase64Binary"/>) from a specific geographic data provider (<see cref = "Provider"/>), along with
///   structured query results (<see cref = "Clear"/>) that include location information, entity definitions, and
///   geographic relationships. By caching geographic data locally within the document, charts can display map-based
///   visualizations without requiring active internet connectivity or repeated calls to external mapping services.
///   This is particularly valuable for presentations, reports, or documents that need to work offline, in restricted
///   network environments, or when consistent geographic data representation is required across multiple document
///   openings. The cached data ensures geographic accuracy and visual consistency even when the original mapping
///   service is unavailable or has updated its data. The cache can be refreshed when connectivity is available to
///   incorporate updated geographic information, boundary changes, or new location data while preserving the ability
///   to render the chart using cached data when updates aren't possible.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoCache))]
public class GeoCache: ModelElement<DXO16DCD.GeoCache>
{
  /// <summary>
  /// Specifies the provider.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoCache.Provider))]
  public string? Provider { get => _Provider; set => UpdateField(ref _Provider, value, nameof(Provider)); }

  private string? _Provider;

  /// <summary>
  /// Specifies the xsd base64binary.
  /// </summary>
  public string? XsdBase64Binary
  {
    get => _XsdBase64Binary;
    set => UpdateField(ref _XsdBase64Binary, value, nameof(XsdBase64Binary));
  }

  private string? _XsdBase64Binary;

  /// <summary>
  /// Specifies the clear.
  /// </summary>
  public Clear? Clear { get => _Clear; set => UpdateField(ref _Clear, value, nameof(Clear)); }

  private Clear? _Clear;
}