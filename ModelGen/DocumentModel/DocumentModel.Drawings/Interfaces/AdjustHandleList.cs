namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public interface AdjustHandleList
{
  public AdjustHandleXY? AdjustHandleXY { get ; set; }
  
  public AdjustHandlePolar? AdjustHandlePolar { get ; set; }
  
}
