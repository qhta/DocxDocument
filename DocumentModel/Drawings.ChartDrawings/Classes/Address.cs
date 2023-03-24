namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Address Class.
/// </summary>
public class Address: ModelElement
{
  /// <summary>
  ///   address1, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Address1 { get; set; }

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
  ///   locality, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Locality { get; set; }

  /// <summary>
  ///   isoCountryCode, this property is only available in Office 2016 and later.
  /// </summary>
  public String? IsoCountryCode { get; set; }
}