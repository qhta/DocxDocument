namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CustomFilter Class.
/// </summary>
public interface ICustomFilter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// operator, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.FilterOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Val { get ; set; }
  
}
