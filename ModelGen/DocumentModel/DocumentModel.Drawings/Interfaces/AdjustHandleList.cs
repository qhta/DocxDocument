namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public partial interface AdjustHandleList
{
  public DocumentModel.Drawings.AdjustHandleXY? AdjustHandleXY { get; set; }
  
  public DocumentModel.Drawings.AdjustHandlePolar? AdjustHandlePolar { get; set; }
  
}
