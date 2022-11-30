namespace DocumentModel.Drawing.Charts;

/// <summary>
/// pivot chart format persistence data.
/// </summary>
public interface IPivotFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IPivotFormat>? PivotFormats { get ; set; }
  
}
