namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilter Class.
/// </summary>
public interface PivotFilter // : System.Boolean
{
  /// <summary>
  /// useWholeDay, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? UseWholeDay { get ; set; }
  
}
