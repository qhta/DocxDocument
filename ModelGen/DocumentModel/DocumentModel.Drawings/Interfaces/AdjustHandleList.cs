namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public interface AdjustHandleList
{
  public Collection<AdjustHandleXY>? AdjustHandleXYs { get ; set; }
  
  public Collection<AdjustHandlePolar>? AdjustHandlePolars { get ; set; }
  
}
