namespace DocumentModel.Drawings;

/// <summary>
///   Defines the CameraTool interface.
/// </summary>
public interface CameraTool: IModelElement
{
  /// <summary>
  ///   cellRange
  /// </summary>
  public string? CellRange { get; set; }
  /// <summary>
  ///   spid
  /// </summary>
  public string? ShapeId { get; set; }
}