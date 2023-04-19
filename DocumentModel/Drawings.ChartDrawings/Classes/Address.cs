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
  public string? Address1 { get; set; }

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
  ///   locality, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Locality { get; set; }

  /// <summary>
  ///   isoCountryCode, this property is only available in Office 2016 and later.
  /// </summary>
  public string? IsoCountryCode { get; set; }
}