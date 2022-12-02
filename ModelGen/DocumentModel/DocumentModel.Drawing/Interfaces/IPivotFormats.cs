namespace DocumentModel.Drawing;

/// <summary>
/// pivot chart format persistence data.
/// </summary>
public interface IPivotFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPivotFormat>? PivotFormats { get ; set; }
  
}
