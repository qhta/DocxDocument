namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public interface AdjustHandleList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<AdjustHandleXY>? AdjustHandleXYs { get ; set; }
  
  public Collection<AdjustHandlePolar>? AdjustHandlePolars { get ; set; }
  
}
