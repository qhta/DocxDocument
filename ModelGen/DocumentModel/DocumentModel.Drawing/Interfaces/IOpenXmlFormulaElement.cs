namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OpenXmlFormulaElement Class.
/// </summary>
public interface IOpenXmlFormulaElement // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// dir, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawing.FormulaDirection? Dir { get ; set; }
  
}
