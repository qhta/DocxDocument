namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the OpenXmlTickMarksElement Class.
/// </summary>
public interface IOpenXmlTickMarksElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.TickMarksType? Type { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
