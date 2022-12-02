namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotHierarchy Class.
/// </summary>
public interface IPivotHierarchy // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// ignore, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Ignore { get ; set; }
  
}
