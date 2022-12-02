namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilter Class.
/// </summary>
public interface IPivotFilter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// useWholeDay, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? UseWholeDay { get ; set; }
  
}
