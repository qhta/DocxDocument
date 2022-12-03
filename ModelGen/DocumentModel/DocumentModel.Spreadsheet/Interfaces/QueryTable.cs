namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the QueryTable Class.
/// </summary>
public interface QueryTable // : System.Boolean
{
  /// <summary>
  /// clipped, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Clipped { get ; set; }
  
  /// <summary>
  /// sourceDataName, this property is only available in Office 2013 and later.
  /// </summary>
  public String? SourceDataName { get ; set; }
  
  /// <summary>
  /// drillThrough, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? DrillThrough { get ; set; }
  
}
