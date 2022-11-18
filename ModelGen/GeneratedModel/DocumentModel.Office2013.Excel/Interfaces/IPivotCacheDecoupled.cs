namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotCacheDecoupled Class.
/// </summary>
public interface IPivotCacheDecoupled // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// decoupled, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Decoupled { get ; set; }
  
}
