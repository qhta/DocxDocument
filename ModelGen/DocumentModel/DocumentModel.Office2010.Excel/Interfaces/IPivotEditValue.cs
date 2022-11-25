namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotEditValue Class.
/// </summary>
public interface IPivotEditValue // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// valueType, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.PivotEditValueTypeKind? ValueType { get ; set; }
  
}
