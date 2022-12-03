namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheField Class.
/// </summary>
public interface CacheField // : System.Boolean
{
  /// <summary>
  /// ignore, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Ignore { get ; set; }
  
}
