namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotHierarchy Class.
/// </summary>
public interface PivotHierarchy // : System.Boolean
{
  /// <summary>
  /// ignore, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Ignore { get ; set; }
  
}
