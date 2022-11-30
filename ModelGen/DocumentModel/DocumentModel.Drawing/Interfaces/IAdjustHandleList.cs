namespace DocumentModel.Drawing;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public interface IAdjustHandleList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.IAdjustHandleXY? AdjustHandleXY { get ; set; }
  
  public DocumentModel.Drawing.IAdjustHandlePolar? AdjustHandlePolar { get ; set; }
  
}
