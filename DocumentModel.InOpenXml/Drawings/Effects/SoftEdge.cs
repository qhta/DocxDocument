namespace DocumentModel.Drawings;

/// <summary>
///   Represents a soft edge effect, allowing adjustment of the edge radius for a drawing element.
/// </summary>
public interface SoftEdge
{
  /// <summary>
  ///   Radius of the soft edge effect.
  /// </summary>
  public Int64? Radius { get; set; }
}