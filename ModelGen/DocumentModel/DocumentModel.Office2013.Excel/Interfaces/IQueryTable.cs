namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the QueryTable Class.
/// </summary>
public interface IQueryTable // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// clipped, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? Clipped { get ; set; }
  
  /// <summary>
  /// sourceDataName, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? SourceDataName { get ; set; }
  
  /// <summary>
  /// drillThrough, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? DrillThrough { get ; set; }
  
}
