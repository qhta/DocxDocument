namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the TabularSlicerCacheItem Class.
/// </summary>
public interface ITabularSlicerCacheItem // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// x, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Atom { get ; set; }
  
  /// <summary>
  /// s, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? IsSelected { get ; set; }
  
  /// <summary>
  /// nd, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NonDisplay { get ; set; }
  
}
