namespace DocumentModel.Drawings;

/// <summary>
///   Defines the CompatExtension interface.
/// </summary>
public interface CompatExtension: IModelElement
{
  /// <summary>
  ///   spid
  /// </summary>
  public string? ShapeId { get; set; }
}