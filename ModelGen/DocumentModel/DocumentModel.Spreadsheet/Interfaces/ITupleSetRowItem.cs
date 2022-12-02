namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleSetRowItem Class.
/// </summary>
public interface ITupleSetRowItem // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// u, this property is only available in Office 2010 and later.
  /// </summary>
  public String? UniqueName { get ; set; }
  
  /// <summary>
  /// d, this property is only available in Office 2010 and later.
  /// </summary>
  public String? DisplayName { get ; set; }
  
}
