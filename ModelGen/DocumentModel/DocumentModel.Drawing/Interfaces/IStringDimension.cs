namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public interface IStringDimension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public StringDimensionType? Type { get ; set; }
  
  public IOpenXmlFormulaElement? Formula { get ; set; }
  
  public IOpenXmlFormulaElement? NfFormula { get ; set; }
  
  public Collection<IStringLevel>? StringLevels { get ; set; }
  
}
