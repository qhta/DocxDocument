namespace DocumentModel.Drawing;

/// <summary>
/// Tab Stop.
/// </summary>
public class TabStop: ITabStop
{
  /// <summary>
  /// Tab Position
  /// </summary>
  public int? Position
  {
    get;
    set;
  }
  
  /// <summary>
  /// Tab Alignment
  /// </summary>
  public TextTabAlignmentValues? Alignment
  {
    get;
    set;
  }
  
}
