namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public interface StringDimension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public StringDimensionType? Type { get ; set; }
  
  public OpenXmlFormulaElement? Formula { get ; set; }
  
  public OpenXmlFormulaElement? NfFormula { get ; set; }
  
  public Collection<StringLevel>? StringLevels { get ; set; }
  
}
