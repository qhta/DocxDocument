namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Shape Adjust List.
/// </summary>
public interface IAdjustList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IAdjust>? Adjusts { get ; set; }
  
}
