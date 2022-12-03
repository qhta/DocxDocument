namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleSetHeader Class.
/// </summary>
public interface TupleSetHeader // : System.Boolean
{
  /// <summary>
  /// uniqueName, this property is only available in Office 2010 and later.
  /// </summary>
  public String? UniqueName { get ; set; }
  
  /// <summary>
  /// hierarchyName, this property is only available in Office 2010 and later.
  /// </summary>
  public String? HierarchyName { get ; set; }
  
}
