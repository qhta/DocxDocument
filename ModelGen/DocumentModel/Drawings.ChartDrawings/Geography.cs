namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the Geography Class.
/// </summary>
public partial class Geography
{
  
  /// <summary>
  ///   cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CultureLanguage { get; set; }
  
  
  /// <summary>
  ///   cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CultureRegion { get; set; }
  
  
  /// <summary>
  ///   attribution, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Attribution { get; set; }
  
  
  /// <summary>
  ///   GeoCache.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoCache? GeoCache { get; set; }
  
}
