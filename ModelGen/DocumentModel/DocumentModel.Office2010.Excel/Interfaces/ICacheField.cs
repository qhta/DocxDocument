namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CacheField Class.
/// </summary>
public interface ICacheField // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// ignore, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Ignore { get ; set; }
  
}
