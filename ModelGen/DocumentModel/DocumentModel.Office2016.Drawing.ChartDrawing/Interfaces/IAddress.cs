namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Address Class.
/// </summary>
public interface IAddress // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// address1, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Address1 { get ; set; }
  
  /// <summary>
  /// countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? CountryRegion { get ; set; }
  
  /// <summary>
  /// adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? AdminDistrict1 { get ; set; }
  
  /// <summary>
  /// adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? AdminDistrict2 { get ; set; }
  
  /// <summary>
  /// postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? PostalCode { get ; set; }
  
  /// <summary>
  /// locality, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Locality { get ; set; }
  
  /// <summary>
  /// isoCountryCode, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? IsoCountryCode { get ; set; }
  
}
