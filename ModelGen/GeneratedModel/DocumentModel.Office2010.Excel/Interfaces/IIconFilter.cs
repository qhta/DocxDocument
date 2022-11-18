namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the IconFilter Class.
/// </summary>
public interface IIconFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// iconSet, this property is only available in Office 2010 and later.
  /// </summary>
  public IconSetType? IconSet { get ; set; }
  
  /// <summary>
  /// iconId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? IconId { get ; set; }
  
}
