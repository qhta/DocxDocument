namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotField Class.
/// </summary>
public class PivotField: IPivotField
{
  /// <summary>
  /// fillDownLabels, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FillDownLabels
  {
    get;
    set;
  }
  
  /// <summary>
  /// ignore, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Ignore
  {
    get;
    set;
  }
  
}
