namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Data Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.INumericDimension))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IStringDimension))]
public interface IData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Id { get ; set; }
  
}
