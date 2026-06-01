namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the GeoChildEntities Class.
/// </summary>
public class GeoChildEntities: ModelElement
{
  public Collection<GeoHierarchyEntity>? GeoHierarchyEntities { get; set; }
}
