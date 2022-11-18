namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotFilter Class.
/// </summary>
public interface IPivotFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// useWholeDay, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? UseWholeDay { get ; set; }
  
}
