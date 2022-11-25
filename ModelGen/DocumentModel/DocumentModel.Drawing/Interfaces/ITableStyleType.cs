namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TableStyleType Class.
/// </summary>
public interface ITableStyleType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Style ID
  /// </summary>
  public System.String? StyleId { get ; set; }
  
  /// <summary>
  /// Name
  /// </summary>
  public System.String? StyleName { get ; set; }
  
  /// <summary>
  /// Table Background.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? TableBackground { get ; set; }
  
  /// <summary>
  /// Whole Table.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? WholeTable { get ; set; }
  
  /// <summary>
  /// Band 1 Horizontal.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? Band1Horizontal { get ; set; }
  
  /// <summary>
  /// Band 2 Horizontal.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? Band2Horizontal { get ; set; }
  
  /// <summary>
  /// Band 1 Vertical.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? Band1Vertical { get ; set; }
  
  /// <summary>
  /// Band 2 Vertical.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? Band2Vertical { get ; set; }
  
  /// <summary>
  /// Last Column.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? LastColumn { get ; set; }
  
  /// <summary>
  /// First Column.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? FirstColumn { get ; set; }
  
  /// <summary>
  /// Last Row.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? LastRow { get ; set; }
  
  /// <summary>
  /// Southeast Cell.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? SoutheastCell { get ; set; }
  
  /// <summary>
  /// Southwest Cell.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? SouthwestCell { get ; set; }
  
  /// <summary>
  /// First Row.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? FirstRow { get ; set; }
  
  /// <summary>
  /// Northeast Cell.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? NortheastCell { get ; set; }
  
  /// <summary>
  /// Northwest Cell.
  /// </summary>
  public DocumentModel.Drawing.ITablePartStyleType? NorthwestCell { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
