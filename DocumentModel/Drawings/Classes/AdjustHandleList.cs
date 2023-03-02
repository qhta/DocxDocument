namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Adjust Handles.
/// </summary>
public record AdjustHandleList
{
  public AdjustHandleXY? AdjustHandleXY { get; set; }

  public AdjustHandlePolar? AdjustHandlePolar { get; set; }
}