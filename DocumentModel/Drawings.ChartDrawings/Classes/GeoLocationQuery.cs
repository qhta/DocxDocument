namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocationQuery Class.
/// </summary>
public class GeoLocationQuery: ModelElement
{
  /// <summary>
  ///   countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CountryRegion { get; set; }

  /// <summary>
  ///   adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  public String? AdminDistrict1 { get; set; }

  /// <summary>
  ///   adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  public String? AdminDistrict2 { get; set; }

  /// <summary>
  ///   postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  public String? PostalCode { get; set; }

  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get; set; }
}