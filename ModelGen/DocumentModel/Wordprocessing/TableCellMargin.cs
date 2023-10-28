namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of cell margins for a single table cell in the parent table.
/// </summary>
public partial class TableCellMargin
{
  
  /// <summary>
  ///   Table Cell Top Margin Exception.
  /// </summary>
  public DMW.TopMargin? TopMargin { get; set; }
  
  
  /// <summary>
  ///   Table Cell Left Margin Exception.
  /// </summary>
  public DMW.LeftMargin? LeftMargin { get; set; }
  
  
  /// <summary>
  ///   StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW.StartMargin? StartMargin { get; set; }
  
  
  /// <summary>
  ///   Table Cell Bottom Margin Exception.
  /// </summary>
  public DMW.BottomMargin? BottomMargin { get; set; }
  
  
  /// <summary>
  ///   Table Cell Right Margin Exception.
  /// </summary>
  public DMW.RightMargin? RightMargin { get; set; }
  
  
  /// <summary>
  ///   EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW.EndMargin? EndMargin { get; set; }
  
}
