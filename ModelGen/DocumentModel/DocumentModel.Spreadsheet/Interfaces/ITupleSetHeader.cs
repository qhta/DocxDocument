namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleSetHeader Class.
/// </summary>
public interface ITupleSetHeader // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// uniqueName, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? UniqueName { get ; set; }
  
  /// <summary>
  /// hierarchyName, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? HierarchyName { get ; set; }
  
}
