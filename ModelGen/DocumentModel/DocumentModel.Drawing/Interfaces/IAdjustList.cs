namespace DocumentModel.Drawing;

/// <summary>
/// Shape Adjust List.
/// </summary>
public interface IAdjustList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IAdjust>? Adjusts { get ; set; }
  
}
