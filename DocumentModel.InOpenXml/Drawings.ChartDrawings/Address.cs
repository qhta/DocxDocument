namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a geographic address used for chart data visualization and mapping features.
/// </summary>
/// <remarks>
///   This class defines a structured address representation
///   used in chart drawings, particularly for geographic and map-based visualizations. The address contains
///   standardized components including street address, country/region, administrative districts, postal code,
///   locality, and ISO country code. This structured format enables accurate geocoding and location-based
///   data visualization in charts, supporting features such as map charts and geographic data series.
///   The address components follow international addressing standards to ensure compatibility across
///   different regions and mapping services.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.Address))]
[DataContract]
[XmlRoot("Address", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class Address : ModelElement<DXO16DCD.Address>
{
  /// <summary>
  /// Specifies the address1.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Address.Address1))]
  public string? Address1 { get => _Address1; set => UpdateField(ref _Address1, value, nameof(Address1)); }

  private string? _Address1;
  /// <summary>
  /// Specifies the country region.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Address.CountryRegion))]
  public string? CountryRegion { get => _CountryRegion; set => UpdateField(ref _CountryRegion, value, nameof(CountryRegion)); }

  private string? _CountryRegion;
  /// <summary>
  /// Specifies the admin district1.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Address.AdminDistrict1))]
  public string? AdminDistrict1 { get => _AdminDistrict1; set => UpdateField(ref _AdminDistrict1, value, nameof(AdminDistrict1)); }

  private string? _AdminDistrict1;
  /// <summary>
  /// Specifies the admin district2.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Address.AdminDistrict2))]
  public string? AdminDistrict2 { get => _AdminDistrict2; set => UpdateField(ref _AdminDistrict2, value, nameof(AdminDistrict2)); }

  private string? _AdminDistrict2;
  /// <summary>
  /// Specifies the postal code.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Address.PostalCode))]
  public string? PostalCode { get => _PostalCode; set => UpdateField(ref _PostalCode, value, nameof(PostalCode)); }

  private string? _PostalCode;
  /// <summary>
  /// Specifies the locality.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Address.Locality))]
  public string? Locality { get => _Locality; set => UpdateField(ref _Locality, value, nameof(Locality)); }

  private string? _Locality;
  /// <summary>
  /// Specifies the iso country code.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Address.IsoCountryCode))]
  public string? IsoCountryCode { get => _IsoCountryCode; set => UpdateField(ref _IsoCountryCode, value, nameof(IsoCountryCode)); }

  private string? _IsoCountryCode;
}