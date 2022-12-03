namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotField Class.
/// </summary>
public interface PivotField // : System.Boolean
{
  /// <summary>
  /// fillDownLabels, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FillDownLabels { get ; set; }
  
  /// <summary>
  /// ignore, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Ignore { get ; set; }
  
}
