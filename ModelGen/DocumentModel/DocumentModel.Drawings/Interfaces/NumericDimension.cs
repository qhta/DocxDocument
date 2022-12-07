namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public interface NumericDimension
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public NumericDimensionType? Type { get ; set; }
  
  public OpenXmlFormulaElement? Formula { get ; set; }
  
  public OpenXmlFormulaElement? NfFormula { get ; set; }
  
}
