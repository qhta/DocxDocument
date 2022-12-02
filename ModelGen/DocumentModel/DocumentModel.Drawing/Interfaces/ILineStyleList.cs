namespace DocumentModel.Drawing;

/// <summary>
/// Line Style List.
/// </summary>
public interface ILineStyleList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IOutline>? Outlines { get ; set; }
  
}
