namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the CachedUniqueName Class.
/// </summary>
public interface ICachedUniqueName // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// index, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
}
