namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the GeoChildEntitiesQuery Class.
/// </summary>
public partial class GeoChildEntitiesQuery
{
  
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get; set; }
  
  
  /// <summary>
  ///   GeoChildTypes.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoChildTypes? GeoChildTypes { get; set; }
  
}
