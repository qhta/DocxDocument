namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotCacheDecoupled Class.
/// </summary>
public interface PivotCacheDecoupled // : System.Boolean
{
  /// <summary>
  /// decoupled, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Decoupled { get ; set; }
  
}
