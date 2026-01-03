namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildTypes Class.
/// </summary>
public interface GeoChildTypes: IModelElement
{
  public Collection<String>? EntityTypes { get; set; }
}