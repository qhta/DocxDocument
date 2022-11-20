namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RowColVisualOps Class.
/// </summary>
public interface IRowColVisualOps // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// action, this property is only available in Office 2016 and later.
  /// </summary>
  public RowColVisualOp? Action { get ; set; }
  
  /// <summary>
  /// isRow, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? IsRow { get ; set; }
  
  /// <summary>
  /// size, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Size { get ; set; }
  
  /// <summary>
  /// userSized, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? UserSized { get ; set; }
  
}
