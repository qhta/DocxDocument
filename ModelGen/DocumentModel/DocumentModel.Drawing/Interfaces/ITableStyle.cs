namespace DocumentModel.Drawing;

/// <summary>
/// Table Style.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableBackground))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IWholeTable))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBand1Horizontal))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBand2Horizontal))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBand1Vertical))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBand2Vertical))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILastColumn))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFirstColumn))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILastRow))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISoutheastCell))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISouthwestCell))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFirstRow))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INortheastCell))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INorthwestCell))]
public interface ITableStyle // : DocumentFormat.OpenXml.Drawing.TableStyleType
{
  /// <summary>
  /// Style ID
  /// </summary>
  public string? StyleId { get ; set; }
  
  /// <summary>
  /// Name
  /// </summary>
  public string? StyleName { get ; set; }
  
  /// <summary>
  /// Table Background.
  /// </summary>
  public ITableBackground? TableBackground { get ; set; }
  
  /// <summary>
  /// Whole Table.
  /// </summary>
  public IWholeTable? WholeTable { get ; set; }
  
  /// <summary>
  /// Band 1 Horizontal.
  /// </summary>
  public IBand1Horizontal? Band1Horizontal { get ; set; }
  
  /// <summary>
  /// Band 2 Horizontal.
  /// </summary>
  public IBand2Horizontal? Band2Horizontal { get ; set; }
  
  /// <summary>
  /// Band 1 Vertical.
  /// </summary>
  public IBand1Vertical? Band1Vertical { get ; set; }
  
  /// <summary>
  /// Band 2 Vertical.
  /// </summary>
  public IBand2Vertical? Band2Vertical { get ; set; }
  
  /// <summary>
  /// Last Column.
  /// </summary>
  public ILastColumn? LastColumn { get ; set; }
  
  /// <summary>
  /// First Column.
  /// </summary>
  public IFirstColumn? FirstColumn { get ; set; }
  
  /// <summary>
  /// Last Row.
  /// </summary>
  public ILastRow? LastRow { get ; set; }
  
  /// <summary>
  /// Southeast Cell.
  /// </summary>
  public ISoutheastCell? SoutheastCell { get ; set; }
  
  /// <summary>
  /// Southwest Cell.
  /// </summary>
  public ISouthwestCell? SouthwestCell { get ; set; }
  
  /// <summary>
  /// First Row.
  /// </summary>
  public IFirstRow? FirstRow { get ; set; }
  
  /// <summary>
  /// Northeast Cell.
  /// </summary>
  public INortheastCell? NortheastCell { get ; set; }
  
  /// <summary>
  /// Northwest Cell.
  /// </summary>
  public INorthwestCell? NorthwestCell { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
