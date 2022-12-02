namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public interface INumericDimension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public NumericDimensionType? Type { get ; set; }
  
  public IOpenXmlFormulaElement? Formula { get ; set; }
  
  public IOpenXmlFormulaElement? NfFormula { get ; set; }
  
  public Collection<INumericLevel>? NumericLevels { get ; set; }
  
}
