namespace DocumentModel.Drawings;

/// <summary>
/// Camera tool settings for drawing elements.
/// </summary>
public class CameraTool: ModelElement
{
  /// <summary>
  /// Cell range.
  /// </summary>
  public string? CellRange { get; set; }

  /// <summary>
  /// Shape ID.
  /// </summary>
  public string? ShapeId { get; set; }
}