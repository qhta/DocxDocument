namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoLocation Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IAddress))]
public class GeoLocation: IGeoLocation
{
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public double? Latitude
  {
    get;
    set;
  }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public double? Longitude
  {
    get;
    set;
  }
  
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityName
  {
    get;
    set;
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Address.
  /// </summary>
  public IAddress? Address
  {
    get;
    set;
  }
  
}
