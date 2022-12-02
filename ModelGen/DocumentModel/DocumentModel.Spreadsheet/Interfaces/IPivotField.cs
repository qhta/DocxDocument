namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotField Class.
/// </summary>
public interface IPivotField // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// fillDownLabels, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FillDownLabels { get ; set; }
  
  /// <summary>
  /// ignore, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Ignore { get ; set; }
  
}
