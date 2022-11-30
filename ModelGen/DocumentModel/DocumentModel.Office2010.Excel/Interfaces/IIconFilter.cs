namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the IconFilter Class.
/// </summary>
public interface IIconFilter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// iconSet, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.IconSetKind? IconSet { get ; set; }
  
  /// <summary>
  /// iconId, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? IconId { get ; set; }
  
}
