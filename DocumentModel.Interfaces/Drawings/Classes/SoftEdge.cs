namespace DocumentModel.Drawings;

/// <summary>
///   Soft Edge Effect.
/// </summary>
public interface SoftEdge: IModelElement
{
  /// <summary>
  ///   Radius
  /// </summary>
  public Int64? Radius { get; set; }
}