namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CachedUniqueName Class.
/// </summary>
public interface ICachedUniqueName // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// index, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Name { get ; set; }
  
}
