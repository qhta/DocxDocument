namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the CachedUniqueName Class.
/// </summary>
public interface ICachedUniqueName // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// index, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Index { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name { get ; set; }
  
}
