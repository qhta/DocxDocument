namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
public interface IAxisUnits // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.AxisUnit? Unit { get ; set; }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IAxisUnitsLabel? AxisUnitsLabel { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
