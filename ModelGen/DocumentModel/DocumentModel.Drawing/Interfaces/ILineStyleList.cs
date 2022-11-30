namespace DocumentModel.Drawing;

/// <summary>
/// Line Style List.
/// </summary>
public interface ILineStyleList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IOutline>? Outlines { get ; set; }
  
}
