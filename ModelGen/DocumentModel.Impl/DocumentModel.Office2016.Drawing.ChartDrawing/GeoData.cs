namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ICopyrights))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoPolygons))]
public class GeoData: IGeoData
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityName
  {
    get;
    set;
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityId
  {
    get;
    set;
  }
  
  /// <summary>
  /// east, this property is only available in Office 2016 and later.
  /// </summary>
  public double? East
  {
    get;
    set;
  }
  
  /// <summary>
  /// west, this property is only available in Office 2016 and later.
  /// </summary>
  public double? West
  {
    get;
    set;
  }
  
  /// <summary>
  /// north, this property is only available in Office 2016 and later.
  /// </summary>
  public double? North
  {
    get;
    set;
  }
  
  /// <summary>
  /// south, this property is only available in Office 2016 and later.
  /// </summary>
  public double? South
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoPolygons.
  /// </summary>
  public IGeoPolygons? GeoPolygons
  {
    get;
    set;
  }
  
  /// <summary>
  /// Copyrights.
  /// </summary>
  public ICopyrights? Copyrights
  {
    get;
    set;
  }
  
}
