namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Data Class.
/// </summary>
public interface IData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.INumericDimension? NumericDimension { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IStringDimension? StringDimension { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
