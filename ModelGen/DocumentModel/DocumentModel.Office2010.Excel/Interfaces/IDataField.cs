namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataField Class.
/// </summary>
public interface IDataField // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// pivotShowAs, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.PivotShowAsKind? PivotShowAs { get ; set; }
  
  /// <summary>
  /// sourceField, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? SourceField { get ; set; }
  
  /// <summary>
  /// uniqueName, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? UniqueName { get ; set; }
  
}
