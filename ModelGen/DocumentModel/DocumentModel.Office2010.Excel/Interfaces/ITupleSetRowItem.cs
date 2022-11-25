namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the TupleSetRowItem Class.
/// </summary>
public interface ITupleSetRowItem // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// u, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? UniqueName { get ; set; }
  
  /// <summary>
  /// d, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? DisplayName { get ; set; }
  
}
