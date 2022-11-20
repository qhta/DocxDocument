namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotTableReference Class.
/// </summary>
public interface IPivotTableReference // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id { get ; set; }
  
}
