namespace DocumentModel.Drawing;

/// <summary>
/// Shape Adjust List.
/// </summary>
public interface IAdjustList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IAdjust>? Adjusts { get ; set; }
  
}
