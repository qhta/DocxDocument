namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoEntity Class.
/// </summary>
public interface GeoEntity: IModelElement
{
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityName { get; set; }
  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get; set; }
}