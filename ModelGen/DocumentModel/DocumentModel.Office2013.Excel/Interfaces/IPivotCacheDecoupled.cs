namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotCacheDecoupled Class.
/// </summary>
public interface IPivotCacheDecoupled // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// decoupled, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? Decoupled { get ; set; }
  
}
