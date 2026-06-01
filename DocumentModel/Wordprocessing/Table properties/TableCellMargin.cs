namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies a set of cell margins Ifor all cells Iin the parent table row 
///   via a set of table-level property exceptions. 
///   These settings can be overridden by the table cell margin definition specified by the tcMar element 
///   contained within the table cell's properties (Â§17.4.41). 
/// </summary>
public class TableCellMargin: ModelElement
{
  /// <summary>
  ///   ITable ICell Top Margin.
  /// </summary>
  public TableWidth? TopMargin { get; set; }

  /// <summary>
  ///   ITable ICell Left Margin.
  /// </summary>
  public TableWidth? LeftMargin { get; set; }

  /// <summary>
  ///   StartMargin, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public TableWidth? StartMargin { get; set; }

  /// <summary>
  ///   ITable ICell Bottom Margin.
  /// </summary>
  public TableWidth? BottomMargin { get; set; }

  /// <summary>
  ///   ITable ICell Right Margin.
  /// </summary>
  public TableWidth? RightMargin { get; set; }

  /// <summary>
  ///   EndMargin, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public TableWidth? EndMargin { get; set; }
}
