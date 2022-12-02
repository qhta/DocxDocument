namespace DocumentModel.Drawing;

/// <summary>
/// pivot chart format persistence data.
/// </summary>
public interface IPivotFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IPivotFormat>? PivotFormats { get ; set; }
  
}
