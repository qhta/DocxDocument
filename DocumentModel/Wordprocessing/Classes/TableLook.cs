namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableLook Class.
/// </summary>
public partial class TableLook
{
  /// <summary>
  /// val
  /// </summary>
  public DocumentModel.HexBinary? Val { get; set; }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstRow { get; set; }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastRow { get; set; }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstColumn { get; set; }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastColumn { get; set; }
  
  /// <summary>
  /// noHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoHorizontalBand { get; set; }
  
  /// <summary>
  /// noVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoVerticalBand { get; set; }
  
}
