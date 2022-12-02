namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public interface INumericDimension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawing.NumericDimensionType? Type { get ; set; }
  
  public DocumentModel.Drawing.IOpenXmlFormulaElement? Formula { get ; set; }
  
  public DocumentModel.Drawing.IOpenXmlFormulaElement? NfFormula { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.INumericLevel>? NumericLevels { get ; set; }
  
}
