namespace DocumentModel.Spreadsheet;

/// <summary>
/// View Pane.
/// </summary>
public class Pane: IPane
{
  /// <summary>
  /// Horizontal Split Position
  /// </summary>
  public double? HorizontalSplit
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Split Position
  /// </summary>
  public double? VerticalSplit
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top Left Visible Cell
  /// </summary>
  public string? TopLeftCell
  {
    get;
    set;
  }
  
  /// <summary>
  /// Active Pane
  /// </summary>
  public PaneValues? ActivePane
  {
    get;
    set;
  }
  
  /// <summary>
  /// Split State
  /// </summary>
  public PaneStateValues? State
  {
    get;
    set;
  }
  
}
