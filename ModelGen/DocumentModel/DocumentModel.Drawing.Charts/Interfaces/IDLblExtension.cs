namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IExceptionForSave))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IShowDataLabelsRange))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ILayout))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IDataLabelFieldTable))]
public interface IDLblExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
