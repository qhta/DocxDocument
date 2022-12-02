namespace DocumentModel.Drawing;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public interface IAdjustHandleList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IAdjustHandleXY>? AdjustHandleXYs { get ; set; }
  
  public Collection<IAdjustHandlePolar>? AdjustHandlePolars { get ; set; }
  
}
