namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the components of the conditional formatting of the referenced table style (if one exists) which shall be applied to the set of table rows with the current table-level property exceptions. A table style can specify up to six different optional conditional formats, which then can be applied or omitted from individual table rows in the parent table.
/// </summary>
public partial class TableLook
{
  
  /// <summary>
  ///   val
  /// </summary>
  public DM.HexBinary? Val { get; set; }
  
  
  /// <summary>
  ///   firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstRow { get; set; }
  
  
  /// <summary>
  ///   lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastRow { get; set; }
  
  
  /// <summary>
  ///   firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstColumn { get; set; }
  
  
  /// <summary>
  ///   lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastColumn { get; set; }
  
  
  /// <summary>
  ///   noHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoHorizontalBand { get; set; }
  
  
  /// <summary>
  ///   noVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoVerticalBand { get; set; }
  
}
