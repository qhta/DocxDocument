namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotHierarchy Class.
/// </summary>
public interface IPivotHierarchy // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// ignore, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Ignore { get ; set; }
  
}
