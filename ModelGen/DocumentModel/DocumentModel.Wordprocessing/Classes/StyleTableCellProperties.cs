namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Table Cell Properties.
/// </summary>
public class StyleTableCellProperties
{
  /// <summary>
  /// Shading.
  /// </summary>
  public Shading? Shading
  {
    get;
    set;
  }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  public OnOffOnlyKind? NoWrap
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public TableCellMargin? TableCellMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public TableVerticalAlignmentKind? TableCellVerticalAlignment
  {
    get;
    set;
  }
  
}
