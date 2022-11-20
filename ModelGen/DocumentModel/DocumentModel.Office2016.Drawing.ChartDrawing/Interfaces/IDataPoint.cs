namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
public interface IDataPoint // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Idx { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
