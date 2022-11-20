namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Table Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShading))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableBorders))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellMarginDefault))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableJustification))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellSpacing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableIndentation))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableStyleRowBandSize))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableStyleColumnBandSize))]
public class StyleTableProperties: IStyleTableProperties
{
  /// <summary>
  /// TableStyleRowBandSize.
  /// </summary>
  public ITableStyleRowBandSize? TableStyleRowBandSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableStyleColumnBandSize.
  /// </summary>
  public ITableStyleColumnBandSize? TableStyleColumnBandSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public ITableJustification? TableJustification
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public ITableCellSpacing? TableCellSpacing
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public ITableIndentation? TableIndentation
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public ITableBorders? TableBorders
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public ITableCellMarginDefault? TableCellMarginDefault
  {
    get;
    set;
  }
  
}
