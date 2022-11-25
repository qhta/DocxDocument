namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoLocationQuery Class.
/// </summary>
public interface IGeoLocationQuery // : DocumentModel.ITypedOpenXmlLeafElement
{
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
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.EntityTypeEnum? EntityType { get ; set; }
  
}
