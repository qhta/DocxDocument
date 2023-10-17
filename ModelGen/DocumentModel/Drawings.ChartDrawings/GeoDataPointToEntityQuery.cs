namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the GeoDataPointToEntityQuery Class.
/// </summary>
public partial class GeoDataPointToEntityQuery
{
  
  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? EntityType { get; set; }
  
  
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get; set; }
  
}
