namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoParentEntitiesQuery Class.
/// </summary>
public class GeoParentEntitiesQuery: ModelElement
{
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get; set; }
}