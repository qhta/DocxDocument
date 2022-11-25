namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableLook Class.
/// </summary>
public interface ITableLook // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val
  /// </summary>
  public DocumentModel.IHexBinaryValue? Val { get ; set; }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FirstRow { get ; set; }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? LastRow { get ; set; }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FirstColumn { get ; set; }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? LastColumn { get ; set; }
  
  /// <summary>
  /// noHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? NoHorizontalBand { get ; set; }
  
  /// <summary>
  /// noVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? NoVerticalBand { get ; set; }
  
}
