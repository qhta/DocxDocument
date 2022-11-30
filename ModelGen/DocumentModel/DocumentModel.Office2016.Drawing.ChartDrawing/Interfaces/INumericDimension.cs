namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public interface INumericDimension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.NumericDimensionType? Type { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IOpenXmlFormulaElement? Formula { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IOpenXmlFormulaElement? NfFormula { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2016.Drawing.ChartDrawing.INumericLevel>? NumericLevels { get ; set; }
  
}
