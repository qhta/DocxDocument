namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public interface IStringDimension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawing.StringDimensionType? Type { get ; set; }
  
  public DocumentModel.Drawing.IOpenXmlFormulaElement? Formula { get ; set; }
  
  public DocumentModel.Drawing.IOpenXmlFormulaElement? NfFormula { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IStringLevel>? StringLevels { get ; set; }
  
}
