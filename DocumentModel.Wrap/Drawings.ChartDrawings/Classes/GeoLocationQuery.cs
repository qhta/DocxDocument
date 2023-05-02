namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoLocationQuery Class.
/// </summary>
public class GeoLocationQuery: ModelElement
{
  /// <summary>
  ///   countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public string? CountryRegion { get; set; }

  /// <summary>
  ///   adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  public string? AdminDistrict1 { get; set; }

  /// <summary>
  ///   adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  public string? AdminDistrict2 { get; set; }

  /// <summary>
  ///   postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  public string? PostalCode { get; set; }

  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get; set; }
}